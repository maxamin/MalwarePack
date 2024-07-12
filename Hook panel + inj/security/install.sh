sudo apt-get update -y
sudo apt-get install make nodejs npm ipset iptables netfilter-persistent ipset-persistent iptables-persistent -y

ipset -N whitelist iphash
ipset -N localnet hash:net

iptables -I INPUT -i ens3 -m set ! --match-set whitelist src -p tcp --dport 80 -j DROP

iptables -A INPUT -p tcp -m tcp --dport 50000 -j ACCEPT
iptables -I DOCKER-USER -i ens3 -m set ! --match-set whitelist src -p tcp --dport 80 -j DROP
iptables -I DOCKER-USER -i ens3 -m set ! --match-set whitelist src -p tcp --dport 5000 -j DROP
iptables -I DOCKER-USER -i ens3 -m set ! --match-set whitelist src -p tcp --dport 8089 -j DROP
iptables -I DOCKER-USER -i ens3 -m set ! --match-set whitelist src -p tcp --dport 8000 -j DROP
iptables -I DOCKER-USER -i ens3 -m set ! --match-set whitelist src -p tcp --dport 8000 -j DROP
iptables -I DOCKER-USER -i ens3 -m set ! --match-set localnet src -p tcp --dport 3306 -j DROP

npm install express@3.*
npm -g install pm2
pm2 startup
pm2 start --name security /var/www/security/security.js
pm2 save
