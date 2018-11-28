/*
bfaos (Better FlashAir OS) version 1.0

Copyright (C) mr_chainman (techspider) 2018.
https://github.com/techspider/bfaos
*/

/**
 * A structure to hold all settings
 * @param {string} theme The theme name
 * @param {string} lvmode The list view mode
 */
function BFAOS_Settings(theme, lvmode, hideSysContent)
{
    this.theme = (theme != null) ? theme : "default";
    this.lvmode = (lvmode != null) ? lvmode : "list";
    this.sysContentHidden = (hideSysContent != null) ? hideSysContent : true;
}

if(wlansd == null)
    console.error("File browser will likely fail due to missing wlan sd!");

var currentPath = window.location.pathname;
var listViewMode = "list";
var currentTheme = "default";
var hideSystemContent = true;

if(config != null)
{
    listViewMode = config.file_browser.view;
    currentTheme = config.file_browser.theme.name;
    hideSystemContent = config.file_browser.hideSystemContent;
}

//check for settings
if(localStorage.getItem("bfaos_settings") != null)
{
    /** @type {BFAOS_Settings} */
    var settings = JSON.parse(localStorage.getItem("bfaos_settings"));
    currentTheme = settings.theme;
    listViewMode = settings.lvmode;
    hideSystemContent = settings.sysContentHidden;
}

if(currentPath != "/")
    if(currentPath.endsWith("/"))
        currentPath = currentPath.substr(0, currentPath.length - 1);

document.getElementById("title").innerText = `${decodeURI(currentPath)} - BFAOS Explorer`;
document.getElementById("nav-title").innerText = decodeURI(currentPath);

function SDNode(attr, fdate, fname, fsize, ftime, r_uri)
{
    this.attr = attr;
    this.fdate = fdate;
    this.fname = fname;
    this.fsize = fsize;
    this.ftime = ftime;
    this.r_uri = r_uri;
}

/** @type {SDNode[]} */
var dirs = [];
/** @type {SDNode[]} */
var files = [];
var fs_view = document.getElementsByClassName("fs-view")[0];

for(var x = 0; x < wlansd.length; x++)
{
    if(((wlansd[x].attr == 16) || (wlansd[x].attr == 48)) && (wlansd[x].fsize == 0))
        dirs.push(wlansd[x]);
    else
        files.push(wlansd[x]);
     
}

dirs.sort(function(a,b){
    if(a.fname < b.fname) { return -1; }
    if(a.fname > b.fname) { return 1; }
    return 0;
});

files.sort(function(a,b){
    if(a.fname < b.fname) { return -1; }
    if(a.fname > b.fname) { return 1; }
    return 0;
});

function getFolderIcon(dname)
{
    switch(dname)
    {
        default:
            return `/private_bfaos/file_browser/themes/${currentTheme}/file-icons/folder.png`;
        case "DCIM":
            return `/private_bfaos/file_browser/themes/${currentTheme}/file-icons/folder-dcim.png`;
        case "private-bfaos":
            return `/private_bfaos/file_browser/themes/${currentTheme}/file-icons/folder-sys.png`;
    }
}

function loadDirs()
{
    var SEP = "/";
    switch(listViewMode)
    {
        case "list":
            if(currentPath != "/")
            {
                var fs_item = document.createElement("tr");
                fs_item.setAttribute("class", "fs-item");
                var fs_name = document.createElement("td");
                var fs_type = document.createElement("td");
                fs_name.innerHTML = `<img src="${getFolderIcon("..")}"><a href="${currentPath}${SEP}..">Up..</a>`;
                fs_type.innerText = "File Folder";
                fs_item.appendChild(fs_name);
                fs_item.appendChild(fs_type);
                fs_view.appendChild(fs_item);
            }
            for(var x = 0; x < dirs.length; x++)
            {
                var dir = dirs[x];
                var fs_item = document.createElement("tr");
                fs_item.setAttribute("class", "fs-item");
                var fs_name = document.createElement("td");
                var fs_type = document.createElement("td");
                if(currentPath == "/") SEP = "";
                var fi = getFolderIcon(dir.fname);
                var fp = `${currentPath}${SEP}${dir.fname}`;
                if(currentPath + dir.fname == "/private_bfaos")
                {
                    if(hideSystemContent)
                        continue; //Ignore private_bfaos
                    fi = `/private_bfaos/file_browser/themes/${currentTheme}/file-icons/folder-sys.png`;
                    fp = `/private_bfaos/dialogs/sys_warning.html?redir=${fp}&prev=${currentPath}`;
                }
                fs_name.innerHTML = `<img src="${fi}"><a href="${fp}">${dir.fname}</a>`;
                
                fs_type.innerText = "File Folder";
                fs_item.appendChild(fs_name);
                fs_item.appendChild(fs_type);
                //ctx menu start
                fs_item.oncontextmenu = function(e)
                {
                    contextMenu.items.clear();
                    var uid = (dir.fdate.toString() + dir.fsize.toString() + dir.ftime.toString() + dir.fname);
                    fs_item.setAttribute("id", uid);
                    e.preventDefault();
                    contextMenu.setpos(e.pageX, e.pageY);
                    contextMenu.items.add("Rename", ()=>{
                        new UIDialog.RenameDialog().show(e.srcElement.innerText);
                    });
                    contextMenu.open();
                }
                //ctx menu end
                fs_view.appendChild(fs_item);
            }
            break;
    }
}

function getFileType(fname)
{
    var e = fname.split('.');
    if(e.length <= 1) return "File";
    var ext = e[e.length - 1].toLowerCase();
    switch(ext)
    {
        default:
            return "File";
        case "exe":
            return "Windows Executable";
        case "html":
            return "HTML File";
        case "htm":
            return "HTML File";
        case "lua":
            return "Lua Script";
        case "js":
            return "JavaScript File"
        case "css":
            return "Cascading Style Sheet";
        case "png":
            return "Image";
        case "jpg":
            return "Image";
        case "gif":
            return "Image";
        case "bmp":
            return "Image";
    }
}

function getFileIcon(fname)
{
    var e = fname.split('.');
    if(e.length <= 1) return `/private_bfaos/file_browser/themes/${currentTheme}/file-icons/file.png`;
    var ext = e[e.length - 1].toLowerCase();
    switch(ext)
    {
        default:
            return `/private_bfaos/file_browser/themes/${currentTheme}/file-icons/file.png`;
        case "exe":
            return `/private_bfaos/file_browser/themes/${currentTheme}/file-icons/file-exe.png`;
        case "dll":
            return `/private_bfaos/file_browser/themes/${currentTheme}/file-icons/file-exe.png`;
        case "html":
            return `/private_bfaos/file_browser/themes/${currentTheme}/file-icons/file-html.png`;
        case "htm":
            return `/private_bfaos/file_browser/themes/${currentTheme}/file-icons/file-htm.png`;
        case "jpg":
            return `/private_bfaos/file_browser/themes/${currentTheme}/file-icons/file-image.png`;    
        case "png":
            return `/private_bfaos/file_browser/themes/${currentTheme}/file-icons/file-image.png`;
        case "gif":
            return `/private_bfaos/file_browser/themes/${currentTheme}/file-icons/file-image.png`;
        case "bmp":
            return `/private_bfaos/file_browser/themes/${currentTheme}/file-icons/file-image.png`;
        case "js":
            return `/private_bfaos/file_browser/themes/${currentTheme}/file-icons/file-js.png`;
        case "css":
            return `/private_bfaos/file_browser/themes/${currentTheme}/file-icons/file-css.png`;
        case "txt":
            return `/private_bfaos/file_browser/themes/${currentTheme}/file-icons/file-plain.png`;
        case "log":
            return `/private_bfaos/file_browser/themes/${currentTheme}/file-icons/file-plain.png`;
    }
}

function openFile(SEP, fname)
{
    var e = fname.split('.');
    if(e.length <= 1)
    {
        window.location = `${currentPath}${SEP}${fname}`;
        return;
    }
    var ext = e[e.length - 1].toLowerCase();
    switch(ext)
    {
        case "js":
            var url = `/private_bfaos/code_viewer/index.html?filepath=${currentPath}${SEP}${fname}&language=javascript`;
            window.open(url, "", "width=720,height=576");
            break;
        case "html":
            url = `/private_bfaos/code_viewer/index.html?filepath=${currentPath}${SEP}${fname}&language=html`;
            window.open(url, "", "width=720,height=576");
            break;
        case "txt":
            url = `/private_bfaos/code_viewer/index.html?filepath=${currentPath}${SEP}${fname}&language=text`;
            window.open(url, "", "width=720,height=576");
            break;
        case "css":
            url = `/private_bfaos/code_viewer/index.html?filepath=${currentPath}${SEP}${fname}&language=css`;
            window.open(url, "", "width=720,height=576");
            break;
    }
}

function loadFiles()
{
    var SEP = "/";
    switch(listViewMode)
    {
        case "list":
            for(var x = 0; x < files.length; x++)
            {
                var file = files[x];
                var fs_item = document.createElement("tr");
                fs_item.setAttribute("class", "fs-item");
                var fs_name = document.createElement("td");
                var fs_type = document.createElement("td");
                var fs_size = document.createElement("td");
                if(currentPath == "/") SEP = "";
                fs_name.innerHTML = `<img src="${getFileIcon(file.fname)}"><a href="${currentPath}${SEP}${file.fname}">${file.fname}</a>`;
                fs_type.innerText = getFileType(file.fname);
                var size = Math.round(file.fsize / 1024 / 1024);
                if(size == 0)
                {
                    k = Math.round(file.fsize / 1024);
                    if(k != 0) fs_size.innerText = `${k} KB`;
                    else fs_size.innerText = `1 KB`;
                }
                else
                    fs_size.innerText = `${size} MB`;
                if(file.fsize == 0)
                    fs_size.innerText = `0 KB`;
                fs_item.appendChild(fs_name);
                fs_item.appendChild(fs_type);
                fs_item.appendChild(fs_size);
                //ctx menu start
                fs_item.oncontextmenu = function(e)
                {
                    contextMenu.items.clear();
                    var uid = (file.fdate.toString() + file.fsize.toString() + file.ftime.toString() + file.fname);
                    fs_item.setAttribute("id", uid);
                    e.preventDefault();
                    contextMenu.setpos(e.pageX, e.pageY);
                    contextMenu.items.add("View", ()=>{
                        openFile(SEP, e.srcElement.innerText);
                    });
                    contextMenu.items.add("Download", ()=>{
                        window.location = `${currentPath}${SEP}${e.srcElement.innerText}`;
                    });
                    contextMenu.items.add("Rename", ()=>{
                        new UIDialog.RenameDialog().show(e.srcElement.innerText);
                    });
                    contextMenu.open();
                }
                //ctx menu end
                fs_view.appendChild(fs_item);
            }
            break;
    }
}

loadDirs();
loadFiles();