#!/bin/sh
# Usage: mutator.sh <target> <clang args>
#     - target: Set the target architecture type, and select the correct Windows headers.
#               Possible values: x64, x86.
#     - clang args: Passed arguments to clang
#
# Required environment variables:
#     - CLANG = Clang binary path
#     - LLVM_OBFUSCATOR_PATH = Obfuscator plugin path
#     - OBFUSCATIONS = Comma-separated list of selected mutations.
#                      Supported values: flattening, bogus, substitution, split-basic-blocks
#
# Example usage: $ CLANG=clang-14 \
#                  LLVM_OBFUSCATOR_PATH=obfuscator.so \
#                  OBFUSCATIONS=substitution,flattening \
#                  ./mutator.sh x64 -c hello.c -o hello.x64.o
set -o errexit
set -o nounset

[ -z "$*" ] && echo "Usage: mutator.sh <x64|x86> <clang args>" && exit 0

# Set compiler flags based on the selected target (the first argument)
case "$1" in
    x64)
        shift
        TARGET_FLAGS="-I/usr/x86_64-w64-mingw32/include -target x86_64-w64-mingw32" \
    ;;
    x86)
        shift
        TARGET_FLAGS="-I/usr/i686-w64-mingw32/include -target i686-w64-mingw32" \
    ;;
    *)
        TARGET_FLAGS="" \
    ;;
esac

# Execute clang with the obfuscator plugin and the selected mutations
CLANG=${CLANG:-"clang-$LLVM_VERSION"}
LLVM_OBF_SCALAROPTIMIZERLATE_PASSES=$OBFUSCATIONS \
    "$CLANG" \
    -fno-legacy-pass-manager \
    "-fpass-plugin=$LLVM_OBFUSCATOR_PATH" \
    $TARGET_FLAGS \
    "$@"
