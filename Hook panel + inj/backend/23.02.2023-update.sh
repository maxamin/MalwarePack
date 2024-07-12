docker-compose exec php composer install
docker-compose exec php php artisan key:generate
docker-compose exec php php artisan config:cache
docker-compose exec php php artisan migrate
docker-compose exec php php artisan db:seed RolesSeeder
docker-compose exec php php artisan route:cache
docker-compose exec php chown -R www-data:www-data .
