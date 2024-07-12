SHELL := /bin/bash
include .env

.PHONY: backend.updateRoles

install:
	sudo apt-get update
	sudo apt-get install unzip build-essential apt-transport-https ca-certificates curl gnupg lsb-release -y
	apt -y install docker.io docker-compose

ports:
	sudo iptables -I INPUT -p tcp -m tcp --dport ${BACKEND_PORT} -j ACCEPT
	sudo iptables -I INPUT -p tcp -m tcp --dport ${FRONTEND_PORT} -j ACCEPT
	sudo iptables -I INPUT -p tcp -m tcp --dport ${GOLANG_PORT} -j ACCEPT
	sudo iptables -I INPUT -p tcp -m tcp --dport 8000 -j ACCEPT

env:
	cp backend/.env.example backend/.env
	cp frontend/.env.example frontend/.env
	cp frontend/.env.production.example frontend/.env.production
	cp golang/.env.example golang/.env
	sed -i "s|REACT_APP_BACKEND_URL=|REACT_APP_BACKEND_URL=${BACKEND_URL}|g" frontend/.env
	sed -i "s|REACT_APP_BACKEND_URL=|REACT_APP_BACKEND_URL=${BACKEND_URL}|g" frontend/.env.production
	sed -i "s|REACT_APP_SOCKET_IO_URL=|REACT_APP_SOCKET_IO_URL=${SOCKET_IO_URL}|g" frontend/.env
	sed -i "s|REACT_APP_SOCKET_IO_URL=|REACT_APP_SOCKET_IO_URL=${SOCKET_IO_URL}|g" frontend/.env.production
	sed -i "s|REACT_APP_TIMEZONE=|REACT_APP_TIMEZONE=${TIMEZONE}|g" frontend/.env
	sed -i "s|REACT_APP_TIMEZONE=|REACT_APP_TIMEZONE=${TIMEZONE}|g" frontend/.env.production
	sed -i "s|USER1=|USER1=${MYSQL_USER}|g" golang/.env
	sed -i "s|PASS=|PASS=${MYSQL_PASSWORD}|g" golang/.env
	sed -i "s|DATABASE=|DATABASE=${MYSQL_DATABASE}|g" golang/.env
	sed -i "s|PORT=|PORT=${GOLANG_PORT}|g" golang/.env
	sed -i "s|PORTDB=|PORTDB=${MYSQL_PORT}|g" golang/.env
	sed -i "s|KEY1=|KEY1=${GOLANG_KEY}|g" golang/.env
	sed -i "s|InitialVector=|InitialVector=${GOLANG_INITIAL_VECTOR}|g" golang/.env
	sed -i "s|PANEL_BACKEND_URL=|PANEL_BACKEND_URL=${FRONTEND_URL}|g" golang/.env

build:
	chmod 775 golang/server_go
	docker-compose build
	docker-compose up -d
	docker-compose exec php chown -R www-data:www-data .
	docker-compose exec php composer install --optimize-autoloader --no-dev
	docker-compose exec php php artisan migrate
	docker-compose exec php php artisan db:seed
	docker-compose exec php php artisan jwt:secret
	docker-compose exec php php artisan key:generate
	docker-compose exec php php artisan config:cache
	docker-compose exec php php artisan route:cache
	docker-compose exec php chown -R www-data:www-data .
	docker-compose exec node npm install
	docker-compose exec node npm run build

build.backend:
	docker-compose exec php chown -R www-data:www-data .
	docker-compose exec php composer install
	docker-compose exec php php artisan migrate
	docker-compose exec php php artisan db:seed
	docker-compose exec php chmod -R 775 storage/

build.frontend:
	docker-compose exec node npm install
	docker-compose exec node npm run build

build.golang:
	chmod 775 golang/server_go

restart:
	docker-compose restart

stop:
	docker-compose stop

down:
	docker-compose down -v

backend.updateRoles:
	docker-compose exec php php artisan db:seed RolesSeeder
	docker-compose exec php php artisan cache:forget spatie.permission.cache