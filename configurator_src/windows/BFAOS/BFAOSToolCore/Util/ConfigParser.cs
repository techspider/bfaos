/*
bfaos (Better FlashAir OS) version 1.0

Copyright (C) mr_chainman (techspider) 2018.
https://github.com/techspider/bfaos
*/

using BFAOSToolCore.FlashAir;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace BFAOSToolCore.Util
{
    public class ConfigParser
    {
        /// <summary>
        /// Parse the config file of a FlashAir SD card
        /// WLANSD section not supported as of now
        /// </summary>
        /// <param name="path">The path of the config file</param>
        /// <returns>An object representing the configuration file</returns>
        public static FlashAirConfig ParseConfig(string path)
        {
            Dictionary<string, string> kvp = new Dictionary<string, string>();
            if (!File.Exists(path))
                throw new FileNotFoundException();

            foreach(var line in File.ReadAllLines(path))
            {
                if (line.Trim() == "") continue;
                if (line.StartsWith("[")) continue;
                string propertyName = line.Split('=')[0];
                string propertyValue = line.Substring(propertyName.Length + 1);
                kvp[propertyName] = propertyValue;
            }

            FlashAirConfig cfg = new FlashAirConfig();
            cfg.AllowFileUpload = kvp.ContainsKey("UPLOAD") ? Util.Convert.IntToBool(int.Parse(kvp["UPLOAD"])) : false;
            cfg.AppMode = kvp.ContainsKey("APPMODE") ? int.Parse(kvp["APPMODE"]) : 4;
            cfg.AuthMode = kvp.ContainsKey("HTTPDMODE") ? int.Parse(kvp["HTTPDMODE"]) : 0;
            cfg.AuthCredentials = kvp.ContainsKey("HTTPDPASS") ? new AuthCreds(kvp["HTTPDUSER"], kvp["HTTPDPASS"]) : null;
            cfg.BridgeNetCreds = kvp.ContainsKey("BRGSSID") ? new NetCredentials(kvp["BRGSSID"], kvp["BRGNETWORKKEY"]) : null;
            cfg.CIPath = kvp.ContainsKey("CIPATH") ? kvp["CIPATH"] : "/DCIM/100__TSB/FA000001.JPG";
            cfg.DisabledCGIs = kvp.ContainsKey("DELCGI") ? new List<string>(kvp["DELCGI"].Split(',')) : null;
            cfg.FlashAirNetCreds = kvp.ContainsKey("APPSSID") ? new NetCredentials(kvp["APPSSID"], kvp["APPNETWORKKEY"]) : null;
            cfg.FWVersion = kvp.ContainsKey("VERSION") ? kvp["VERSION"] : null;
            cfg.Hostname = kvp.ContainsKey("APPNAME") ? kvp["APPNAME"] : "flashair";
            cfg.ProductName = kvp.ContainsKey("PRODUCT") ? kvp["PRODUCT"] : "FlashAir";
            cfg.Timezone = kvp.ContainsKey("TIMEZONE") ? int.Parse(kvp["TIMEZONE"]) : -32;
            cfg.Vendor = kvp.ContainsKey("VENDOR") ? kvp["VENDOR"] : "TOSHIBA";
            cfg.WLANAPMode = kvp.ContainsKey("WLANAPMODE") ? int.Parse(kvp["WLANAPMODE"]) : -1;
            cfg.DNSMode = kvp.ContainsKey("DNSMODE") ? int.Parse(kvp["DNSMODE"]) : 1;
            return cfg;
        }
    }
}
