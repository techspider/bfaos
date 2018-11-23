/*
bfaos (Better FlashAir OS) version 1.0

Copyright (C) mr_chainman (techspider) 2018.
https://github.com/techspider/bfaos
*/

using System;
using System.Collections.Generic;
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
        
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(MUI_Instance = new MainUI());
        }
    }
}
