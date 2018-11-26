using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BFAOSTool.ContentPanels
{
    public partial class NetworkSettingsCP : UserControl
    {
        public NetworkSettingsCP()
        {
            InitializeComponent();
        }

        private void NetworkSettingsCP_Load(object sender, EventArgs e)
        {
            ssidInput.Text = BFAOSInstance.DriveConfig.FlashAirNetCreds.SSID;
            keyInput.Text = BFAOSInstance.DriveConfig.FlashAirNetCreds.KEY;
            hostnameInput.Text = BFAOSInstance.DriveConfig.Hostname;
            if((BFAOSInstance.DriveConfig.AppMode == 6) || (BFAOSInstance.DriveConfig.AppMode == 3))
            {
                ipsCheck.Checked = true;
                ips_ssid.Text = BFAOSInstance.DriveConfig.BridgeNetCreds.SSID;
                ips_passwd.Text = BFAOSInstance.DriveConfig.BridgeNetCreds.KEY;
                ipsGrp.Enabled = true;
            }
            dnsRedirCheck.Checked = BFAOSToolCore.Util.Convert.IntToBool(BFAOSInstance.DriveConfig.DNSMode);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if((keyInput.Text.Trim()) == "" && (hostnameInput.Text.Trim() == ""))
            {
                return;
            }
            BFAOSInstance.DriveConfig.AppMode = 4;
            if(ipsCheck.Checked)
            {
                BFAOSInstance.DriveConfig.AppMode = 6;
                BFAOSInstance.DriveConfig.BridgeNetCreds = new BFAOSToolCore.FlashAir.NetCredentials(ips_ssid.Text, ips_passwd.Text);
            }
            BFAOSInstance.DriveConfig.Hostname = hostnameInput.Text;
            BFAOSInstance.DriveConfig.DNSMode = BFAOSToolCore.Util.Convert.BoolToInt(dnsRedirCheck.Checked);
            BFAOSInstance.DriveConfig.FlashAirNetCreds = new BFAOSToolCore.FlashAir.NetCredentials(ssidInput.Text, keyInput.Text);
            BFAOSInstance.DriveConfig.Save(BFAOSInstance.Drive + "\\SD_WLAN\\CONFIG");
            BFAOSInstance.MUI_Instance.ShowContentPanel<MainCP>();
        }

        private void ipsCheck_CheckedChanged(object sender, EventArgs e)
        {
            ipsGrp.Enabled = ipsCheck.Checked;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            BFAOSInstance.MUI_Instance.ShowContentPanel<MainCP>();
        }

        private void keyInput_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
