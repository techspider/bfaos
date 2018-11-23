/*
bfaos (Better FlashAir OS) version 1.0

Copyright (C) mr_chainman (techspider) 2018.
https://github.com/techspider/bfaos
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BFAOSTool
{
    public partial class MainUI : Form
    {
        public MainUI()
        {
            InitializeComponent();
        }

        public void ShowContentPanel()
        {
            
        }

        private void MainUI_Load(object sender, EventArgs e)
        {
            this.Icon = SystemIcons.Application;
        }

        private void contentPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
