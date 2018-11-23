﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BFAOSTool.ContentPanels
{
    public partial class MainCP : UserControl
    {
        public MainCP()
        {
            InitializeComponent();
        }

        private void MainCP_Load(object sender, EventArgs e)
        {
            cdriveLabel.Text = cdriveLabel.Text.Replace("${drive}", BFAOSInstance.Drive);
        }

        private void viewDevInfoBtn_Load(object sender, EventArgs e)
        {

        }

        private void viewDevInfoBtn_Click(object sender, EventArgs e)
        {
            BFAOSInstance.MUI_Instance.ShowContentPanel<DevInfoCP>();
        }
    }
}
