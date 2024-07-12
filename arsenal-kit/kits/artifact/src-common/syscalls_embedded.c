/*
    Functions and definitions to support the use of system calls

    This file was generated using the SysWhispers3 public repository
    with additional modifications.

    Credits:
       https://github.com/klezVirus/SysWhispers3
       https://github.com/helpsystems/nanodump
*/

#include "syscalls.h"
#include <stdio.h>

/* disable warning -Warray-bounds caused by the __read[fs|gs]dword functions */
#pragma GCC diagnostic push
#pragma GCC diagnostic ignored "-Warray-bounds"

//#define DEBUG

// JUMPER

#ifdef _M_IX86

EXTERN_C PVOID internal_cleancall_wow64_gate(VOID) {
    return (PVOID)__readfsdword(0xC0);
}

__declspec(naked) BOOL local_is_wow64(void)
{
    asm(
        "mov eax, fs:[0xc0] \n"
        "test eax, eax \n"
        "jne wow64 \n"
        "mov eax, 0 \n"
        "ret \n"
        "wow64: \n"
        "mov eax, 1 \n"
        "ret \n"
    );
}

#endif

// Code below is adapted from @modexpblog. Read linked article for more details.
// https://www.mdsec.co.uk/2020/12/bypassing-user-mode-hooks-and-direct-invocation-of-system-calls-for-red-teams

SW3_SYSCALL_LIST SW3_SyscallList = {};
PVOID fastCall = NULL;

// SEARCH_AND_REPLACE
#ifdef SEARCH_AND_REPLACE
// THIS IS NOT DEFINED HERE; don't know if I'll add it in a future release
EXTERN void SearchAndReplace(unsigned char[], unsigned char[]);
#endif

DWORD SW3_HashSyscall(PCSTR FunctionName)
{
    DWORD i = 0;
    DWORD Hash = SW3_SEED;

    while (FunctionName[i])
    {
        WORD PartialName = *(WORD*)((ULONG_PTR)FunctionName + i++);
        Hash ^= PartialName + SW3_ROR8(Hash);
    }

    return Hash;
}


#ifdef _WIN64
// If the process is 64-bit on a 64-bit OS, we need to search for syscall
BYTE syscall_code[] = { 0x0f, 0x05, 0xc3 };
#else
// If the process is 32-bit on a 32-bit OS, we need to search for sysenter
BYTE syscall_code[] = { 0x0f, 0x34, 0xc3 };
#endif
#ifdef JUMPER
PVOID SC_Address(PVOID NtApiAddress, ULONG distance_to_syscall, ULONG distance_to_next_func)
{
    DWORD searchLimit = 512;
    PVOID SyscallAddress;

    #ifdef _M_IX86
    // If the process is 32-bit on a 64-bit OS, we need to jump to WOW32Reserved
    if (local_is_wow64())
    {
    #ifdef DEBUG
        printf("[+] Running 32-bit app on x64 (WOW64)\n");
    #endif
        // if we are a WoW64 process, jump to WOW32Reserved
        SyscallAddress = (PVOID)__readfsdword(0xc0);
        return SyscallAddress;
    }
    #endif

    // we don't really care if there is a 'jmp' between
    // NtApiAddress and the 'syscall; ret' instructions
    SyscallAddress = SW3_RVA2VA(PVOID, NtApiAddress, distance_to_syscall);

    if (!memcmp((PVOID)syscall_code, SyscallAddress, sizeof(syscall_code)))
    {
        // we can use the original code for this system call :)
        #if defined(DEBUG)
            printf("Found Syscall Opcodes at address 0x%p\n", SyscallAddress);
        #endif
        return SyscallAddress;
    }

    // the 'syscall; ret' instructions have not been found,
    // we will try to use one near it, similarly to HalosGate

    for (ULONG32 num_jumps = 1; num_jumps < searchLimit; num_jumps++)
    {
        // let's try with an Nt* API below our syscall
        SyscallAddress = SW3_RVA2VA(
            PVOID,
            NtApiAddress,
            distance_to_syscall + num_jumps * distance_to_next_func);
        if (!memcmp((PVOID)syscall_code, SyscallAddress, sizeof(syscall_code)))
        {
        #if defined(DEBUG)
            printf("Found Syscall Opcodes at address 0x%p\n", SyscallAddress);
        #endif
            return SyscallAddress;
        }

        // let's try with an Nt* API above our syscall
        SyscallAddress = SW3_RVA2VA(
            PVOID,
            NtApiAddress,
            distance_to_syscall - num_jumps * distance_to_next_func);
        if (!memcmp((PVOID)syscall_code, SyscallAddress, sizeof(syscall_code)))
        {
        #if defined(DEBUG)
            printf("Found Syscall Opcodes at address 0x%p\n", SyscallAddress);
        #endif
            return SyscallAddress;
        }
    }

#ifdef DEBUG
    printf("Syscall Opcodes not found!\n");
#endif

    return NULL;
}
#endif


BOOL SW3_PopulateSyscallList()
{
    // Return early if the list is already populated.
    if (SW3_SyscallList.Count) return TRUE;

    #ifdef _WIN64
    PSW3_PEB Peb = (PSW3_PEB)__readgsqword(0x60);
    #else
    PSW3_PEB Peb = (PSW3_PEB)__readfsdword(0x30);
    #endif
    PSW3_PEB_LDR_DATA Ldr = Peb->Ldr;
    PIMAGE_EXPORT_DIRECTORY ExportDirectory = NULL;
    PVOID DllBase = NULL;

    // Get the DllBase address of NTDLL.dll. NTDLL is not guaranteed to be the second
    // in the list, so it's safer to loop through the full list and find it.
    PSW3_LDR_DATA_TABLE_ENTRY LdrEntry;
    for (LdrEntry = (PSW3_LDR_DATA_TABLE_ENTRY)Ldr->Reserved2[1]; LdrEntry->DllBase != NULL; LdrEntry = (PSW3_LDR_DATA_TABLE_ENTRY)LdrEntry->Reserved1[0])
    {
        DllBase = LdrEntry->DllBase;
        PIMAGE_DOS_HEADER DosHeader = (PIMAGE_DOS_HEADER)DllBase;
        PIMAGE_NT_HEADERS NtHeaders = SW3_RVA2VA(PIMAGE_NT_HEADERS, DllBase, DosHeader->e_lfanew);
        PIMAGE_DATA_DIRECTORY DataDirectory = (PIMAGE_DATA_DIRECTORY)NtHeaders->OptionalHeader.DataDirectory;
        DWORD VirtualAddress = DataDirectory[IMAGE_DIRECTORY_ENTRY_EXPORT].VirtualAddress;
        if (VirtualAddress == 0) continue;

        ExportDirectory = (PIMAGE_EXPORT_DIRECTORY)SW3_RVA2VA(ULONG_PTR, DllBase, VirtualAddress);

        // If this is NTDLL.dll, exit loop.
        PCHAR DllName = SW3_RVA2VA(PCHAR, DllBase, ExportDirectory->Name);

        if ((*(ULONG*)DllName | 0x20202020) != 0x6c64746e) continue;
        if ((*(ULONG*)(DllName + 4) | 0x20202020) == 0x6c642e6c) break;
    }

    if (!ExportDirectory) return FALSE;

    DWORD NumberOfNames = ExportDirectory->NumberOfNames;
    PDWORD Functions = SW3_RVA2VA(PDWORD, DllBase, ExportDirectory->AddressOfFunctions);
    PDWORD Names = SW3_RVA2VA(PDWORD, DllBase, ExportDirectory->AddressOfNames);
    PWORD Ordinals = SW3_RVA2VA(PWORD, DllBase, ExportDirectory->AddressOfNameOrdinals);

    // Populate SW3_SyscallList with unsorted Zw* entries.
    DWORD i = 0;
    PSW3_SYSCALL_ENTRY Entries = SW3_SyscallList.Entries;
    do
    {
        PCHAR FunctionName = SW3_RVA2VA(PCHAR, DllBase, Names[NumberOfNames - 1]);

        #ifdef _M_IX86
        // Is this a Ki* function
        //    check if KiFastSystemCall function
        //       look for the 'sysent; ret' op codes and set fastCall if found.
        //
        if (*(USHORT*)FunctionName == 0x694b)
        {
           if (0xFFCE1055 == SW3_HashSyscall(FunctionName))
           {
              PVOID lFastCall = SW3_RVA2VA(PVOID, DllBase, Functions[Ordinals[NumberOfNames - 1]]);

              // Search the first 32 bytes for the op codes
              for (int x = 0; x < 32; ++x)
              {
                 if (!memcmp((PVOID)syscall_code, (char *) lFastCall + x, sizeof(syscall_code)))
                 {
                    fastCall = (char *) lFastCall + x;
                    break;
                 }
              }
           }
        }
        #endif

        // Is this a system call?
        if (*(USHORT*)FunctionName == 0x775a)
        {
            Entries[i].Hash = SW3_HashSyscall(FunctionName);
            Entries[i].Address = Functions[Ordinals[NumberOfNames - 1]];
            Entries[i].SyscallAddress = NULL; // Resolve address later in the function

            i++;
            if (i == SW3_MAX_ENTRIES) break;
        }
    } while (--NumberOfNames);

    // Save total number of system calls found.
    SW3_SyscallList.Count = i;

    // Sort the list by address in ascending order.
    for (DWORD i = 0; i < SW3_SyscallList.Count - 1; i++)
    {
        for (DWORD j = 0; j < SW3_SyscallList.Count - i - 1; j++)
        {
            if (Entries[j].Address > Entries[j + 1].Address)
            {
                // Swap entries.
                SW3_SYSCALL_ENTRY TempEntry;

                TempEntry.Hash = Entries[j].Hash;
                TempEntry.Address = Entries[j].Address;
                TempEntry.SyscallAddress = Entries[j].SyscallAddress;

                Entries[j].Hash = Entries[j + 1].Hash;
                Entries[j].Address = Entries[j + 1].Address;
                Entries[j].SyscallAddress = Entries[j + 1].SyscallAddress;

                Entries[j + 1].Hash = TempEntry.Hash;
                Entries[j + 1].Address = TempEntry.Address;
                Entries[j + 1].SyscallAddress = TempEntry.SyscallAddress;
            }
        }
    }

    #ifdef JUMPER
    // Determine distance information for this version of the OS.
    ULONG distance_to_next_func = Entries[1].Address - Entries[0].Address;
    ULONG distance_to_syscall   = 0;
    PVOID lfunc                 = SW3_RVA2VA(PVOID, DllBase, Entries[0].Address);

    // Search the size of the function for the op codes
    for (int x = 0; x < distance_to_next_func; ++x)
    {
        if (!memcmp((PVOID)syscall_code, (char *) lfunc + x, sizeof(syscall_code)))
        {
            distance_to_syscall = x;
            break;
        }
    }

    // Resolve the SyscallAddress now that the distance information is known.
    #ifdef _M_IX86
    if (distance_to_syscall > 0 || local_is_wow64())
    #else
    if (distance_to_syscall > 0)
    #endif
    {
        for (DWORD i = 0; i < SW3_SyscallList.Count; i++)
        {
            Entries[i].SyscallAddress = SC_Address(SW3_RVA2VA(PVOID, DllBase, Entries[i].Address), distance_to_syscall, distance_to_next_func);
        }
    }
    #endif

    return TRUE;
}

EXTERN_C DWORD SW3_GetSyscallNumber(DWORD FunctionHash)
{
    // Ensure SW3_SyscallList is populated.
    if (!SW3_PopulateSyscallList()) return -1;

    for (DWORD i = 0; i < SW3_SyscallList.Count; i++)
    {
        if (FunctionHash == SW3_SyscallList.Entries[i].Hash)
        {
            return i;
        }
    }

    return -1;
}

EXTERN_C PVOID SW3_GetSyscallAddress(DWORD FunctionHash)
{
    // Ensure SW3_SyscallList is populated.
    if (!SW3_PopulateSyscallList()) return NULL;

    for (DWORD i = 0; i < SW3_SyscallList.Count; i++)
    {
        if (FunctionHash == SW3_SyscallList.Entries[i].Hash)
        {
            if (SW3_SyscallList.Entries[i].SyscallAddress)
                return SW3_SyscallList.Entries[i].SyscallAddress;

            return fastCall;
        }
    }

    return NULL;
}

EXTERN_C PVOID SW3_GetRandomSyscallAddress(DWORD FunctionHash)
{
    // Ensure SW3_SyscallList is populated.
    if (!SW3_PopulateSyscallList()) return NULL;

    DWORD index = ((DWORD) rand()) % SW3_SyscallList.Count;

    while (FunctionHash == SW3_SyscallList.Entries[index].Hash){
        // Spoofing the syscall return address
        index = ((DWORD) rand()) % SW3_SyscallList.Count;
    }

    if (SW3_SyscallList.Entries[index].SyscallAddress)
        return SW3_SyscallList.Entries[index].SyscallAddress;

    return fastCall;
}
#if defined(__GNUC__)

__declspec(naked) NTSTATUS NtCreateThreadEx(
	OUT PHANDLE ThreadHandle,
	IN ACCESS_MASK DesiredAccess,
	IN POBJECT_ATTRIBUTES ObjectAttributes OPTIONAL,
	IN HANDLE ProcessHandle,
	IN PVOID StartRoutine,
	IN PVOID Argument OPTIONAL,
	IN ULONG CreateFlags,
	IN SIZE_T ZeroBits,
	IN SIZE_T StackSize,
	IN SIZE_T MaximumStackSize,
	IN PPS_ATTRIBUTE_LIST AttributeList OPTIONAL)
{
	asm(
#if defined(_WIN64)
		"mov [rsp +8], rcx \n"
		"mov [rsp+16], rdx \n"
		"mov [rsp+24], r8 \n"
		"mov [rsp+32], r9 \n"
		"sub rsp, 0x28 \n"
		"mov ecx, 0x88BBDE66 \n"
		"call SW3_GetSyscallNumber \n"
		"add rsp, 0x28 \n"
		"mov rcx, [rsp+8] \n"
		"mov rdx, [rsp+16] \n"
		"mov r8, [rsp+24] \n"
		"mov r9, [rsp+32] \n"
		"mov r10, rcx \n"
		"syscall \n"
		"ret \n"
#else
		"push ebx \n"
		"push ebp \n"
		"mov ebp, esp \n"
		"push 0x88BBDE66 \n"
		"call _SW3_GetSyscallNumber \n"
		"lea esp, [esp+4] \n"
		"mov ecx, 0xb \n"
	"push_argument_1: \n"
		"dec ecx \n"
		"push [ebp + 12 + ecx * 4] \n"
		"jnz push_argument_1 \n"
		"mov ecx, eax \n"
		"call _local_is_wow64 \n"
		"test eax, eax \n"
		"je is_native_1 \n"
		"call _internal_cleancall_wow64_gate \n"
		"lea ebx, [ret_address_epilog_1] \n"
		"push ebx \n"
		"push ebx \n"
		"xchg eax, ecx \n"
		"lea edx, [esp+8] \n"
		"mov ebx, ecx \n"
		"xor ecx, ecx \n"
		"jmp ebx \n"
		"jmp finish_1 \n"
	"is_native_1: \n"
		"mov eax, ecx \n"
		"lea ebx, [ret_address_epilog_1] \n"
		"push ebx \n"
		"call do_sysenter_interrupt_1 \n"
	"finish_1: \n"
		"lea esp, [esp+4] \n"
	"ret_address_epilog_1: \n"
		"mov esp, ebp \n"
		"pop ebp \n"
		"pop ebx \n"
		"ret \n"
	"do_sysenter_interrupt_1: \n"
		"mov edx, esp \n"
		"sysenter \n"
		"ret \n"
#endif
	);
}

__declspec(naked) NTSTATUS NtAllocateVirtualMemory(
	IN HANDLE ProcessHandle,
	IN OUT PVOID * BaseAddress,
	IN ULONG ZeroBits,
	IN OUT PSIZE_T RegionSize,
	IN ULONG AllocationType,
	IN ULONG Protect)
{
	asm(
#if defined(_WIN64)
		"mov [rsp +8], rcx \n"
		"mov [rsp+16], rdx \n"
		"mov [rsp+24], r8 \n"
		"mov [rsp+32], r9 \n"
		"sub rsp, 0x28 \n"
		"mov ecx, 0x0B932333 \n"
		"call SW3_GetSyscallNumber \n"
		"add rsp, 0x28 \n"
		"mov rcx, [rsp+8] \n"
		"mov rdx, [rsp+16] \n"
		"mov r8, [rsp+24] \n"
		"mov r9, [rsp+32] \n"
		"mov r10, rcx \n"
		"syscall \n"
		"ret \n"
#else
		"push ebx \n"
		"push ebp \n"
		"mov ebp, esp \n"
		"push 0x0B932333 \n"
		"call _SW3_GetSyscallNumber \n"
		"lea esp, [esp+4] \n"
		"mov ecx, 0x6 \n"
	"push_argument_2: \n"
		"dec ecx \n"
		"push [ebp + 12 + ecx * 4] \n"
		"jnz push_argument_2 \n"
		"mov ecx, eax \n"
		"call _local_is_wow64 \n"
		"test eax, eax \n"
		"je is_native_2 \n"
		"call _internal_cleancall_wow64_gate \n"
		"lea ebx, [ret_address_epilog_2] \n"
		"push ebx \n"
		"push ebx \n"
		"xchg eax, ecx \n"
		"lea edx, [esp+8] \n"
		"mov ebx, ecx \n"
		"xor ecx, ecx \n"
		"jmp ebx \n"
		"jmp finish_2 \n"
	"is_native_2: \n"
		"mov eax, ecx \n"
		"lea ebx, [ret_address_epilog_2] \n"
		"push ebx \n"
		"call do_sysenter_interrupt_2 \n"
	"finish_2: \n"
		"lea esp, [esp+4] \n"
	"ret_address_epilog_2: \n"
		"mov esp, ebp \n"
		"pop ebp \n"
		"pop ebx \n"
		"ret \n"
	"do_sysenter_interrupt_2: \n"
		"mov edx, esp \n"
		"sysenter \n"
		"ret \n"
#endif
	);
}

__declspec(naked) NTSTATUS NtProtectVirtualMemory(
	IN HANDLE ProcessHandle,
	IN OUT PVOID * BaseAddress,
	IN OUT PSIZE_T RegionSize,
	IN ULONG NewProtect,
	OUT PULONG OldProtect)
{
	asm(
#if defined(_WIN64)
		"mov [rsp +8], rcx \n"
		"mov [rsp+16], rdx \n"
		"mov [rsp+24], r8 \n"
		"mov [rsp+32], r9 \n"
		"sub rsp, 0x28 \n"
		"mov ecx, 0x799A4933 \n"
		"call SW3_GetSyscallNumber \n"
		"add rsp, 0x28 \n"
		"mov rcx, [rsp+8] \n"
		"mov rdx, [rsp+16] \n"
		"mov r8, [rsp+24] \n"
		"mov r9, [rsp+32] \n"
		"mov r10, rcx \n"
		"syscall \n"
		"ret \n"
#else
		"push ebx \n"
		"push ebp \n"
		"mov ebp, esp \n"
		"push 0x799A4933 \n"
		"call _SW3_GetSyscallNumber \n"
		"lea esp, [esp+4] \n"
		"mov ecx, 0x5 \n"
	"push_argument_3: \n"
		"dec ecx \n"
		"push [ebp + 12 + ecx * 4] \n"
		"jnz push_argument_3 \n"
		"mov ecx, eax \n"
		"call _local_is_wow64 \n"
		"test eax, eax \n"
		"je is_native_3 \n"
		"call _internal_cleancall_wow64_gate \n"
		"lea ebx, [ret_address_epilog_3] \n"
		"push ebx \n"
		"push ebx \n"
		"xchg eax, ecx \n"
		"lea edx, [esp+8] \n"
		"mov ebx, ecx \n"
		"xor ecx, ecx \n"
		"jmp ebx \n"
		"jmp finish_3 \n"
	"is_native_3: \n"
		"mov eax, ecx \n"
		"lea ebx, [ret_address_epilog_3] \n"
		"push ebx \n"
		"call do_sysenter_interrupt_3 \n"
	"finish_3: \n"
		"lea esp, [esp+4] \n"
	"ret_address_epilog_3: \n"
		"mov esp, ebp \n"
		"pop ebp \n"
		"pop ebx \n"
		"ret \n"
	"do_sysenter_interrupt_3: \n"
		"mov edx, esp \n"
		"sysenter \n"
		"ret \n"
#endif
	);
}

__declspec(naked) NTSTATUS NtCreateNamedPipeFile(
	OUT PHANDLE FileHandle,
	IN ACCESS_MASK DesiredAccess,
	IN POBJECT_ATTRIBUTES ObjectAttributes,
	OUT PIO_STATUS_BLOCK IoStatusBlock,
	IN ULONG ShareAccess,
	IN ULONG CreateDisposition,
	IN ULONG CreateOptions,
	IN BOOLEAN NamedPipeType,
	IN BOOLEAN ReadMode,
	IN BOOLEAN CompletionMode,
	IN ULONG MaximumInstances,
	IN ULONG InboundQuota,
	IN ULONG OutboundQuota,
	IN PLARGE_INTEGER DefaultTimeout OPTIONAL)
{
	asm(
#if defined(_WIN64)
		"mov [rsp +8], rcx \n"
		"mov [rsp+16], rdx \n"
		"mov [rsp+24], r8 \n"
		"mov [rsp+32], r9 \n"
		"sub rsp, 0x28 \n"
		"mov ecx, 0x841CAB54 \n"
		"call SW3_GetSyscallNumber \n"
		"add rsp, 0x28 \n"
		"mov rcx, [rsp+8] \n"
		"mov rdx, [rsp+16] \n"
		"mov r8, [rsp+24] \n"
		"mov r9, [rsp+32] \n"
		"mov r10, rcx \n"
		"syscall \n"
		"ret \n"
#else
		"push ebx \n"
		"push ebp \n"
		"mov ebp, esp \n"
		"push 0x841CAB54 \n"
		"call _SW3_GetSyscallNumber \n"
		"lea esp, [esp+4] \n"
		"mov ecx, 0xe \n"
	"push_argument_4: \n"
		"dec ecx \n"
		"push [ebp + 12 + ecx * 4] \n"
		"jnz push_argument_4 \n"
		"mov ecx, eax \n"
		"call _local_is_wow64 \n"
		"test eax, eax \n"
		"je is_native_4 \n"
		"call _internal_cleancall_wow64_gate \n"
		"lea ebx, [ret_address_epilog_4] \n"
		"push ebx \n"
		"push ebx \n"
		"xchg eax, ecx \n"
		"lea edx, [esp+8] \n"
		"mov ebx, ecx \n"
		"xor ecx, ecx \n"
		"jmp ebx \n"
		"jmp finish_4 \n"
	"is_native_4: \n"
		"mov eax, ecx \n"
		"lea ebx, [ret_address_epilog_4] \n"
		"push ebx \n"
		"call do_sysenter_interrupt_4 \n"
	"finish_4: \n"
		"lea esp, [esp+4] \n"
	"ret_address_epilog_4: \n"
		"mov esp, ebp \n"
		"pop ebp \n"
		"pop ebx \n"
		"ret \n"
	"do_sysenter_interrupt_4: \n"
		"mov edx, esp \n"
		"sysenter \n"
		"ret \n"
#endif
	);
}

__declspec(naked) NTSTATUS NtWriteFile(
	IN HANDLE FileHandle,
	IN HANDLE Event OPTIONAL,
	IN PIO_APC_ROUTINE ApcRoutine OPTIONAL,
	IN PVOID ApcContext OPTIONAL,
	OUT PIO_STATUS_BLOCK IoStatusBlock,
	IN PVOID Buffer,
	IN ULONG Length,
	IN PLARGE_INTEGER ByteOffset OPTIONAL,
	IN PULONG Key OPTIONAL)
{
	asm(
#if defined(_WIN64)
		"mov [rsp +8], rcx \n"
		"mov [rsp+16], rdx \n"
		"mov [rsp+24], r8 \n"
		"mov [rsp+32], r9 \n"
		"sub rsp, 0x28 \n"
		"mov ecx, 0xED5CE7FB \n"
		"call SW3_GetSyscallNumber \n"
		"add rsp, 0x28 \n"
		"mov rcx, [rsp+8] \n"
		"mov rdx, [rsp+16] \n"
		"mov r8, [rsp+24] \n"
		"mov r9, [rsp+32] \n"
		"mov r10, rcx \n"
		"syscall \n"
		"ret \n"
#else
		"push ebx \n"
		"push ebp \n"
		"mov ebp, esp \n"
		"push 0xED5CE7FB \n"
		"call _SW3_GetSyscallNumber \n"
		"lea esp, [esp+4] \n"
		"mov ecx, 0x9 \n"
	"push_argument_5: \n"
		"dec ecx \n"
		"push [ebp + 12 + ecx * 4] \n"
		"jnz push_argument_5 \n"
		"mov ecx, eax \n"
		"call _local_is_wow64 \n"
		"test eax, eax \n"
		"je is_native_5 \n"
		"call _internal_cleancall_wow64_gate \n"
		"lea ebx, [ret_address_epilog_5] \n"
		"push ebx \n"
		"push ebx \n"
		"xchg eax, ecx \n"
		"lea edx, [esp+8] \n"
		"mov ebx, ecx \n"
		"xor ecx, ecx \n"
		"jmp ebx \n"
		"jmp finish_5 \n"
	"is_native_5: \n"
		"mov eax, ecx \n"
		"lea ebx, [ret_address_epilog_5] \n"
		"push ebx \n"
		"call do_sysenter_interrupt_5 \n"
	"finish_5: \n"
		"lea esp, [esp+4] \n"
	"ret_address_epilog_5: \n"
		"mov esp, ebp \n"
		"pop ebp \n"
		"pop ebx \n"
		"ret \n"
	"do_sysenter_interrupt_5: \n"
		"mov edx, esp \n"
		"sysenter \n"
		"ret \n"
#endif
	);
}

__declspec(naked) NTSTATUS NtReadFile(
	IN HANDLE FileHandle,
	IN HANDLE Event OPTIONAL,
	IN PIO_APC_ROUTINE ApcRoutine OPTIONAL,
	OUT PVOID ApcContext OPTIONAL,
	OUT PIO_STATUS_BLOCK IoStatusBlock,
	IN PVOID Buffer,
	IN ULONG Length,
	IN PLARGE_INTEGER ByteOffset OPTIONAL,
	IN PULONG Key OPTIONAL)
{
	asm(
#if defined(_WIN64)
		"mov [rsp +8], rcx \n"
		"mov [rsp+16], rdx \n"
		"mov [rsp+24], r8 \n"
		"mov [rsp+32], r9 \n"
		"sub rsp, 0x28 \n"
		"mov ecx, 0xCC92C231 \n"
		"call SW3_GetSyscallNumber \n"
		"add rsp, 0x28 \n"
		"mov rcx, [rsp+8] \n"
		"mov rdx, [rsp+16] \n"
		"mov r8, [rsp+24] \n"
		"mov r9, [rsp+32] \n"
		"mov r10, rcx \n"
		"syscall \n"
		"ret \n"
#else
		"push ebx \n"
		"push ebp \n"
		"mov ebp, esp \n"
		"push 0xCC92C231 \n"
		"call _SW3_GetSyscallNumber \n"
		"lea esp, [esp+4] \n"
		"mov ecx, 0x9 \n"
	"push_argument_6: \n"
		"dec ecx \n"
		"push [ebp + 12 + ecx * 4] \n"
		"jnz push_argument_6 \n"
		"mov ecx, eax \n"
		"call _local_is_wow64 \n"
		"test eax, eax \n"
		"je is_native_6 \n"
		"call _internal_cleancall_wow64_gate \n"
		"lea ebx, [ret_address_epilog_6] \n"
		"push ebx \n"
		"push ebx \n"
		"xchg eax, ecx \n"
		"lea edx, [esp+8] \n"
		"mov ebx, ecx \n"
		"xor ecx, ecx \n"
		"jmp ebx \n"
		"jmp finish_6 \n"
	"is_native_6: \n"
		"mov eax, ecx \n"
		"lea ebx, [ret_address_epilog_6] \n"
		"push ebx \n"
		"call do_sysenter_interrupt_6 \n"
	"finish_6: \n"
		"lea esp, [esp+4] \n"
	"ret_address_epilog_6: \n"
		"mov esp, ebp \n"
		"pop ebp \n"
		"pop ebx \n"
		"ret \n"
	"do_sysenter_interrupt_6: \n"
		"mov edx, esp \n"
		"sysenter \n"
		"ret \n"
#endif
	);
}

__declspec(naked) NTSTATUS NtClose(
	IN HANDLE Handle)
{
	asm(
#if defined(_WIN64)
		"mov [rsp +8], rcx \n"
		"mov [rsp+16], rdx \n"
		"mov [rsp+24], r8 \n"
		"mov [rsp+32], r9 \n"
		"sub rsp, 0x28 \n"
		"mov ecx, 0x0497F50B \n"
		"call SW3_GetSyscallNumber \n"
		"add rsp, 0x28 \n"
		"mov rcx, [rsp+8] \n"
		"mov rdx, [rsp+16] \n"
		"mov r8, [rsp+24] \n"
		"mov r9, [rsp+32] \n"
		"mov r10, rcx \n"
		"syscall \n"
		"ret \n"
#else
		"push ebx \n"
		"push ebp \n"
		"mov ebp, esp \n"
		"push 0x0497F50B \n"
		"call _SW3_GetSyscallNumber \n"
		"lea esp, [esp+4] \n"
		"mov ecx, 0x1 \n"
	"push_argument_7: \n"
		"dec ecx \n"
		"push [ebp + 12 + ecx * 4] \n"
		"jnz push_argument_7 \n"
		"mov ecx, eax \n"
		"call _local_is_wow64 \n"
		"test eax, eax \n"
		"je is_native_7 \n"
		"call _internal_cleancall_wow64_gate \n"
		"lea ebx, [ret_address_epilog_7] \n"
		"push ebx \n"
		"push ebx \n"
		"xchg eax, ecx \n"
		"lea edx, [esp+8] \n"
		"mov ebx, ecx \n"
		"xor ecx, ecx \n"
		"jmp ebx \n"
		"jmp finish_7 \n"
	"is_native_7: \n"
		"mov eax, ecx \n"
		"lea ebx, [ret_address_epilog_7] \n"
		"push ebx \n"
		"call do_sysenter_interrupt_7 \n"
	"finish_7: \n"
		"lea esp, [esp+4] \n"
	"ret_address_epilog_7: \n"
		"mov esp, ebp \n"
		"pop ebp \n"
		"pop ebx \n"
		"ret \n"
	"do_sysenter_interrupt_7: \n"
		"mov edx, esp \n"
		"sysenter \n"
		"ret \n"
#endif
	);
}

__declspec(naked) NTSTATUS NtCreateFile(
	OUT PHANDLE FileHandle,
	IN ACCESS_MASK DesiredAccess,
	IN POBJECT_ATTRIBUTES ObjectAttributes,
	OUT PIO_STATUS_BLOCK IoStatusBlock,
	IN PLARGE_INTEGER AllocationSize OPTIONAL,
	IN ULONG FileAttributes,
	IN ULONG ShareAccess,
	IN ULONG CreateDisposition,
	IN ULONG CreateOptions,
	IN PVOID EaBuffer OPTIONAL,
	IN ULONG EaLength)
{
	asm(
#if defined(_WIN64)
		"mov [rsp +8], rcx \n"
		"mov [rsp+16], rdx \n"
		"mov [rsp+24], r8 \n"
		"mov [rsp+32], r9 \n"
		"sub rsp, 0x28 \n"
		"mov ecx, 0xEB7BB84D \n"
		"call SW3_GetSyscallNumber \n"
		"add rsp, 0x28 \n"
		"mov rcx, [rsp+8] \n"
		"mov rdx, [rsp+16] \n"
		"mov r8, [rsp+24] \n"
		"mov r9, [rsp+32] \n"
		"mov r10, rcx \n"
		"syscall \n"
		"ret \n"
#else
		"push ebx \n"
		"push ebp \n"
		"mov ebp, esp \n"
		"push 0xEB7BB84D \n"
		"call _SW3_GetSyscallNumber \n"
		"lea esp, [esp+4] \n"
		"mov ecx, 0xb \n"
	"push_argument_8: \n"
		"dec ecx \n"
		"push [ebp + 12 + ecx * 4] \n"
		"jnz push_argument_8 \n"
		"mov ecx, eax \n"
		"call _local_is_wow64 \n"
		"test eax, eax \n"
		"je is_native_8 \n"
		"call _internal_cleancall_wow64_gate \n"
		"lea ebx, [ret_address_epilog_8] \n"
		"push ebx \n"
		"push ebx \n"
		"xchg eax, ecx \n"
		"lea edx, [esp+8] \n"
		"mov ebx, ecx \n"
		"xor ecx, ecx \n"
		"jmp ebx \n"
		"jmp finish_8 \n"
	"is_native_8: \n"
		"mov eax, ecx \n"
		"lea ebx, [ret_address_epilog_8] \n"
		"push ebx \n"
		"call do_sysenter_interrupt_8 \n"
	"finish_8: \n"
		"lea esp, [esp+4] \n"
	"ret_address_epilog_8: \n"
		"mov esp, ebp \n"
		"pop ebp \n"
		"pop ebx \n"
		"ret \n"
	"do_sysenter_interrupt_8: \n"
		"mov edx, esp \n"
		"sysenter \n"
		"ret \n"
#endif
	);
}

__declspec(naked) NTSTATUS NtCreateMailslotFile(
	OUT PHANDLE FileHandle,
	IN ACCESS_MASK DesiredAccess,
	IN POBJECT_ATTRIBUTES ObjectAttributes,
	OUT PIO_STATUS_BLOCK IoStatusBlock,
	IN ULONG CreateOptions,
	IN ULONG MailslotQuota,
	IN ULONG MaximumMessageSize,
	IN PLARGE_INTEGER ReadTimeout)
{
	asm(
#if defined(_WIN64)
		"mov [rsp +8], rcx \n"
		"mov [rsp+16], rdx \n"
		"mov [rsp+24], r8 \n"
		"mov [rsp+32], r9 \n"
		"sub rsp, 0x28 \n"
		"mov ecx, 0xFE69AED2 \n"
		"call SW3_GetSyscallNumber \n"
		"add rsp, 0x28 \n"
		"mov rcx, [rsp+8] \n"
		"mov rdx, [rsp+16] \n"
		"mov r8, [rsp+24] \n"
		"mov r9, [rsp+32] \n"
		"mov r10, rcx \n"
		"syscall \n"
		"ret \n"
#else
		"push ebx \n"
		"push ebp \n"
		"mov ebp, esp \n"
		"push 0xFE69AED2 \n"
		"call _SW3_GetSyscallNumber \n"
		"lea esp, [esp+4] \n"
		"mov ecx, 0x8 \n"
	"push_argument_9: \n"
		"dec ecx \n"
		"push [ebp + 12 + ecx * 4] \n"
		"jnz push_argument_9 \n"
		"mov ecx, eax \n"
		"call _local_is_wow64 \n"
		"test eax, eax \n"
		"je is_native_9 \n"
		"call _internal_cleancall_wow64_gate \n"
		"lea ebx, [ret_address_epilog_9] \n"
		"push ebx \n"
		"push ebx \n"
		"xchg eax, ecx \n"
		"lea edx, [esp+8] \n"
		"mov ebx, ecx \n"
		"xor ecx, ecx \n"
		"jmp ebx \n"
		"jmp finish_9 \n"
	"is_native_9: \n"
		"mov eax, ecx \n"
		"lea ebx, [ret_address_epilog_9] \n"
		"push ebx \n"
		"call do_sysenter_interrupt_9 \n"
	"finish_9: \n"
		"lea esp, [esp+4] \n"
	"ret_address_epilog_9: \n"
		"mov esp, ebp \n"
		"pop ebp \n"
		"pop ebx \n"
		"ret \n"
	"do_sysenter_interrupt_9: \n"
		"mov edx, esp \n"
		"sysenter \n"
		"ret \n"
#endif
	);
}

__declspec(naked) NTSTATUS NtWriteVirtualMemory(
	IN HANDLE ProcessHandle,
	IN PVOID BaseAddress,
	IN PVOID Buffer,
	IN SIZE_T NumberOfBytesToWrite,
	OUT PSIZE_T NumberOfBytesWritten OPTIONAL)
{
	asm(
#if defined(_WIN64)
		"mov [rsp +8], rcx \n"
		"mov [rsp+16], rdx \n"
		"mov [rsp+24], r8 \n"
		"mov [rsp+32], r9 \n"
		"sub rsp, 0x28 \n"
		"mov ecx, 0x5D954B1B \n"
		"call SW3_GetSyscallNumber \n"
		"add rsp, 0x28 \n"
		"mov rcx, [rsp+8] \n"
		"mov rdx, [rsp+16] \n"
		"mov r8, [rsp+24] \n"
		"mov r9, [rsp+32] \n"
		"mov r10, rcx \n"
		"syscall \n"
		"ret \n"
#else
		"push ebx \n"
		"push ebp \n"
		"mov ebp, esp \n"
		"push 0x5D954B1B \n"
		"call _SW3_GetSyscallNumber \n"
		"lea esp, [esp+4] \n"
		"mov ecx, 0x5 \n"
	"push_argument_10: \n"
		"dec ecx \n"
		"push [ebp + 12 + ecx * 4] \n"
		"jnz push_argument_10 \n"
		"mov ecx, eax \n"
		"call _local_is_wow64 \n"
		"test eax, eax \n"
		"je is_native_10 \n"
		"call _internal_cleancall_wow64_gate \n"
		"lea ebx, [ret_address_epilog_10] \n"
		"push ebx \n"
		"push ebx \n"
		"xchg eax, ecx \n"
		"lea edx, [esp+8] \n"
		"mov ebx, ecx \n"
		"xor ecx, ecx \n"
		"jmp ebx \n"
		"jmp finish_10 \n"
	"is_native_10: \n"
		"mov eax, ecx \n"
		"lea ebx, [ret_address_epilog_10] \n"
		"push ebx \n"
		"call do_sysenter_interrupt_10 \n"
	"finish_10: \n"
		"lea esp, [esp+4] \n"
	"ret_address_epilog_10: \n"
		"mov esp, ebp \n"
		"pop ebp \n"
		"pop ebx \n"
		"ret \n"
	"do_sysenter_interrupt_10: \n"
		"mov edx, esp \n"
		"sysenter \n"
		"ret \n"
#endif
	);
}

__declspec(naked) NTSTATUS NtGetContextThread(
	IN HANDLE ThreadHandle,
	IN OUT PCONTEXT ThreadContext)
{
	asm(
#if defined(_WIN64)
		"mov [rsp +8], rcx \n"
		"mov [rsp+16], rdx \n"
		"mov [rsp+24], r8 \n"
		"mov [rsp+32], r9 \n"
		"sub rsp, 0x28 \n"
		"mov ecx, 0xA4821F9A \n"
		"call SW3_GetSyscallNumber \n"
		"add rsp, 0x28 \n"
		"mov rcx, [rsp+8] \n"
		"mov rdx, [rsp+16] \n"
		"mov r8, [rsp+24] \n"
		"mov r9, [rsp+32] \n"
		"mov r10, rcx \n"
		"syscall \n"
		"ret \n"
#else
		"push ebx \n"
		"push ebp \n"
		"mov ebp, esp \n"
		"push 0xA4821F9A \n"
		"call _SW3_GetSyscallNumber \n"
		"lea esp, [esp+4] \n"
		"mov ecx, 0x2 \n"
	"push_argument_11: \n"
		"dec ecx \n"
		"push [ebp + 12 + ecx * 4] \n"
		"jnz push_argument_11 \n"
		"mov ecx, eax \n"
		"call _local_is_wow64 \n"
		"test eax, eax \n"
		"je is_native_11 \n"
		"call _internal_cleancall_wow64_gate \n"
		"lea ebx, [ret_address_epilog_11] \n"
		"push ebx \n"
		"push ebx \n"
		"xchg eax, ecx \n"
		"lea edx, [esp+8] \n"
		"mov ebx, ecx \n"
		"xor ecx, ecx \n"
		"jmp ebx \n"
		"jmp finish_11 \n"
	"is_native_11: \n"
		"mov eax, ecx \n"
		"lea ebx, [ret_address_epilog_11] \n"
		"push ebx \n"
		"call do_sysenter_interrupt_11 \n"
	"finish_11: \n"
		"lea esp, [esp+4] \n"
	"ret_address_epilog_11: \n"
		"mov esp, ebp \n"
		"pop ebp \n"
		"pop ebx \n"
		"ret \n"
	"do_sysenter_interrupt_11: \n"
		"mov edx, esp \n"
		"sysenter \n"
		"ret \n"
#endif
	);
}

__declspec(naked) NTSTATUS NtSetContextThread(
	IN HANDLE ThreadHandle,
	IN PCONTEXT Context)
{
	asm(
#if defined(_WIN64)
		"mov [rsp +8], rcx \n"
		"mov [rsp+16], rdx \n"
		"mov [rsp+24], r8 \n"
		"mov [rsp+32], r9 \n"
		"sub rsp, 0x28 \n"
		"mov ecx, 0x14B3D2E9 \n"
		"call SW3_GetSyscallNumber \n"
		"add rsp, 0x28 \n"
		"mov rcx, [rsp+8] \n"
		"mov rdx, [rsp+16] \n"
		"mov r8, [rsp+24] \n"
		"mov r9, [rsp+32] \n"
		"mov r10, rcx \n"
		"syscall \n"
		"ret \n"
#else
		"push ebx \n"
		"push ebp \n"
		"mov ebp, esp \n"
		"push 0x14B3D2E9 \n"
		"call _SW3_GetSyscallNumber \n"
		"lea esp, [esp+4] \n"
		"mov ecx, 0x2 \n"
	"push_argument_12: \n"
		"dec ecx \n"
		"push [ebp + 12 + ecx * 4] \n"
		"jnz push_argument_12 \n"
		"mov ecx, eax \n"
		"call _local_is_wow64 \n"
		"test eax, eax \n"
		"je is_native_12 \n"
		"call _internal_cleancall_wow64_gate \n"
		"lea ebx, [ret_address_epilog_12] \n"
		"push ebx \n"
		"push ebx \n"
		"xchg eax, ecx \n"
		"lea edx, [esp+8] \n"
		"mov ebx, ecx \n"
		"xor ecx, ecx \n"
		"jmp ebx \n"
		"jmp finish_12 \n"
	"is_native_12: \n"
		"mov eax, ecx \n"
		"lea ebx, [ret_address_epilog_12] \n"
		"push ebx \n"
		"call do_sysenter_interrupt_12 \n"
	"finish_12: \n"
		"lea esp, [esp+4] \n"
	"ret_address_epilog_12: \n"
		"mov esp, ebp \n"
		"pop ebp \n"
		"pop ebx \n"
		"ret \n"
	"do_sysenter_interrupt_12: \n"
		"mov edx, esp \n"
		"sysenter \n"
		"ret \n"
#endif
	);
}

__declspec(naked) NTSTATUS NtResumeThread(
	IN HANDLE ThreadHandle,
	IN OUT PULONG PreviousSuspendCount OPTIONAL)
{
	asm(
#if defined(_WIN64)
		"mov [rsp +8], rcx \n"
		"mov [rsp+16], rdx \n"
		"mov [rsp+24], r8 \n"
		"mov [rsp+32], r9 \n"
		"sub rsp, 0x28 \n"
		"mov ecx, 0x5C871A2D \n"
		"call SW3_GetSyscallNumber \n"
		"add rsp, 0x28 \n"
		"mov rcx, [rsp+8] \n"
		"mov rdx, [rsp+16] \n"
		"mov r8, [rsp+24] \n"
		"mov r9, [rsp+32] \n"
		"mov r10, rcx \n"
		"syscall \n"
		"ret \n"
#else
		"push ebx \n"
		"push ebp \n"
		"mov ebp, esp \n"
		"push 0x5C871A2D \n"
		"call _SW3_GetSyscallNumber \n"
		"lea esp, [esp+4] \n"
		"mov ecx, 0x2 \n"
	"push_argument_13: \n"
		"dec ecx \n"
		"push [ebp + 12 + ecx * 4] \n"
		"jnz push_argument_13 \n"
		"mov ecx, eax \n"
		"call _local_is_wow64 \n"
		"test eax, eax \n"
		"je is_native_13 \n"
		"call _internal_cleancall_wow64_gate \n"
		"lea ebx, [ret_address_epilog_13] \n"
		"push ebx \n"
		"push ebx \n"
		"xchg eax, ecx \n"
		"lea edx, [esp+8] \n"
		"mov ebx, ecx \n"
		"xor ecx, ecx \n"
		"jmp ebx \n"
		"jmp finish_13 \n"
	"is_native_13: \n"
		"mov eax, ecx \n"
		"lea ebx, [ret_address_epilog_13] \n"
		"push ebx \n"
		"call do_sysenter_interrupt_13 \n"
	"finish_13: \n"
		"lea esp, [esp+4] \n"
	"ret_address_epilog_13: \n"
		"mov esp, ebp \n"
		"pop ebp \n"
		"pop ebx \n"
		"ret \n"
	"do_sysenter_interrupt_13: \n"
		"mov edx, esp \n"
		"sysenter \n"
		"ret \n"
#endif
	);
}

__declspec(naked) NTSTATUS NtFsControlFile(
	IN HANDLE FileHandle,
	IN HANDLE Event OPTIONAL,
	IN PIO_APC_ROUTINE ApcRoutine OPTIONAL,
	IN PVOID ApcContext OPTIONAL,
	OUT PIO_STATUS_BLOCK IoStatusBlock,
	IN ULONG FsControlCode,
	IN PVOID InputBuffer OPTIONAL,
	IN ULONG InputBufferLength,
	OUT PVOID OutputBuffer OPTIONAL,
	IN ULONG OutputBufferLength)
{
	asm(
#if defined(_WIN64)
		"mov [rsp +8], rcx \n"
		"mov [rsp+16], rdx \n"
		"mov [rsp+24], r8 \n"
		"mov [rsp+32], r9 \n"
		"sub rsp, 0x28 \n"
		"mov ecx, 0xDE48A54E \n"
		"call SW3_GetSyscallNumber \n"
		"add rsp, 0x28 \n"
		"mov rcx, [rsp+8] \n"
		"mov rdx, [rsp+16] \n"
		"mov r8, [rsp+24] \n"
		"mov r9, [rsp+32] \n"
		"mov r10, rcx \n"
		"syscall \n"
		"ret \n"
#else
		"push ebx \n"
		"push ebp \n"
		"mov ebp, esp \n"
		"push 0xDE48A54E \n"
		"call _SW3_GetSyscallNumber \n"
		"lea esp, [esp+4] \n"
		"mov ecx, 0xa \n"
	"push_argument_14: \n"
		"dec ecx \n"
		"push [ebp + 12 + ecx * 4] \n"
		"jnz push_argument_14 \n"
		"mov ecx, eax \n"
		"call _local_is_wow64 \n"
		"test eax, eax \n"
		"je is_native_14 \n"
		"call _internal_cleancall_wow64_gate \n"
		"lea ebx, [ret_address_epilog_14] \n"
		"push ebx \n"
		"push ebx \n"
		"xchg eax, ecx \n"
		"lea edx, [esp+8] \n"
		"mov ebx, ecx \n"
		"xor ecx, ecx \n"
		"jmp ebx \n"
		"jmp finish_14 \n"
	"is_native_14: \n"
		"mov eax, ecx \n"
		"lea ebx, [ret_address_epilog_14] \n"
		"push ebx \n"
		"call do_sysenter_interrupt_14 \n"
	"finish_14: \n"
		"lea esp, [esp+4] \n"
	"ret_address_epilog_14: \n"
		"mov esp, ebp \n"
		"pop ebp \n"
		"pop ebx \n"
		"ret \n"
	"do_sysenter_interrupt_14: \n"
		"mov edx, esp \n"
		"sysenter \n"
		"ret \n"
#endif
	);
}

__declspec(naked) NTSTATUS NtCreateSection(
	OUT PHANDLE SectionHandle,
	IN ACCESS_MASK DesiredAccess,
	IN POBJECT_ATTRIBUTES ObjectAttributes OPTIONAL,
	IN PLARGE_INTEGER MaximumSize OPTIONAL,
	IN ULONG SectionPageProtection,
	IN ULONG AllocationAttributes,
	IN HANDLE FileHandle OPTIONAL)
{
	asm(
#if defined(_WIN64)
		"mov [rsp +8], rcx \n"
		"mov [rsp+16], rdx \n"
		"mov [rsp+24], r8 \n"
		"mov [rsp+32], r9 \n"
		"sub rsp, 0x28 \n"
		"mov ecx, 0xCF19CBB2 \n"
		"call SW3_GetSyscallNumber \n"
		"add rsp, 0x28 \n"
		"mov rcx, [rsp+8] \n"
		"mov rdx, [rsp+16] \n"
		"mov r8, [rsp+24] \n"
		"mov r9, [rsp+32] \n"
		"mov r10, rcx \n"
		"syscall \n"
		"ret \n"
#else
		"push ebx \n"
		"push ebp \n"
		"mov ebp, esp \n"
		"push 0xCF19CBB2 \n"
		"call _SW3_GetSyscallNumber \n"
		"lea esp, [esp+4] \n"
		"mov ecx, 0x7 \n"
	"push_argument_15: \n"
		"dec ecx \n"
		"push [ebp + 12 + ecx * 4] \n"
		"jnz push_argument_15 \n"
		"mov ecx, eax \n"
		"call _local_is_wow64 \n"
		"test eax, eax \n"
		"je is_native_15 \n"
		"call _internal_cleancall_wow64_gate \n"
		"lea ebx, [ret_address_epilog_15] \n"
		"push ebx \n"
		"push ebx \n"
		"xchg eax, ecx \n"
		"lea edx, [esp+8] \n"
		"mov ebx, ecx \n"
		"xor ecx, ecx \n"
		"jmp ebx \n"
		"jmp finish_15 \n"
	"is_native_15: \n"
		"mov eax, ecx \n"
		"lea ebx, [ret_address_epilog_15] \n"
		"push ebx \n"
		"call do_sysenter_interrupt_15 \n"
	"finish_15: \n"
		"lea esp, [esp+4] \n"
	"ret_address_epilog_15: \n"
		"mov esp, ebp \n"
		"pop ebp \n"
		"pop ebx \n"
		"ret \n"
	"do_sysenter_interrupt_15: \n"
		"mov edx, esp \n"
		"sysenter \n"
		"ret \n"
#endif
	);
}

__declspec(naked) NTSTATUS NtMapViewOfSection(
	IN HANDLE SectionHandle,
	IN HANDLE ProcessHandle,
	IN OUT PVOID BaseAddress,
	IN ULONG ZeroBits,
	IN SIZE_T CommitSize,
	IN OUT PLARGE_INTEGER SectionOffset OPTIONAL,
	IN OUT PSIZE_T ViewSize,
	IN SECTION_INHERIT InheritDisposition,
	IN ULONG AllocationType,
	IN ULONG Win32Protect)
{
	asm(
#if defined(_WIN64)
		"mov [rsp +8], rcx \n"
		"mov [rsp+16], rdx \n"
		"mov [rsp+24], r8 \n"
		"mov [rsp+32], r9 \n"
		"sub rsp, 0x28 \n"
		"mov ecx, 0x2BB0F7DA \n"
		"call SW3_GetSyscallNumber \n"
		"add rsp, 0x28 \n"
		"mov rcx, [rsp+8] \n"
		"mov rdx, [rsp+16] \n"
		"mov r8, [rsp+24] \n"
		"mov r9, [rsp+32] \n"
		"mov r10, rcx \n"
		"syscall \n"
		"ret \n"
#else
		"push ebx \n"
		"push ebp \n"
		"mov ebp, esp \n"
		"push 0x2BB0F7DA \n"
		"call _SW3_GetSyscallNumber \n"
		"lea esp, [esp+4] \n"
		"mov ecx, 0xa \n"
	"push_argument_16: \n"
		"dec ecx \n"
		"push [ebp + 12 + ecx * 4] \n"
		"jnz push_argument_16 \n"
		"mov ecx, eax \n"
		"call _local_is_wow64 \n"
		"test eax, eax \n"
		"je is_native_16 \n"
		"call _internal_cleancall_wow64_gate \n"
		"lea ebx, [ret_address_epilog_16] \n"
		"push ebx \n"
		"push ebx \n"
		"xchg eax, ecx \n"
		"lea edx, [esp+8] \n"
		"mov ebx, ecx \n"
		"xor ecx, ecx \n"
		"jmp ebx \n"
		"jmp finish_16 \n"
	"is_native_16: \n"
		"mov eax, ecx \n"
		"lea ebx, [ret_address_epilog_16] \n"
		"push ebx \n"
		"call do_sysenter_interrupt_16 \n"
	"finish_16: \n"
		"lea esp, [esp+4] \n"
	"ret_address_epilog_16: \n"
		"mov esp, ebp \n"
		"pop ebp \n"
		"pop ebx \n"
		"ret \n"
	"do_sysenter_interrupt_16: \n"
		"mov edx, esp \n"
		"sysenter \n"
		"ret \n"
#endif
	);
}

__declspec(naked) NTSTATUS NtFlushInstructionCache(
	IN HANDLE ProcessHandle,
	IN PVOID BaseAddress OPTIONAL,
	IN ULONG Length)
{
	asm(
#if defined(_WIN64)
		"mov [rsp +8], rcx \n"
		"mov [rsp+16], rdx \n"
		"mov [rsp+24], r8 \n"
		"mov [rsp+32], r9 \n"
		"sub rsp, 0x28 \n"
		"mov ecx, 0x1D2BC10B \n"
		"call SW3_GetSyscallNumber \n"
		"add rsp, 0x28 \n"
		"mov rcx, [rsp+8] \n"
		"mov rdx, [rsp+16] \n"
		"mov r8, [rsp+24] \n"
		"mov r9, [rsp+32] \n"
		"mov r10, rcx \n"
		"syscall \n"
		"ret \n"
#else
		"push ebx \n"
		"push ebp \n"
		"mov ebp, esp \n"
		"push 0x1D2BC10B \n"
		"call _SW3_GetSyscallNumber \n"
		"lea esp, [esp+4] \n"
		"mov ecx, 0x3 \n"
	"push_argument_17: \n"
		"dec ecx \n"
		"push [ebp + 12 + ecx * 4] \n"
		"jnz push_argument_17 \n"
		"mov ecx, eax \n"
		"call _local_is_wow64 \n"
		"test eax, eax \n"
		"je is_native_17 \n"
		"call _internal_cleancall_wow64_gate \n"
		"lea ebx, [ret_address_epilog_17] \n"
		"push ebx \n"
		"push ebx \n"
		"xchg eax, ecx \n"
		"lea edx, [esp+8] \n"
		"mov ebx, ecx \n"
		"xor ecx, ecx \n"
		"jmp ebx \n"
		"jmp finish_17 \n"
	"is_native_17: \n"
		"mov eax, ecx \n"
		"lea ebx, [ret_address_epilog_17] \n"
		"push ebx \n"
		"call do_sysenter_interrupt_17 \n"
	"finish_17: \n"
		"lea esp, [esp+4] \n"
	"ret_address_epilog_17: \n"
		"mov esp, ebp \n"
		"pop ebp \n"
		"pop ebx \n"
		"ret \n"
	"do_sysenter_interrupt_17: \n"
		"mov edx, esp \n"
		"sysenter \n"
		"ret \n"
#endif
	);
}

__declspec(naked) NTSTATUS NtQueryInformationFile(
	IN HANDLE FileHandle,
	OUT PIO_STATUS_BLOCK IoStatusBlock,
	OUT PVOID FileInformation,
	IN ULONG Length,
	IN FILE_INFORMATION_CLASS FileInformationClass)
{
	asm(
#if defined(_WIN64)
		"mov [rsp +8], rcx \n"
		"mov [rsp+16], rdx \n"
		"mov [rsp+24], r8 \n"
		"mov [rsp+32], r9 \n"
		"sub rsp, 0x28 \n"
		"mov ecx, 0x6A3B7BB1 \n"
		"call SW3_GetSyscallNumber \n"
		"add rsp, 0x28 \n"
		"mov rcx, [rsp+8] \n"
		"mov rdx, [rsp+16] \n"
		"mov r8, [rsp+24] \n"
		"mov r9, [rsp+32] \n"
		"mov r10, rcx \n"
		"syscall \n"
		"ret \n"
#else
		"push ebx \n"
		"push ebp \n"
		"mov ebp, esp \n"
		"push 0x6A3B7BB1 \n"
		"call _SW3_GetSyscallNumber \n"
		"lea esp, [esp+4] \n"
		"mov ecx, 0x5 \n"
	"push_argument_18: \n"
		"dec ecx \n"
		"push [ebp + 12 + ecx * 4] \n"
		"jnz push_argument_18 \n"
		"mov ecx, eax \n"
		"call _local_is_wow64 \n"
		"test eax, eax \n"
		"je is_native_18 \n"
		"call _internal_cleancall_wow64_gate \n"
		"lea ebx, [ret_address_epilog_18] \n"
		"push ebx \n"
		"push ebx \n"
		"xchg eax, ecx \n"
		"lea edx, [esp+8] \n"
		"mov ebx, ecx \n"
		"xor ecx, ecx \n"
		"jmp ebx \n"
		"jmp finish_18 \n"
	"is_native_18: \n"
		"mov eax, ecx \n"
		"lea ebx, [ret_address_epilog_18] \n"
		"push ebx \n"
		"call do_sysenter_interrupt_18 \n"
	"finish_18: \n"
		"lea esp, [esp+4] \n"
	"ret_address_epilog_18: \n"
		"mov esp, ebp \n"
		"pop ebp \n"
		"pop ebx \n"
		"ret \n"
	"do_sysenter_interrupt_18: \n"
		"mov edx, esp \n"
		"sysenter \n"
		"ret \n"
#endif
	);
}

#endif

/* enable warning -Warray-bounds */
#pragma GCC diagnostic pop
