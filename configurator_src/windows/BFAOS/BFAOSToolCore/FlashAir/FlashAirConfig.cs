using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace BFAOSToolCore.FlashAir
{
    /// <summary>
    /// FlashAir configuration class
    /// </summary>
    public class FlashAirConfig
    {
        public bool AllowFileUpload { get; set; }
        public string CIPath { get; set; }
        public int AppMode { get; set; }
        public NetCredentials FlashAirNetCreds { get; set; }
        public NetCredentials BridgeNetCreds { get; set; }
        public string FWVersion { get; set; }
        public string Vendor { get; set; }
        public string ProductName { get; set; }
        public string Hostname { get; set; } = "flashair";
        public List<string> DisabledCGIs { get; set; }
        public AuthCreds AuthCredentials { get; set; }
        public int AuthMode { get; set; }
        public int WLANAPMode { get; set; }
        public int Timezone { get; set; } = -32;
        public int DNSMode { get; set; }
        public string CID { get; set; }
        public bool WebDav { get; set; }
        public const int LOCK = 1;
        public int AppAutotime { get; set; } = 300000;

        /// <summary>
        /// Save all changes to disk
        /// </summary>
        public void Save(string path)
        {
            string config = "[Vendor]\r\n\r\n";
            void appendCfg(string pname, object val)
            {
                config += pname + "=" + val.ToString() + "\r\n";
            }
            appendCfg("UPLOAD", Util.Convert.BoolToInt(AllowFileUpload));
            appendCfg("CIPATH", CIPath);
            appendCfg("APPMODE", AppMode);
            if (FlashAirNetCreds != null)
            {
                appendCfg("APPSSID", FlashAirNetCreds.SSID);
                appendCfg("APPNETWORKKEY", FlashAirNetCreds.KEY);
            }
            if (CID != null) appendCfg("CID", CID);
            else CID = "02544d53573038470750002a0200c201";
            if ((AppMode == 6) || (AppMode == 3))
            {
                appendCfg("BRGSSID", BridgeNetCreds.SSID);
                appendCfg("BRGNETWORKKEY", BridgeNetCreds.KEY);
            }
            appendCfg("LOCK", LOCK);
            appendCfg("VERSION", FWVersion);
            appendCfg("PRODUCT", ProductName);
            appendCfg("VENDOR", Vendor);
            appendCfg("APPNAME", Hostname);
            appendCfg("TIMEZONE", Timezone);
            appendCfg("WEBDAV", Util.Convert.BoolToInt(WebDav));
            appendCfg("APPAUTOTIME", AppAutotime);
            //TODO add disabledcgi support => if(DisabledCGIs != null)
            if(AuthCredentials != null)
            {
                appendCfg("HTTPDMODE", AuthMode);
                appendCfg("HTTPDUSER", AuthCredentials.Username);
                appendCfg("HTTPDPASS", AuthCredentials.Password);
            }
            if (WLANAPMode != -1)
                appendCfg("WLANAPMODE", WLANAPMode);
            var attributes = File.GetAttributes(path);
            if ((attributes & FileAttributes.Hidden) == FileAttributes.Hidden)
            {
                attributes &= ~FileAttributes.Hidden;
                File.SetAttributes(path, attributes);
            }
            if((attributes & FileAttributes.System) == FileAttributes.System)
            {
                attributes &= ~FileAttributes.System;
                File.SetAttributes(path, attributes);
            }
            File.WriteAllText(path, config);
            System.IO.File.SetAttributes(path, FileAttributes.Hidden & FileAttributes.System);
        }
    }
}
