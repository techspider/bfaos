/*
bfaos (Better FlashAir OS) version 1.0

Copyright (C) mr_chainman (techspider) 2018.
https://github.com/techspider/bfaos
*/

const urlParams = new URLSearchParams(window.location.search);

function performRedir()
{
    const redirPath = urlParams.get('redir');
    window.location.href = redirPath;
}

function fsGoBack()
{
    window.location.href = urlParams.get('prev');
}