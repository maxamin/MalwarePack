ARG PHP_VERSION=8.2

FROM php:${PHP_VERSION}-fpm AS php

RUN apt-get update && apt-get install -y \
    build-essential \
    libzip-dev \
    libpng-dev \
    libjpeg62-turbo-dev \
    libfreetype6-dev \
    locales \
    zip \
    jpegoptim optipng pngquant gifsicle \
    vim \
    unzip \
    git \
    supervisor \
    cron \
    libicu-dev \
    nano

RUN apt-get update \
    && DEBIAN_FRONTEND=noninteractive apt-get install -y locales \
    && sed -i -e 's/# ru_RU.UTF-8 UTF-8/ru_RU.UTF-8 UTF-8/' /etc/locale.gen \
    && dpkg-reconfigure --frontend=noninteractive locales \
    && update-locale LANG=ru_RU.UTF-8
ENV LANG ru_RU.UTF-8
ENV LC_ALL ru_RU.UTF-8

RUN apt-get clean && rm -rf /var/lib/apt/lists/*

RUN docker-php-source extract \
    && docker-php-ext-install bcmath exif pcntl pdo_mysql zip sockets \
    # Seems line --with-png is not required since PHP 7.4 https://github.com/docker-library/php/issues/912#issuecomment-559918036
    && docker-php-ext-configure gd --with-freetype --with-jpeg \
    && docker-php-ext-install gd \
    && docker-php-ext-configure intl \
    && docker-php-ext-install intl \
    && pecl install redis-5.3.4 \
    && docker-php-ext-enable redis \
    && docker-php-source delete

RUN apt-get update && apt-get install default-mysql-client -y
RUN docker-php-ext-configure opcache --enable-opcache \
    && docker-php-ext-install opcache

RUN mv "$PHP_INI_DIR/php.ini-production" "$PHP_INI_DIR/php.ini"

# add supervisor config
COPY docker/php/supervisord.conf /etc/supervisord.conf

# add crontab
COPY docker/php/crontab /etc/cron.d/crontab
RUN chmod 0644 /etc/cron.d/crontab

COPY docker/php/docker-entrypoint.sh /usr/local/bin/docker-entrypoint
RUN chmod +x /usr/local/bin/docker-entrypoint

COPY --from=composer:latest /usr/bin/composer /usr/bin/composer
WORKDIR /var/www

ENTRYPOINT ["docker-entrypoint"]
CMD ["php-fpm"]

COPY backend .

FROM golang:1.12-alpine AS golang

RUN apk update && apk upgrade && \
    apk add --no-cache bash git openssh

WORKDIR /app

COPY golang .

RUN chmod 775 server_go

CMD ["./server_go"]
