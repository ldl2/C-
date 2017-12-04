sudo apt-get update
sudo apt-get install nginx
cp ./templates/default /etc/nginx/sites-available/default
sudo mkdir /etc/systemd/system/nginx.service.d/
cp ./templates/override.conf /etc/systemd/system/nginx.service.d/override.conf
sudo systemctl daemon-reload
sudo service nginx restart
sudo apt-get install mysql-server
curl https://packages.microsoft.com/keys/microsoft.asc | gpg --dearmor > microsoft.gpg
sudo mv microsoft.pgp /etc/apt/trusted.gpg.d/
sudo sh -c 'echo "deb [arch=amd64] https://packages.microsoft.com/repos/microsoft-ubuntu-xenial-prod xenial main" > /etc/apt/sources.list.d/dotnetdev.list'
sudo apt-get update
sudo apt-get install dotnet-sdk-2.0.3
ss -ltnp
dotnet publish
sudo cp ./templates/name.conf /etc/supervisor/conf.d/name.conf