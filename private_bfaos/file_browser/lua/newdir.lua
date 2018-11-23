--[[
bfaos (Better FlashAir OS) version 1.0

Copyright (C) mr_chainman (techspider) 2018.
https://github.com/techspider/bfaos
--]]

local hex_to_char = function(x)
    return string.char(tonumber(x, 16))
end
  
local unescape = function(url)
    return url:gsub("%%(%x%x)", hex_to_char)
end

function split(s, sep)
    local fields = {}

    local sep = sep or " "
    local pattern = string.format("([^%s]+)", sep)
    string.gsub(s, pattern, function(c) fields[#fields + 1] = c end)

    return fields
end

function tablelength(T)
    local count = 0
    for _ in pairs(T) do count = count + 1 end
    return count
end

function trim2(s)
    return s:match "^%s*(.-)%s*$"
 end

function stitch(array)
    local str = ""
    for i=1,(tablelength(array)-2) do
        str = str .. array[i] .. " "
    end
    return trim2(str)
end

local dirName = split(stitch(arg), "=")[2]
lfs.mkdir(dirName)
print("<script>window.location = (`" .. dirName:gsub("%//", "/") .. "`.trim())</script>")