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
    public partial class WebIntCP : UserControl
    {
        public WebIntCP()
        {
            InitializeComponent();
        }

        private void view_Paint(object sender, PaintEventArgs e)
        {

        }

        private void WebIntCP_Load(object sender, EventArgs e)
        {
            if(!Directory.Exists(BFAOSInstance.Drive + "\\private_bfaos"))
            {
                MessageBox.Show("The BFAOS web interface is not installed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                BFAOSInstance.MUI_Instance.ShowContentPanel<MainCP>();
            }
            if(!Directory.Exists(BFAOSInstance.Drive + "\\private_bfaos\\file_browser\\themes"))
            {
                MessageBox.Show("Your installation of the web interface is corrupted. Refer to the BFAOS github for reinstallation instructions.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                BFAOSInstance.MUI_Instance.ShowContentPanel<MainCP>();
            }
            foreach (var dir in Directory.GetDirectories(BFAOSInstance.Drive + "\\private_bfaos\\file_browser\\themes"))
                themeList.Items.Add(Path.GetFileName(dir));
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            BFAOSInstance.MUI_Instance.ShowContentPanel<MainCP>();
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            if(themeList.SelectedItem != null)
            {
                if (MessageBox.Show("Are you sure you want to delete this theme? Once deleted, it cannot be recovered!", "Delete Theme", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    Directory.Delete(BFAOSInstance.Drive + "\\private_bfaos\\file_browser\\themes\\" + themeList.SelectedItem.ToString(), true);
                    themeList.Items.Remove(themeList.SelectedItem);
                    MessageBox.Show("Theme deleted.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
