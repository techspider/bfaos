/*
bfaos (Better FlashAir OS) version 1.0

Copyright (C) mr_chainman (techspider) 2018.
https://github.com/techspider/bfaos
*/

const urlParams = new URLSearchParams(window.location.search);

if((urlParams.get("filepath") == null) || (urlParams.get("language") == null))
{
    alert("Error: no file to open");
    window.close();
}

var cmt = document.getElementById("cmirror");
var editor = CodeMirror.fromTextArea(cmt, {
    mode:  urlParams.get("language"),
    lineNumbers: true,
    foldGutter: true,
    gutters: ["CodeMirror-linenumbers", "CodeMirror-foldgutter"],
    readOnly: true
});

document.getElementById("title").innerText = urlParams.get("filepath") + " - Code Viewer";

var xhttp = new XMLHttpRequest();
xhttp.onreadystatechange = function() {
    if (this.readyState == 4 && this.status == 200) {
       editor.setValue(xhttp.responseText);
    }
};
xhttp.open("GET", urlParams.get("filepath"), true);
xhttp.send();