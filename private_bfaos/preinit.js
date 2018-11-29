/*
bfaos (Better FlashAir OS) version 1.0

Copyright (C) mr_chainman (techspider) 2018.
https://github.com/techspider/bfaos
*/

function createXHR(address, reqType, asyncProc)
{
    var r = window.XMLHttpRequest ? new XMLHttpRequest() : new ActiveXObject("Microsoft.XMLHTTP");
    if (asyncProc) 
       r.onreadystatechange = function () { 
           if (this.readyState == 4) asyncProc(this); 
       }; 
    r.open(reqType, address, !(!asyncProc));
    r.send();
    return r;
}

var currentPath = window.location.pathname;

if(currentPath != "/")
    if(currentPath.endsWith("/"))
        currentPath = currentPath.substr(0, currentPath.length - 1);

if(config.preinit.nav_index)
{
    var req = createXHR("/private_bfaos/file_browser/lua/exists.lua", "GET");
    if(req.status == 200 && this.readyState == 4)
    {
        if(req.responseText.trim() == "TRUE")
        {
            window.location = currentPath + "/index.html";
        }
    }
}
