using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BFAOSTool.UIControls
{
    public partial class MenuItemWa : UserControl
    {
        public new event EventHandler Click;
        public string BtnText { get { return button.Text; } set { button.Text = value; } }
        public Image Icon { get { return iconBox.Image; } set { iconBox.Image = value; } }

        public MenuItemWa()
        {
            InitializeComponent();
        }

        private void MenuItemWa_Load(object sender, EventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e)
        {
            if(Click != null) Click(sender, e);
        }
    }
}
