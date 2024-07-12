/*
    Helper functions to log information to the beacon console.
*/

int logOnce = 0;

void log_parms(SLEEPMASKP * parms, char * sleep_mask_ptr) {
   DWORD * index;
   DWORD a, b;
   formatp buffer;

   // Only log this information once
   if (logOnce) {
      return;
   }
   logOnce = 1;

   BeaconFormatAlloc(&buffer, 1024);
   BeaconFormatPrintf(&buffer, "SleepMask information:\n");
   BeaconFormatPrintf(&buffer, "sleepmask: %p\n", sleep_mask_ptr);
   BeaconFormatPrintf(&buffer, "beaconPtr: %p\n", parms->beacon_ptr);

   /* walk our sections and mask them */
   index = parms->sections;
   while (TRUE) {
      a = *index; b = *(index + 1);
      index += 2;
      if (a == 0 && b == 0) {
         break;
      }
      BeaconFormatPrintf(&buffer, "section: sOff %8ld - eOff %8ld : sAddr %p - eAddr %p\n", a, b,
         parms->beacon_ptr + a, parms->beacon_ptr + b);
   }

#if MASK_TEXT_SECTION
   BeaconFormatPrintf(&buffer, "TEXT_SECTION: mask: %d start: %ld end: %ld\n", text_section.mask, text_section.start, text_section.end);
#endif

   BeaconPrintf(CALLBACK_OUTPUT, "%s\n", BeaconFormatToString(&buffer, NULL));
   BeaconFormatFree(&buffer);
}