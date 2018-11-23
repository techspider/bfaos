/*
bfaos (Better FlashAir OS) version 1.0

Copyright (C) mr_chainman (techspider) 2018.
https://github.com/techspider/bfaos
*/

var banned_chrs = ["|", "<", ">", ":", "\"", "/", "\\", "?", "*"];
var sys_reserved_names = ["CON", "PRN", "AUX", "NUL", "COM1", "COM2", "COM3", "COM4", "COM5", "COM6", "COM7", "COM8", "COM9", "LPT1", "LPT2", "LPT3", "LPT4", "LPT5", "LPT6", "LPT7", "LPT8", "LPT9"];

var UIDialog = {
    NewDirDialog: {
        Show: () => {
            var p = prompt("Enter directory name", "Untitled");
            if((p != null) && (p.trim() != ""))
            {
                if(sys_reserved_names.includes(p.trim().toUpperCase()))
                {
                    alert("Error: The directory name is a reserved system name.");
                    return;
                }
                for(var x = 0; x < banned_chrs.length; x++)
                    if(p.includes(banned_chrs[x]))
                    {
                        alert("Error: The directory name contains invalid characters!");
                        return;
                    } 
                var prevPath = currentPath;
                if(currentPath == "/") prevPath = "//";
                window.location.href = `/private_bfaos/file_browser/lua/newdir.lua?dirname=${currentPath}/${p}`;
            }
        }
    },
    RenameDialog: function() {
        this.show = function (fileName)
        {
            var p = prompt("Enter new name", "Untitled");
            if((p != null) && (p.trim() != ""))
            {
                if(sys_reserved_names.includes(p.trim().toUpperCase()))
                {
                    alert("Error: This name is a reserved system name.");
                    return;
                }
                for(var x = 0; x < banned_chrs.length; x++)
                    if(p.includes(banned_chrs[x]))
                    {
                        alert("Error: This name contains invalid characters!");
                        return;
                    }
                var prevPath = currentPath;
                if(currentPath == "/") prevPath = "//";
                window.location.href = `/private_bfaos/file_browser/lua/rename.lua?mf=${currentPath}/${fileName}|${currentPath}/${p}|/${currentPath}`;
            }
        }
    }
}