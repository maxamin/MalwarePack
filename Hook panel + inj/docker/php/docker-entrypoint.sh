#!/bin/sh

set -e

cron
supervisord --configuration /etc/supervisord.conf

if [ "${1#-}" != "$1" ]; then
        set -- php-fpm7 "$@"
fi

exec "$@"

source .env