/******** DO NOT MODIFY FILE START  ********/

/*
 *  beacon_ptr   - pointer to beacon's base address
 *  sections     - list of memory sections beacon wants to mask.
 *                 A section is denoted by a pair indicating the start and end index locations.
 *                 The list is terminated by the start and end locations of 0 and 0.
 *  heap_records - list of memory addresses on the heap beacon wants to mask.
 *                 The list is terminated by the HEAP_RECORD.ptr set to NULL.
 *  mask         - the mask that beacon randomly generated to apply
 */
typedef struct {
   char  * beacon_ptr;
   DWORD * sections;
   HEAP_RECORD * heap_records;
   char    mask[MASK_SIZE];
} SLEEPMASKP;

/******** DO NOT MODIFY FILE END  ********/