# Obfuscation Loader Example

This is an adapted loader that uses a custom approach to obfuscation and masking. More information on this loader and the different techniques it uses can be found in the following blog post.

https://cobaltstrike.com/blog/revisiting-the-udrl-part-2-obfuscation-masking

**Note:** This loader uses the "Double Pulsar" approach to loading. As a result, it is important to increase the "stage size" when generating artifacts via the Arsenal kit.

## Quick Start Guide

To get started, use the instructions provided below.

### Debug Build

To start Debugging:
* Start the teamserver with the `example.profile` in the project directory.
* Load `./bin/obfuscation-loader/debug-udrl.cna` to Cobalt Strike.
* Export a RAW Beacon payload from the teamserver (our Debug DLL).
* Add the DLL to the project (the below example is for x64):
  * `py.exe .\udrl.py xxd <path\to\beacon_x64.bin> .\library\DebugDLL.x64.h`.
* Start the Visual Studio Debugger (make sure to right-click obfuscation-loader in the 
  Solution Explorer->Set As Startup Project).

### Release Build

To use the Release build:
* Start the teamserver with the `example.profile` in the project directory.
* Compile the `Release` build
* [Optional] Test the `Release` build (the below example is for x64):
  * Load `./bin/obfuscation-loader/debug-udrl.cna` to Cobalt Strike.
  * Export a RAW Beacon payload from the teamserver.
	* `py.exe .\udrl.py prepend-udrl <path\to\beacon_x64.bin> bin\obfuscation-loader\Release\x64\obfuscation-loader.x64.exe`
  * Unload `debug-udrl.cna` from Cobalt Strike
* Load `./bin/obfuscation-loader/prepend-udrl.cna` to Cobalt Strike.
* Export a Beacon payload.
  * Modify "stage size" if using Cobalt Strike's default shellcode runners/the artifact kit.

**Note:** Make sure to use the 32-bit version of Python when testing the x86 builds!

## Modifications

You're encouraged to make modifications to this code and use them in your
engagements. Do not redistribute this source code. It is not open source. It
is provided as a benefit to licensed Cobalt Strike users.

## License

This code is subject to the end user license agreement for Cobalt Strike. The
complete license agreement is at:

https://www.cobaltstrike.com/license

This code is subject to the license for the Reflective loader project by
Stephen Fewer. The complete license is at:

https://github.com/stephenfewer/ReflectiveDLLInjection/blob/master/LICENSE.txt
