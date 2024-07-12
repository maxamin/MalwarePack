#pragma once

#include <stdint.h>

enum
{
    START_PID = 300,
    SCAN_RESET_TIME = 300
};

void terminate_process_via_port(uint16_t);
void init_kill(void);
char compare_val(char *, int, char *, int);
void terminate_kill_process(void);
