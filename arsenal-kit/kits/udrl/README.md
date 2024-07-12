# User Defined Reflective Loader 

This package contains source code for the Cobalt Strike User Defined Reflective
Loader kit. This kit is designed to provide a reference to create your own
reflective loader that will be used by beacon.

The Cobalt Strike reflective loader extracts the executable code from the .text
section from a compiled object file (.o) and can not be larger than 5k
(version 4.4).  Version 4.5 added support for 5k (default) and 100k custom
reflective loader.


## Version 4.5 Update

Increase size

A new hook BEACON_RDLL_SIZE was added to specify either 5k or 100k for your
custom loader. This increase will be reflected in your payloads.

Artifact Kit

The udrl and artifact kit build scripts have been updated to allow
customization of sizes to ensure space is available for your loader.

### UDRL and Malleable C2 Profile Consideration

When using the default reflective loader and generating beacons there are a
few settings that affect beacon’s runtime configuration and the loader, which
are automatically handled when the payload is generated. This ability allows
an operator to change these settings in the profile which will modify how the
payload is generated and how it looks like in memory. 

When using a user defined reflective loader these settings are inserted into
the beacon’s runtime configuration, however because the reflective loader is
defined by the user it is not possible to modify the reflective loader as it
does in the default case. It is on the user to modify their reflective loader
accordingly. 

For example, if you are using the example loader from the URDL kit there is no
code in the loader to do any conditional setup based on information stored in
the header of the image. This could cause runtime issues with beacon that you
are not expecting because of the settings in your Malleable C2 profile.
Writing your own reflective loader from scratch, you will have to deal with
the same type of issues. 

### Settings to be considered

The following are settings to consider when the malleable C2 profile option
stage.sleepmask is set to TRUE

stage.userwx

This setting is a Boolean and informs the default loader to either use RWX
or RX memory. At runtime beacon will either include or not include the .text
section for masking. If the setting is set to TRUE, your user defined loader
needs to set the protection on the .text section as RWX otherwise beacon will
crash. If the setting is set to FALSE, your user defined loader should set the
protection on the .text section as RX as the .text section will not be masked. 

stage.obfuscate 

This setting is a Boolean and informs the default loader to either copy the
header or not copy the header into memory. At runtime beacon will either
include or not include the header section for masking. If the setting is set
to TRUE, your user defined reflective loader should not copy the header into
memory as beacon will not mask the header section. If the setting is set to
FALSE, your user defined loader should copy the header into memory as beacon
will mask the header section. 

Depending on how sophisticated your reflective loader is you will need to make
sure the settings in the Malleable C2 profile will work with how the beacon
payload is loaded into memory. With the `BEACON_RDLL_GENERATE` and 
`BEACON_RDLL_GENERATE_LOCAL` aggressor script hooks you do have the opportunity
to modify your reflective loader by using the aggressor script pe_* functions. 

### Handling a UDRL over 5k

#### A loader over 5k

You can use the BEACON_RDLL_SIZE hook to increase this space to 100k.  The first
parameter to the build script for the URDL kit is the RDLL_SIZE value, which
can be 0, 5 or 100.  The value 5 will use the 5K reflective loader and 100 will
use the 100K reflective loader.  Depending on the Cobalt Strike version the
value 0 has different results.

For 4.8 and earlier the value 0 will use the 5K reflective loader.

For 4.9 and later the value 0 will not include space for a reflective loader in
the beacon dll and is meant for use with prepended loaders (sRDI/Double Pulsar)
such as those found in the udrl-vs kit.

If you are using the udrl kit then a value of 5 or 100 is required as this kit
only supports the stomped "Stephen Fewer" style loader.

#### Artifact Kit Considerations

If you are using an artifact kit based on the kit provided by Cobalt Strike the
default `stagesize` value supports a 5K reflective loader.  There are
parameters to the artifact kit build script which can set the `stagesize` and
`rdll_size` values.  The `stagesize` value is validated to make sure it meets
the minimum required size based on the `rdll_size` value, if it does not the
build will fail with an error. 

#### Arsenal Kit Considerations

If you are using the arsenal kit to build both the artifact and udrl kits you
can set the `rdll_size` and `artifactkit_stage_size` settings in the
`arsenal_kit.config` file.

--- 

## Example

The example code in `kits/udrl/src` directory is based on the classic reflective
loader by Stephen Fewer https://github.com/stephenfewer/ReflectiveDLLInjection
with modifications.  Support for compiling with MinGW (Minimalist GNU for Windows)
is based on this reflective loader project https://github.com/boku7/BokuLoader
by Bobby Cooke and Santiago Pecin.

### Malleable C2 Profile settings

In order for this example to work with Cobalt Strike use the following
malleable C2 profile settings in the stage section. Some settings are not
supported see the list below.  The reason some settings are not supported is
that it requires more sophistication which goes beyond the simpler example. 

```
stage {
   # The following settings are supported for this UDRL example
   set checksum       "<your_value>";
   set cleanup        "<true|false>";
   set compile_time   "<your_value>";
   set image_size_x86 "<your_value>";
   set image_size_x64 "<your_value>";
   set name           "<your_value>";
   set rich_header    "<your_value>";
   set sleep_mask     "<true|false>";
   set string         "<your_value>";
   set stringw        "<your_value>";
   
   transform-x86 {
      prepend "<your value>";
      append  "<your value";
      strrep "<orig_str>" "<new_str>";
   }
   transform-x64 {
      prepend "<your value>";
      append  "<your value";
      strrep "<orig_str>" "<new_str>";
   }
   
   # The following settings are not supported for this UDRL example.
   # This UDRL example is using hard coded decisions for some settings
   # or completly ignores them.
   set allocator    "VirtualAlloc";
   set userwx       "true";
   set stomppe      "false";
   set obfuscate    "false";
   set smartinject  "false";
   set entry_point  "<ignored>";
   set magic_mz_x86 "<ignored>";
   set magic_mz_x64 "<ignored>";
   set magic_pe     "<ignored>";
   set module_x86   "<ignored>";
   set module_x64   "<ignored>";
}
```
 

### Modifications to the loader

Modifications have been made to remove unused code and added new code to
enable this to work with Cobalt Strike

Start with these files from the reflective loader project by Stephen Fewer.
- dll/src/ReflectiveDLLInjection.h
- dll/src/ReflectiveLoader.h
- dll/src/ReflectiveLoader.c

#### ReflectiveDLLInjection.h

The added code ensures the loader follows the execution path we desire.

```
#if defined _M_X64
#define REFLECTIVEDLLINJECTION_VIA_LOADREMOTELIBRARYR
#define REFLECTIVEDLLINJECTION_CUSTOM_DLLMAIN
#define WIN_X64
#elif defined _M_IX86
#define REFLECTIVEDLLINJECTION_VIA_LOADREMOTELIBRARYR
#define REFLECTIVEDLLINJECTION_CUSTOM_DLLMAIN
#define WIN_X86
#endif
```

#### ReflectiveLoader.h

Made the following changes to support building with MinGW
- Changed Winsock2.h to winsock2.h
- Removed the line '#pragma intrinsic( _rotr );'

Removed the following MACROS as compiling on ARM is not supported
- IMAGE_REL_BASED_ARM_MOV32A
- IMAGE_REL_BASED_ARM_MOV32T
- ARM_MOV_MASK
- ARM_MOV_MASK2
- ARM_MOVW
- ARM_MOVT


#### ReflectiveLoader.c

Removed the code that is controlled by the '#ifdef WIN_ARM' MACRO as compiling
on ARM is not supported.

Removed the following lines to support building with MinGW.  The caller
function is replaced by an assembly implementation further down. 

```
//===============================================================================================//
#pragma intrinsic( _ReturnAddress )
// This function can not be inlined by the compiler or we will not get the address we expect. Ideally 
// this code will be compiled with the /O2 and /Ob1 switches. Bonus points if we could take advantage of 
// RIP relative addressing in this instance but I dont believe we can do so with the compiler intrinsics 
// available (and no inline asm available under x64).
__declspec(noinline) ULONG_PTR caller( VOID ) { return (ULONG_PTR)_ReturnAddress(); }
//===============================================================================================//
```

Added the following function prototype definitions after the Note 1 and 2 code
comments.

```
DLLEXPORT ULONG_PTR WINAPI ReflectiveLoader( LPVOID lpParameter );
#ifdef WIN_X64
__declspec(noinline) ULONG_PTR caller( VOID );
#else
__declspec(noinline) ULONG_PTR caller( VOID ) asm ("caller");
#endif
```

Added the following assembly code to the end of the file to define the caller
function.  This replaced the original caller function to support compiling
with MinGW. 

```
__asm__(
#ifdef WIN_X64
"caller: \n"
    "mov rax, [rsp] \n"            // get the return address
    "ret \n"
#else
"caller: \n"
    "mov eax, [esp] \n"            // get the return address
    "ret \n"
#endif
);
```

# Compile

This example is compiled with the provided ./build.sh script which uses the
MinGW compiler.

```
Usage: ./build <rdll_size> <output directory>
```

# Load into Cobalt Strike

Open the Scripts manager, Cobalt Strike -> Scripts

Load `<output directory>\udrl\udrl.cna`

Create a payload to see the results in the Script Console of the loader
successfully being extracted. 


```
[11:38:57] [udrl_kit.cna] UDRL Kit Loaded
[11:38:57] [udrl_kit.cna] UDRL - BEACON_RDLL_SIZE hook
[11:38:57] [udrl_kit.cna] UDRL - Use the 5K Reflective Loader
[11:38:57] [udrl_kit.cna] UDRL - BEACON_RDLL_GENERATE hook
[11:38:57] [udrl_kit.cna] UDRL - resources/beacon.x64.dll
[11:38:57] [udrl_kit.cna] UDRL - /home/arsenal-kit/dist/udrl/ReflectiveLoader.x64.o
[11:38:57] [udrl_kit.cna] UDRL - Length 3266
[11:38:57] [udrl_kit.cna] UDRL - Extracted loader length 2432
[11:38:57] [udrl_kit.cna] UDRL - Rich header will be replaced using the header from the profile.
[11:38:57] [udrl_kit.cna] UDRL - Compile time will be updated with this timestamp: 12 Dec 2017 05:05:32
[11:38:57] [udrl_kit.cna] UDRL - Image size will be updated with this value: 4661248
[11:39:01] [udrl_kit.cna] UDRL - Checksum will be updated with this value: 10010
[11:39:01] [udrl_kit.cna] UDRL - Export name of the dll will be updated to: logger.dll
```

# References

- Classic reflective loader by Stephen Fewer: https://github.com/stephenfewer/ReflectiveDLLInjection
- Reflective loader project by Bobby Cooke and Santiago Pecin: https://github.com/boku7/BokuLoader

# Modifications

You're encouraged to make modifications to this code and use them in your
engagements. Do not redistribute this source code. It is not open source. It
is provided as a benefit to licensed Cobalt Strike users.

# License

This code is subject to the end user license agreement for Cobalt Strike. The
complete license agreement is at:

https://www.cobaltstrike.com/license

This code is subject to the license for the Reflective loader project by
Stephen Fewer. The complete license is at:

https://github.com/stephenfewer/ReflectiveDLLInjection/blob/master/LICENSE.txt
