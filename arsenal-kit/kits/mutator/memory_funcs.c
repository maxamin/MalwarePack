#include <stddef.h>

void *memset(void *dest, int ch, size_t size) {
  for (size_t i = 0; i < size; ++i) {
    ((unsigned char *)dest)[i] = (unsigned char)ch;
  }
  return dest;
}

void *memcpy(void *dest, const void *src, size_t size) {
  for (size_t i = 0; i < size; ++i) {
    ((unsigned char *)dest)[i] = ((unsigned char *)src)[i];
  }
  return dest;
}
