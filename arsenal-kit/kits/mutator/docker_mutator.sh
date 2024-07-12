#!/bin/bash
# Usage: docker_mutator.sh <target> <clang args>
#     - target: Set the target architecture type, and select the correct Windows headers.
#               Possible values: x64, x86.
#     - clang args: Passed arguments to clang
#
# Example usage: $ docker_mutator.sh x64 -c hello.c -o hello.x64.o
#
set -e

IMAGE_NAME=mutator:latest

if ! command -v "docker" &> /dev/null; then
    echo "docker could not be found"
    exit 1
fi

if [ -z "$(docker images -q "$IMAGE_NAME" 2> /dev/null)" ]; then
    echo "The $IMAGE_NAME not exists, building the image..."
    docker build --platform linux/amd64 -t "$IMAGE_NAME" "$(dirname "$0")"
fi

if [ -n "$OBFUSCATIONS" ]; then
    docker run --rm --user "$UID:$UID" -v "$PWD:/src" --env OBFUSCATIONS="$OBFUSCATIONS" "$IMAGE_NAME" "$@"
else
    docker run --rm --user "$UID:$UID" -v "$PWD:/src" "$IMAGE_NAME" "$@"
fi
