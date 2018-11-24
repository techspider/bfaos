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
    public partial class ServicesCP : UserControl
    {
        public ServicesCP()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            BFAOSInstance.MUI_Instance.ShowContentPanel<MainCP>();
        }

        private void ServicesCP_Load(object sender, EventArgs e)
        {
            servicesCheck.Checked = BFAOSInstance.DriveConfig.WebDav;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(servicesCheck.Checked)
            {
                BFAOSInstance.DriveConfig.WebDav = true;
                BFAOSInstance.DriveConfig.Save(BFAOSInstance.Drive + "\\SD_WLAN\\CONFIG");
                BFAOSInstance.MUI_Instance.ShowContentPanel<MainCP>();
            }
        }
    }
}
