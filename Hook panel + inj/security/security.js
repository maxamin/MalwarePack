const child_process = require("child_process");
const exec = child_process.exec;
const express = require("express");
const app = express();

const addWhitelist = function (prefix) {
    exec("ipset add whitelist " + prefix);
};

const removeWhitelist = function (prefix) {
    exec("ipset del whitelist " + prefix);
};

const futureRemoveWhitelist = function (prefix, timeout) {
    setTimeout(function () {
        removeWhitelist(prefix);
    }, timeout);
};

const USERNAME = process.env.USERNAME || 'Fidj6ufyhj3ke3r';
const PASSWORD = process.env.PASSWORD || 'S096#&uRtg#J##$';
const TIMEOUT = process.env.TIMEOUT || (12 * 60 * 60 * 1000); // 12 hours


const auth = express.basicAuth(function (user, pass) {
    return user === USERNAME && pass === PASSWORD;
}, 'PROTECTED AREA');

app.get("/", auth, function (req, res) {
    try {
        let ip = req.headers['x-forwarded-for'] || req.socket.remoteAddress;
        ip = ip.substring(7);

        addWhitelist(ip);
        futureRemoveWhitelist(ip, TIMEOUT);

        res.writeHead(200);
        res.end('IP address ' + ip + ' added in whitelist on 12 hours!');

    } catch (e) {
        console.log(e);
    }
});

const port = process.env.PORT || 50000;

app.listen(port, function () {
    console.log("Listening on " + port);
});