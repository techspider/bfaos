using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace BFAOSTool.ContentPanels
{
    public partial class DevInfoCP : UserControl
    {
        public DevInfoCP()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            BFAOSInstance.MUI_Instance.ShowContentPanel<MainCP>();
        }

        private void DevInfoCP_Load(object sender, EventArgs e)
        {
            Dictionary<string, string> infoList = new Dictionary<string, string>()
            {
                { "${fwVersion}", BFAOSInstance.DriveConfig.FWVersion },
                { "${hostname}", BFAOSInstance.DriveConfig.Hostname },
                { "${ssid}", BFAOSInstance.DriveConfig.FlashAirNetCreds.SSID },
                { "${bfaos_status}", Directory.Exists(BFAOSInstance.Drive + "\\private_bfaos") ? "Installed" : "Not Installed" }
            };
            foreach (var kv in infoList)
                info.Text = info.Text.Replace(kv.Key, kv.Value);
        }
    }
}
