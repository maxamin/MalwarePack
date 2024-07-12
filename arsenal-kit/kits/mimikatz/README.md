# Mimikatz Kit

This package contains the pre-built Mimikatz dlls used with Colbalt Strike.
The kit will attempt to stay current with the latest Mimikatz release, so
you can download the package and have access to the latest Mimikatz commands
to use with your current version of Cobalt Strike.

List of dlls contained in the resources directory:
- mimikatz-chrome.x86.dll
- mimikatz-chrome.x64.dll
- mimikatz-full.x86.dll
- mimikatz-full.x64.dll
- mimikatz-min.x86.dll
- mimikatz-min.x64.dll
- mimikatz-max.x86.dll
- mimikatz-max.x64.dll

The mimikatz dlls are custom-built dlls to include a reflective dll loader and
modified code in order to reduce the size to work with the legacy 1-MB 
size limit.  With the release of Cobalt Strike 4.6 this limit can be modified
however the default is still 1-MB, which is why the dlls are still custom-built. 

Starting with the 20221205 version of the Arsenal Kit an additional built
version of the Mimikatz dlls will also be provided. These dlls are not used
by default and require a modification to the script_template.cna as well as
the tasks_max_size malleable C2 profile setting.  The difference with the
'max' version is there is no code modification to the Mimikatz code in order
to reduce the dll size.  The custom reflective dll loader is still added.

For most users the mimikatz-full version will be sufficient for your use cases,
however if you require some functionality that has been removed try the
mimikatz-max version.

For the modifications to use the mimikatz-max version an update to the
mimikatz/script_template.cna file is required.  You just need to change
which code lines are commented out and there is details in the script.
The malleable C2 profile setting 'tasks_max_size' also needs to be set
large enough for the mimikatz-max.x64.dll size to be sent through.

Considerations:
 - To use the mimikatz-max.<arch>.dll version requires Cobalt Strike 4.6 or later
 - The tasks_max_size setting needs to be set large enough for the dll to be sent.
 - The tasks_max_size setting affects how beacons are generated.  Refer to the
   tasks_mas_size setting documentation for additional information.


# Load into Cobalt Strike

To use the Mimikatz Kit, load the mimikatz.cna into Cobalt Strike.

Open the Scripts manager, Cobalt Strike -> Scripts

Load `<output directory>/mimikatz/mimikatz.cna`

# License

This code is subject to the end user license agreement for Cobalt Strike. The
complete license agreement is at:

https://www.cobaltstrike.com/license

Mimikatz was created by Benjamin Delpy.
https://github.com/gentilkiwi/mimikatz

CC BY 4.0 licence
https://creativecommons.org/licenses/by/4.0
