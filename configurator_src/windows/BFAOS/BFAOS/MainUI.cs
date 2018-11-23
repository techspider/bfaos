/*
bfaos (Better FlashAir OS) version 1.0

Copyright (C) mr_chainman (techspider) 2018.
https://github.com/techspider/bfaos
*/

using BFAOSTool.ContentPanels;
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

        public void ShowContentPanel<T>()
        {
            var panel = Activator.CreateInstance(typeof(T)) as Control;
            contentPanel.Controls.Clear();
            panel.Dock = DockStyle.Fill;
            contentPanel.Controls.Add(panel);
        }

        private void MainUI_Load(object sender, EventArgs e)
        {
            ShowContentPanel<MainCP>();
        }

        private void contentPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
