using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BFAOSToolCore.FlashAir
{
    public class FlashAirConfig
    {
        public bool Upload { get; set; }
        public string CIPath { get; set; }
        public FlashAirAppMode AppMode { get; set; }
        public NetCredentials FlashAirNetCreds { get; set; }
        public string FWVersion { get; set; }
        public string Vendor { get; set; }
        public string ProductName { get; set; }

        public FlashAirConfig()
        {

        }

        /// <summary>
        /// Save all changes to disk
        /// </summary>
        public void Save()
        {
            
        }
    }
}
