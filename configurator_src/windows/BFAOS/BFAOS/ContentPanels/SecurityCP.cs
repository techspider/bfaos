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
    public partial class SecurityCP : UserControl
    {
        public SecurityCP()
        {
            InitializeComponent();
        }

        private void authCheck_CheckedChanged(object sender, EventArgs e)
        {
            userInput.Enabled = authCheck.Checked;
            passInput.Enabled = authCheck.Checked;
            unameLabel.Enabled = authCheck.Checked;
            passwdLabel.Enabled = authCheck.Checked;
        }

        private void SecurityCP_Load(object sender, EventArgs e)
        {
            if(BFAOSInstance.DriveConfig.AuthCredentials != null)
            {
                authCheck.Checked = true;
                BFAOSInstance.DriveConfig.AuthMode = 1;
                userInput.Text = BFAOSInstance.DriveConfig.AuthCredentials.Username;
                passInput.Text = BFAOSInstance.DriveConfig.AuthCredentials.Password;
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            BFAOSInstance.MUI_Instance.ShowContentPanel<MainCP>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(authCheck.Checked)
            {
                BFAOSInstance.DriveConfig.AuthMode = 1;
                BFAOSInstance.DriveConfig.AuthCredentials = new BFAOSToolCore.FlashAir.AuthCreds(userInput.Text, passInput.Text);
                BFAOSInstance.DriveConfig.Save(BFAOSInstance.Drive + "\\SD_WLAN\\CONFIG");
                BFAOSInstance.MUI_Instance.ShowContentPanel<MainCP>();
            }
        }
    }
}
