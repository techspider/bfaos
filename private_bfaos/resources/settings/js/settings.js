/*
bfaos (Better FlashAir OS) version 1.0

Copyright (C) mr_chainman (techspider) 2018.
https://github.com/techspider/bfaos
*/

function download(data, filename, type)
{
    var file = new Blob([data], {type: type});
    if (window.navigator.msSaveOrOpenBlob)
        window.navigator.msSaveOrOpenBlob(file, filename);
    else
    {
        var a = document.createElement("a"),
        url = URL.createObjectURL(file);
        a.href = url;
        a.download = filename;
        document.body.appendChild(a);
        a.click();
        setTimeout(function() {
            document.body.removeChild(a);
            window.URL.revokeObjectURL(url);  
        }, 0); 
    }
}