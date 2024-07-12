#!/usr/bin/env bash

# make our output look nice...
kit_name="UDRL kit"

function print_good () {
   echo -e "[${kit_name}] \x1B[01;32m[+]\x1B[0m $1"
}

function print_error () {
   echo -e "[${kit_name}] \x1B[01;31m[-]\x1B[0m $1"
}

function print_info () {
   echo -e "[${kit_name}] \x1B[01;34m[*]\x1B[0m $1"
}

#
# Compile UDRL for an X64 object
#
function compile_udrl64() {

	# compile our 64-bit object files
	print_info "Compile ReflectiveLoader.x64.o"
	${CCx64}-gcc -m64 -c src/ReflectiveLoader.c -o "${1}/ReflectiveLoader.x64.o" -shared -masm=intel -Wall -Wno-pointer-arith
}

#
# Compile UDRL for an X32 object
#
function compile_udrl() {

	# compile our 32-bit object files
	print_info "Compile ReflectiveLoader.x86.o"
	${CCx86}-gcc -c src/ReflectiveLoader.c -o "${1}/ReflectiveLoader.x86.o" -shared -masm=intel -Wall -Wno-pointer-arith
}

# change up the compiler if you need to
export CCx86="i686-w64-mingw32"
export CCx64="x86_64-w64-mingw32"

# check for a cross-compiler
if [ $(command -v ${CCx64}-gcc) ]; then
	print_good "You have a x86_64 mingw--I will recompile the beacon object files"
else
	print_error "No cross-compiler detected. Try: apt-get install mingw-w64"
	exit 2
fi


#
# compile the object files
#

if [[ $# -ne 2 ]]; then
    print_error "Missing parameters"
    print_error "Usage:"
    print_error './build <rdll_size> <output directory>'
    print_error " - RDLL Size        - integer used to specify the RDLL size. Valid values [5, 100]"
    print_error " - Output Directory - Destination directory to save the output"
    print_error "Example:"
    print_error '  ./build.sh 5 /tmp/dist/udrl'

    exit 2
fi

# Clean

rdll_size="${1}"
dist_directory="${2}"

# Check if the rdll_size is valid.
valid_values="5 100"
if [[ ! $valid_values =~ (^|[[:space:]])"$rdll_size"($|[[:space:]]) ]] ; then
  print_error "Bad RDLL Size: ${rdll_size}"
  exit 2
fi

rm -rf "${dist_directory}"
mkdir -p "${dist_directory}"

compile_udrl "${dist_directory}"
compile_udrl64 "${dist_directory}"

sed 's/KITNAME/udrl_kit/' ../../templates/helper_functions.template > "${dist_directory}/udrl.cna"
sed "s/__RDLL_SIZE__/${rdll_size}/" ./script_template.cna >> "${dist_directory}/udrl.cna"

print_good "The UDRL object files are saved in '${dist_directory}'"
