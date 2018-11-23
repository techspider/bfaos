using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BFAOSToolCore.FlashAir
{
    public struct NetCredentials
    {
        public string SSID { get; set; }
        public string KEY { get; set; }

        public NetCredentials(string ssid, string key)
        {
            SSID = ssid;
            KEY = key;
        }
    }
}
