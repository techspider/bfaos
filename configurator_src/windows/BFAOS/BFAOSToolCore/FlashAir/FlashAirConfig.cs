using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BFAOSToolCore.FlashAir
{
    public class FlashAirConfig
    {
        public bool AllowFileUpload { get; set; }
        public string CIPath { get; set; }
        public FlashAirAppMode AppMode { get; set; }
        public NetCredentials FlashAirNetCreds { get; set; }
        public NetCredentials BridgeNetCreds { get; set; }
        public string FWVersion { get; set; }
        public string Vendor { get; set; }
        public string ProductName { get; set; }
        public string Hostname { get; set; } = "flashair";
        public List<string> DisabledCGIs { get; set; }
        public bool RequireAuth { get; set; }
        public AuthCreds AuthCredentials { get; set; }
        public int WLANAPMode { get; set; }

        /// <summary>
        /// Save all changes to disk
        /// </summary>
        public void Save()
        {
            
        }
    }
}
