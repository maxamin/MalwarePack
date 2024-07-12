#!/usr/bin/env bash

# make our output look nice...
kit_name="Mimikatz kit"

function print_good () {
   echo -e "[${kit_name}] \x1B[01;32m[+]\x1B[0m $1"
}

function print_error () {
   echo -e "[${kit_name}] \x1B[01;31m[-]\x1B[0m $1"
}

function print_info () {
   echo -e "[${kit_name}] \x1B[01;34m[*]\x1B[0m $1"
}


if [[ $# -ne 1 ]]; then
    print_error "Missing parameters"
    print_error "Provide a DIST directory to save the output"
    print_error "Example:"
    print_error '  ./build.sh /tmp/dist/mimikatz'

    exit 2
fi

# Clean

dist_directory="${1}"

rm -rf "${dist_directory}"
mkdir -p "${dist_directory}"

# Generate the kit into the distribution directory.
print_good "Copying the mimikatz dlls"
cp ./*.dll "${dist_directory}/"

print_good "Generate the mimikatz.cna from the template file."
sed 's/KITNAME/mimikatz_kit/' ../../templates/helper_functions.template > "${dist_directory}/mimikatz.cna"
cat ./script_template.cna >> "${dist_directory}/mimikatz.cna"

print_good "The Mimikatz files are saved in '${dist_directory}'"
