/*
bfaos (Better FlashAir OS) version 1.0

Copyright (C) mr_chainman (techspider) 2018.
https://github.com/techspider/bfaos
*/

var ctxMenu = document.getElementById("ctxmenu");
var ctxm_options = document.getElementById("ctxm-options");

contextMenu = {};

contextMenu.open = function() { ctxMenu.style.display = "block"; }
contextMenu.close = function() { ctxMenu.style.display = "none"; }
contextMenu.isOpen = function() { return ctxMenu.style.display == "block" ? true : false; }
contextMenu.setpos = function(x,y) { ctxMenu.style.top = `${y}px`; ctxMenu.style.left = `${x}px`; }
contextMenu.items = {};
contextMenu.items.clear = function() { ctxm_options.innerHTML = ""; }
isInMenu = false;
contextMenu.items.add = function(name, cb)
{
    var mitem = document.createElement("li");
    mitem.setAttribute("class", "menu-option");
    mitem.innerHTML = name;
    mitem.onclick = ()=>{ cb(); contextMenu.close(); };
    ctxm_options.appendChild(mitem);
}
ctxMenu.onmouseenter = function() { isInMenu = true; }
ctxMenu.onmouseleave = function() { isInMenu = false; }

window.addEventListener("click", e => {
    if(!isInMenu) if(ctxMenu.style.display != "none") ctxMenu.style.display = "none";
});

/**
 * @callback onActivateCb
 */