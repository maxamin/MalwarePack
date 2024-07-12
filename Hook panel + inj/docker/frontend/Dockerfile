FROM mhart/alpine-node:14.13.1 as ermac_docker_frontend
WORKDIR /var/www
COPY frontend/. /var/www

FROM nginx:alpine AS ermac_docker_nginx_frontend
WORKDIR /usr/share/nginx/html
COPY --from=ermac_docker_frontend /var/www/build/ /usr/share/nginx/html

RUN set -ex;