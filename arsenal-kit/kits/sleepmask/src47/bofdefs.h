#pragma once

// Kernel32 function definitions
NTSYSAPI VOID KERNEL32$RtlCaptureContext(PCONTEXT ContextRecord);
WINBASEAPI BOOL WINAPI KERNEL32$CloseHandle(HANDLE handle);
WINBASEAPI HANDLE WINAPI KERNEL32$CreateEventA(LPSECURITY_ATTRIBUTES lpEventAttributes, BOOL bManualReset, BOOL bInitialState, LPCSTR lpName);
WINBASEAPI HANDLE WINAPI KERNEL32$CreateTimerQueue(VOID);
WINBASEAPI BOOL WINAPI KERNEL32$CreateTimerQueueTimer(PHANDLE phNewTimer, HANDLE TimerQueue, WAITORTIMERCALLBACK Callback, PVOID Parameter, DWORD DueTime, DWORD Period, ULONG Flags);
WINBASEAPI BOOL WINAPI KERNEL32$DeleteTimerQueue(HANDLE TimerQueue);
WINBASEAPI HANDLE WINAPI KERNEL32$GetCurrentProcess(VOID);
WINBASEAPI VOID WINAPI KERNEL32$OutputDebugStringA(LPCSTR lpOutputString);
WINBASEAPI BOOL WINAPI KERNEL32$SetEvent(HANDLE hEvent);
WINBASEAPI BOOL WINAPI KERNEL32$VirtualProtect(LPVOID lpAddress, SIZE_T dwSize, DWORD flNewProtect, PDWORD lpflOldProtect);
WINBASEAPI DWORD WINAPI KERNEL32$WaitForSingleObject(HANDLE hHandle, DWORD dwMilliseconds);
WINBASEAPI DWORD WINAPI KERNEL32$GetLastError(VOID);
WINBASEAPI HMODULE WINAPI KERNEL32$LoadLibraryW(LPCWSTR lpLibFileName);
WINBASEAPI HMODULE WINAPI KERNEL32$GetModuleHandleW(LPCWSTR lpLibFileName);
WINBASEAPI DWORD WINAPI KERNEL32$GetCurrentThreadId(VOID);
WINBASEAPI HANDLE WINAPI KERNEL32$OpenThread(DWORD dwDesiredAccess, BOOL bInheritHandle, DWORD dwThreadId);
WINBASEAPI BOOL WINAPI KERNEL32$SetThreadContext(HANDLE hThread, const CONTEXT *lpContext);
WINBASEAPI BOOL WINAPI KERNEL32$GetThreadContext(HANDLE hThread, LPCONTEXT lpContext);
WINBASEAPI void * WINAPI KERNEL32$HeapAlloc (HANDLE hHeap, DWORD dwFlags, SIZE_T dwBytes);
WINBASEAPI HANDLE WINAPI KERNEL32$GetProcessHeap(VOID);
WINBASEAPI LPWSTR WINAPI KERNEL32$lstrcpyW (LPWSTR lpString1, LPCWSTR lpString2);
#ifdef _WIN64
NTSYSAPI PRUNTIME_FUNCTION WINAPI KERNEL32$RtlLookupFunctionEntry(DWORD64 ControlPc, PDWORD64 ImageBase, PUNWIND_HISTORY_TABLE HistoryTable);
#endif

// NTDLL function definitions
NTSYSAPI NTSTATUS NTAPI NTDLL$NtContinue(PCONTEXT ThreadContext, BOOLEAN RaiseAlert );

// Advapi32 function definitions
typedef struct
{
    DWORD	Length;
    DWORD	MaximumLength;
    PVOID	Buffer;
} USTRING;

WINBASEAPI NTSTATUS WINAPI ADVAPI32$SystemFunction032(USTRING *data, const USTRING *key);


// MSVCRT function definitions
WINBASEAPI int       __cdecl MSVCRT$memcmp(const void *_Buf1,const void *_Buf2,size_t _Size);
WINBASEAPI int       __cdecl MSVCRT$rand();
WINBASEAPI int       __cdecl MSVCRT$sprintf_s(char *_DstBuf, size_t _DstSize, const char *_Format, ...);


#define RtlCaptureContext         KERNEL32$RtlCaptureContext
#define CloseHandle               KERNEL32$CloseHandle
#define CreateEventA              KERNEL32$CreateEventA
#define CreateTimerQueue          KERNEL32$CreateTimerQueue
#define CreateTimerQueueTimer     KERNEL32$CreateTimerQueueTimer
#define DeleteTimerQueue          KERNEL32$DeleteTimerQueue
#define GetCurrentProcess         KERNEL32$GetCurrentProcess
#define OutputDebugStringA        KERNEL32$OutputDebugStringA
#define SetEvent                  KERNEL32$SetEvent
#define VirtualProtect            KERNEL32$VirtualProtect
#define WaitForSingleObject       KERNEL32$WaitForSingleObject
#define GetLastError              KERNEL32$GetLastError
#define LoadLibraryW              KERNEL32$LoadLibraryW
#define GetModuleHandleW          KERNEL32$GetModuleHandleW
#define GetCurrentThreadId        KERNEL32$GetCurrentThreadId
#define OpenThread                KERNEL32$OpenThread
#define SetThreadContext          KERNEL32$SetThreadContext
#define GetThreadContext          KERNEL32$GetThreadContext
#define HeapAlloc                 KERNEL32$HeapAlloc
#define GetProcessHeap            KERNEL32$GetProcessHeap
#define lstrcpyW                  KERNEL32$lstrcpyW
#ifdef _WIN64
#define RtlLookupFunctionEntry    KERNEL32$RtlLookupFunctionEntry
#endif

#define NtContinue                NTDLL$NtContinue

#define SystemFunction032         ADVAPI32$SystemFunction032

#define memcmp                    MSVCRT$memcmp
#define rand                      MSVCRT$rand
#define sprintf_s                 MSVCRT$sprintf_s
