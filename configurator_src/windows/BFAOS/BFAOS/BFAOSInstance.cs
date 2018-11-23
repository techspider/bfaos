/*
bfaos (Better FlashAir OS) version 1.0

Copyright (C) mr_chainman (techspider) 2018.
https://github.com/techspider/bfaos
*/

using BFAOSToolCore.FlashAir;
using BFAOSToolCore.Util;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace BFAOSTool
{
    static class BFAOSInstance
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static MainUI MUI_Instance { get; set; }
        public static string Drive { get; set; } //Drive such as D:\
        public static FlashAirConfig DriveConfig { get; set; }

        [STAThread]
        static void Main()
        {
            //Locate FlashAir
            foreach(var drive in DriveInfo.GetDrives())
            {
                if ((drive.DriveType == DriveType.Removable) && File.Exists(drive.Name + "\\SD_WLAN\\CONFIG"))
                    Drive = drive.Name;
            }
            DriveConfig = ConfigParser.ParseConfig(Drive + "\\SD_WLAN\\CONFIG");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(MUI_Instance = new MainUI());
        }
    }
}
