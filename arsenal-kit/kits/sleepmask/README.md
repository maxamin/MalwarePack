# SleepMask 

This package contains example sleep_mask source code to support
the ability to mask and unmask Beacon in memory.

# SleepMask version 47

For use with Cobalt Strike version 4.7 and 4.8

The files in the src47 directory contain the function to support the two
sleep mask types for a specific type of Beacon.

Type       |     Supports
-----------|----------------------------------------
default    |     HTTP, HTTPS and DNS Beacons
pivot      |     SMB and TCP Beacons

# SleepMask version 49

For use with Cobalt Strike version 4.9 and later

The files in the src49 directory contain the function to support the two
sleep mask types for a specific type of Beacon.

Type       |     Supports
-----------|----------------------------------------
default    |     HTTP, HTTPS and DNS Beacons
pivot      |     SMB and TCP Beacons

# How it Works

Cobalt Strike when generating a Beacon will call the BEACON_SLEEP_MASK
hook to allow the user to override the default sleep mask code.

The BEACON_SLEEP_MASK hook passes in the type and architecture that is
being generated.  This information is used to open the appropriate 
object file containing your sleep_mask code.  The sleep_mask code will
be extracted and updated in Beacon instead of the default.

# For Cobalt Strike 4.7 and 4.8

With the Cobalt Strike 4.7 release the sleep mask has been redone and
will now execute as a Beacon Object File (BOF) in its own memory region.
The memory region is allocated using Virtual Alloc.

There is a code size requirement that can not exceed N bytes.  If this
occurs the default sleep_mask code will be used.
- 4.7 maximum size is 8192 bytes (8 KB)
- 4.8 maximum size is 16384 bytes (16 KB)

Use of beacon API functions are available, however only before the code
sections are masked and after the code sections are unmasked.

Use of external functions are supported using the dynamic function
resolution syntax as LIBRARY$Function.

Additional files are also included within the src47 directory to support
additional sleep mask capabilities.  These capabilities are disabled
by default and can be enabled by updating the define tags found in
src47/sleepmask.c.

One of the sleep mask capabilities is to provide code to implement the use of a
system call for NtProtectVirtualMemory instead of using VirtualProtect. The
SysWhispers3 public repository was used to generate the code for the system call
with additional modification to work with the sleep mask kit.

The system call method that is referenced as 'jumper' in the SysWhispers3
project will be referred to as 'indirect' in the sleep mask kit to be consistent
with the Cobalt Strike terminology.  This affects the file names, build scripts
and documentation, however does not affect the code in the generated files.

File                           |  Description
-------------------------------|-------------------------------------
beacon.h                       |  Defines the internal beacon APIs that are available
bofdefs.h                      |  Defines the dynamic function resolution prototypes for Windows APIs
cfg.c                          |  Defines Control Flow Guard (CFG) bypass (x64 only)
common_mask.c                  |  Common masking functions
evasive_sleep.c                |  Obfuscate the sleep mask code using CreateTimerQueueTimer (x64 only)
evasive_sleep_stack_spoof.c    |  Same as evasive_sleep.c with stack spoofing (x64 only)
log_sleepmask_parms.c          |  Log information to the beacon console (useful for debugging)
mask_text_section.c            |  Mask the text section of beacon prior to sleeping.
sleepmask.c                    |  Defines the sleep mask functions for the default sleep mask type
sleepmask_pivot.c              |  Defines the sleep mask functions for the pivot sleep mask type
syscall.h                      |  Defines the header file for use with the system calls source
syscalls_embedded.c            |  Implements the system call using the embedded method
syscalls_indirect.c            |  Implements the system call using the indirect method
syscalls_indirect_randomized.c |  Implements the system call using the indirect_randomized method

Warnings:
 - The Control Flow Guard (CFG) bypass is disabled by default with the evasive_sleep capability.
 - The CFG bypass is needed for process injection into processes protected by CFG.
 - The artifactkit_stack_spoof setting of true will not work with the evasive_sleep capability.
 - The ImageSize and Img.Length variables in evasive_sleep files may need to be adjusted based
   on your sleep mask code changes.
 - The provided spoofed stack in evasive_sleep_stack_spoof.c was determined by values from a specific  
   version of Windows 10.  See Evasive Sleep Stack Spoof Information section.

# For Cobalt Strike 4.9 and later

With the Cobalt Strike 4.7 release the sleep mask has been redone and
will now execute as a Beacon Object File (BOF) in its own memory region.
The memory region is allocated using Virtual Alloc.

There is a code size requirement that can not exceed N bytes.  If this
occurs the default sleep_mask code will be used.
- 4.9 maximum size is 16384 bytes (16 KB)

Use of beacon API functions are available, however only before the code
sections are masked and after the code sections are unmasked.

Use of external functions are supported using the dynamic function
resolution syntax as LIBRARY$Function.

Additional files are also included within the src49 directory to support
additional sleep mask capabilities.  These capabilities are disabled
by default and can be enabled by updating the define tags found in
src49/sleepmask.c.

One of the sleep mask capabilities is to provide code to implement the use of a
system call for NtProtectVirtualMemory instead of using VirtualProtect. The
SysWhispers3 public repository was used to generate the code for the system call
with additional modification to work with the sleep mask kit.

The system call method that is referenced as 'jumper' in the SysWhispers3
project will be referred to as 'indirect' in the sleep mask kit to be consistent
with the Cobalt Strike terminology.  This affects the file names, build scripts
and documentation, however does not affect the code in the generated files.

File                           |  Description
-------------------------------|-------------------------------------
beacon.h                       |  Defines the internal beacon APIs that are available
bofdefs.h                      |  Defines the dynamic function resolution prototypes for Windows APIs
cfg.c                          |  Defines Control Flow Guard (CFG) bypass (x64 only)
common_mask.c                  |  Common masking functions
evasive_sleep.c                |  Obfuscate the sleep mask code using CreateTimerQueueTimer (x64 only)
evasive_sleep_stack_spoof.c    |  Same as evasive_sleep.c with stack spoofing (x64 only)
log_sleepmask_parms.c          |  Log information to the beacon console (useful for debugging)
mask_text_section.c            |  Mask the text section of beacon prior to sleeping.
sleepmask.c                    |  Defines the sleep mask functions for the default sleep mask type
sleepmask_pivot.c              |  Defines the sleep mask functions for the pivot sleep mask type
syscall.h                      |  Defines the header file for use with the system calls source
syscalls_embedded.c            |  Implements the system call using the embedded method
syscalls_indirect.c            |  Implements the system call using the indirect method
syscalls_indirect_randomized.c |  Implements the system call using the indirect_randomized method

Warnings:
- The Control Flow Guard (CFG) bypass is disabled by default with the evasive_sleep capability.
- The CFG bypass is needed for process injection into processes protected by CFG.
- The artifactkit_stack_spoof setting of true will not work with the evasive_sleep capability.
- The provided spoofed stack in evasive_sleep_stack_spoof.c was determined by values from a specific  
  version of Windows 10.  See Evasive Sleep Stack Spoof Information section.

# Evasive Sleep Information

The sleep mask kit provides code for additional evasion techniques that you will need to
enable as it is disabled by default and only supported on x64 systems.  There are two
implementations which are found in evasive_sleep.c and evasive_sleep_stack_spoof.c.
Both implementations will change the memory protection of the sleep mask BOF between
RW and RX, obfuscate the memory for the sleep mask BOF, and sleep for the specified time.
The evasive_sleep_stack_spoof.c file adds the ability to spoof the stack, however this
capability needs to target specific Windows versions in order to look valid.

In order to enable these techniques set the EVASIVE_SLEEP define to 1 in the sleepmask.c
file. Then search for EVASIVE_SLEEP define again to uncomment the implementation to
use, the default is evasive_sleep.c.

In the evasive_sleep code (src47) files there is a ImageSize and Img.Length variable that
may need to be modified for your use case as well as these values are hard coded.  This
will require testing on a test vm to determine how many pages are allocated for the
sleep mask BOF in memory, which can be 2 to 4+ pages.  If this is not done then only
the first 2 pages are obfuscated. In the evasive_sleep code (src49) these values are
retrieved from the BeaconInformation API, so modifying them is no longer necessary.

The evasive_sleep_stack_spoof implementation will require additional investigation
and testing for a targeted Windows versions as the spoofed stack may look valid
for one version but not for another version.  The reason is offsets within the
targeted dlls may change between versions more so between major versions.  For example
a stack that is targeted for Windows 10 may not look the same on Windows 11.

In order to make the spoofed stack look valid on a target, you will need to investigate
the valid call stacks on a comparable Windows version to determine the values needed
in the evasive_sleep_stack_spoof code.

To help with determining this information the code for a utility process is being provided.
The source code for the utility is located in the arsenal-kit/utils/getFunctionOffset
directory.  The build instructions can be found in the source file.  This utility needs
to be executed on the comparable Windows version.

How to choose your call stack to spoof.
Steps:
 - Use process hacker or similar utility on a representative
   Windows target system to find a stack you want to spoof.
 - Use the module, function and offset information as input
   to the getFunctionOffset utility located in arsenal-kit/utils.
 - The getFunctionOffset utility outputs information including
   the code to use in the set_callstack() function.

Note: Should look for a stack with NtWaitForSingleObject at the top.
      Then use the information for the remaining stack frames.
Note: The module extension is optional.

Example using the getFunctionOffset helper utility to generate the code:
 - getFunctionOffset.exe ntdll.dll TpReleasePool 0x402
 - getFunctionOffset.exe kernel32.dll BaseThreadInitThunk 0x14
 - getFunctionOffset.exe ntdll RtlUserThreadStart 0x21


# Modifications

You're encouraged to make modifications to the code, compiler versions, or
compiler options if the sleep mask is being used to identify your Beacons.

In the source code there are items that can not be modified because beacon
uses these items to populate the data structures to call the sleep_mask
function.  If these are changed beacon will fail.

Here is the list:
 - Do not change the MASK_SIZE value
 - Do not change the SLEEPMASKP data structure
 - Do not change the ACTION_PIPE_WAIT or ACTION_PIPE_PEEK values (sleepmask_smb.c)
 - Do not change the SLEEPMASK_PIPE_ARGS data structure (sleepmask_smb.c)
 - Do not change the TCP_ACTION_ACCEPT value (sleepmask_tcp.c)
 - Do not change the SLEEPMASK_TCP_ARGS data structure (sleepmask_tcp.c)
 - Do not change the sleep_mask function parameters.
 - Do not change the ACTION_TCP_RECV or ACTION_TCP_ACCEPT values(sleepmask_pivot.c)
 - Do not change the ACTION_PIPE_WAIT or ACTION_PIPE_SEEK values(sleepmask_pivot.c)
 - Do not change the SLEEPMASK_ARGS data structure (sleepmask_pivot.c)
 - Do not change the contents in src47/sleepmask.h
 - Do not change the contents in src49/sleepmask.h


With the sleep_mask version 47 and 49 code you have more flexibility on how you
want to make code modifications.

Note: The source code in the 'src47' and 'src49' directory have 'DO NOT MODIFY FILE START'
      and 'DO NOT MODIFY FILE END' comments indicate the start and end lines for the code
      that should not be modified.

Note: The SLEEPMASK sections pointer references heap memory, so do not
      mask heap memory before dealing with the sections.

Do not redistribute this source code. It is not open source. It is
provided as a benefit to licensed Cobalt Strike users.

# Usage
```
./build.sh <version> <sleep_method> <mask_text> <syscalls> <output directory>

Version          - The sleepmask version. Valid values [47, 49]
                      version 47 supports Cobalt Strike 4.7 and 4.8
                      version 49 supports Cobalt Strike 4.9 and later                    
Sleep Method     - Choose which function to use for sleeping
                      Valid options are: Sleep, WaitForSingleObject
Mask_text        - true or false to mask the text section of beacon"
Syscalls         - set the system calls method"
                      Valid values [none embedded indirect indirect_randomized]"
Output Directory - Destination directory to save the output

```

Example:
```
./build.sh 49 WaitForSingleObject true indirect /tmp/dist
```

You will need the following:

- Minimal GNU for Windows Cross-Compiler - apt-get install mingw-w64

# Load into Cobalt Strike

To use the sleep mask object file, load the sleepmask.cna into Cobalt Strike.

Open the Scripts manager, Cobalt Strike -> Scripts

Load `<output directory>/sleepmask/sleepmask.cna`

# License

This code is subject to the end user license agreement for Cobalt Strike. The
complete license agreement is at:

https://www.cobaltstrike.com/license
