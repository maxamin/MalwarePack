ARG LLVM_VERSION=14

# Build stage
FROM alpine:3 AS build
ARG LLVM_VERSION

WORKDIR /

# Install build dependencies
RUN apk update && apk --no-cache add \
    llvm$LLVM_VERSION-static \
    llvm$LLVM_VERSION-dev \
    git \
    g++ \
    make \
    cmake \
    libxml2-dev

# Build the obfuscator LLVM plugin
RUN git clone --depth 1 --branch 20240115 --single-branch https://github.com/Cobalt-Strike/obfuscator-llvm.git \
    && mkdir obfuscator-llvm/build \
    && cd obfuscator-llvm/build \
    && cmake -DLLVM_DIR=/usr/lib/llvm$LLVM_VERSION/lib/cmake .. \
    && make

# Run stage
FROM alpine:3 AS mutator
ARG LLVM_VERSION
ARG OBFUSCATOR_PATH=/obfuscator.so

# Install run dependencies
RUN apk update && apk --no-cache add \
    llvm$LLVM_VERSION \
    clang$LLVM_VERSION \
    mingw-w64-headers \
    i686-mingw-w64-headers

# Copy the compiled plugin from the build stage
COPY --from=build /obfuscator-llvm/build/libLLVMObfuscator.so $OBFUSCATOR_PATH

# Copy our entrypoint
COPY --chmod=755 mutator.sh /entrypoint.sh

# Set up the environment
WORKDIR /src
ENV LLVM_VERSION=$LLVM_VERSION
ENV LLVM_OBFUSCATOR_PATH=$OBFUSCATOR_PATH
ENV OBFUSCATIONS="flattening,substitution,split-basic-blocks"

ENTRYPOINT ["/entrypoint.sh"]
