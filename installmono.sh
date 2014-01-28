#if putty
stty sane
export TERM=linux

sudo apt-get install git;
mkdir code
cd code
mkdir debianserver
cd debianserver
git clone https://github.com/meselgroth/debianserver.git

sudo apt-get update; sudo apt-get upgrade;
sudo apt-get install mono-complete;