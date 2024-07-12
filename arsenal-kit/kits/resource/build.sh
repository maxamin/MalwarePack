#!/usr/bin/env bash

# make our output look nice...
kit_name="Resource Kit"

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
    print_error '  ./build.sh /tmp/dist/resource'

    exit 2
fi

# Clean

dist_directory="${1}"

rm -rf "${dist_directory}"
mkdir -p "${dist_directory}"

# Copy the resources into the distribution directory
print_good "Copy the resource files"
cp ./compress.ps1 "${dist_directory}"
cp ./template* "${dist_directory}"

print_good "Generate the resources.cna from the template file."
sed 's/KITNAME/resource_kit/' ../../templates/helper_functions.template > "${dist_directory}/resources.cna"
cat ./script_template.cna >> "${dist_directory}/resources.cna"

print_good "The resource kit files are saved in '${dist_directory}'"
