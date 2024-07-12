#!/bin/bash
# Usage: requirements.sh
# Installs the mutator kit requirements *without* docker.
set -o nounset

echo "[+] Installing mutator kit requirements..."

# [0] Set up required directories.
mutator_dir=$(pwd)
obfuscator_lib="libLLVMObfuscator.so"

# [1] Install dependencies.
dependencies="ca-certificates git build-essential cmake llvm-14 llvm-14-dev clang-14 mingw-w64"
echo "[+] Installing dependencies: $dependencies"
sudo apt update
sudo apt-get install $dependencies

# [2] Clone obfuscator-llvm and build it.
echo "[+] Building obfuscator-llvm pass..."
git clone --depth 1 --branch 20240115 --single-branch https://github.com/Cobalt-Strike/obfuscator-llvm.git
mkdir -p obfuscator-llvm/build
cd obfuscator-llvm/build/
cmake -DLLVM_DIR=/usr/lib/llvm-14/cmake ..
make
cp $obfuscator_lib "$mutator_dir"

# [3] Show example usage.
# [3.1] Via the Cobalt Strike client.
echo "[+] Successfully installed the mutator kit."
echo "[+] To use the plugin load sleepmask_mutator.cna into the Cobalt Strike client."
echo

# [3.2] Manually via the command line.
echo "[+] Alternatively, to manually mutate sleep masks on the command line:"
echo "[1] Set the following environment variables:"
echo 'export PATH=$PATH:'"${mutator_dir}"
echo 'export LLVM_OBFUSCATOR_PATH='"${mutator_dir}"/"${obfuscator_lib}"
echo "export CLANG=clang-14"
echo "export LLVM_VERSION=14"
# Modify these to your desired settings, below is the default option.
echo "export OBFUSCATIONS=substitution,flattening,split-basic-blocks"
echo "[2] Navigate to the sleep mask source code: cd ../sleepmask/src49/"
echo "[3] Run: mutator.sh x64 -c -DIMPL_CHKSTK_MS=1 -o sleepmask.x64.o sleepmask.c"
