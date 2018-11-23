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
            }

            return new FlashAirConfig { };
        }
    }
}
