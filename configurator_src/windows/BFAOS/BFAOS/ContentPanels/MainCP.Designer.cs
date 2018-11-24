namespace BFAOSTool.ContentPanels
{
    partial class MainCP
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cdriveLabel = new System.Windows.Forms.Label();
            this.activityList = new System.Windows.Forms.Panel();
            this.servicesBtn = new BFAOSTool.UIControls.MenuItemWa();
            this.viewDevInfoBtn = new BFAOSTool.UIControls.MenuItemWa();
            this.securitySettingsBtn = new BFAOSTool.UIControls.MenuItemWa();
            this.networkSettingsBtn = new BFAOSTool.UIControls.MenuItemWa();
            this.mainLogo = new System.Windows.Forms.PictureBox();
            this.activityList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // cdriveLabel
            // 
            this.cdriveLabel.AutoSize = true;
            this.cdriveLabel.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cdriveLabel.ForeColor = System.Drawing.Color.White;
            this.cdriveLabel.Location = new System.Drawing.Point(57, 137);
            this.cdriveLabel.Name = "cdriveLabel";
            this.cdriveLabel.Size = new System.Drawing.Size(204, 23);
            this.cdriveLabel.TabIndex = 1;
            this.cdriveLabel.Text = "Current Drive: ${drive}";
            // 
            // activityList
            // 
            this.activityList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.activityList.AutoScroll = true;
            this.activityList.Controls.Add(this.viewDevInfoBtn);
            this.activityList.Controls.Add(this.servicesBtn);
            this.activityList.Controls.Add(this.securitySettingsBtn);
            this.activityList.Controls.Add(this.networkSettingsBtn);
            this.activityList.Location = new System.Drawing.Point(336, 32);
            this.activityList.Name = "activityList";
            this.activityList.Size = new System.Drawing.Size(332, 492);
            this.activityList.TabIndex = 2;
            // 
            // servicesBtn
            // 
            this.servicesBtn.BackColor = System.Drawing.Color.Transparent;
            this.servicesBtn.BtnText = "Services";
            this.servicesBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.servicesBtn.Icon = global::BFAOSTool.Properties.Resources.baseline_star_white_24dp;
            this.servicesBtn.Location = new System.Drawing.Point(0, 72);
            this.servicesBtn.Name = "servicesBtn";
            this.servicesBtn.Size = new System.Drawing.Size(332, 36);
            this.servicesBtn.TabIndex = 3;
            this.servicesBtn.Click += new System.EventHandler(this.servicesBtn_Click);
            this.servicesBtn.Load += new System.EventHandler(this.servicesBtn_Load);
            // 
            // viewDevInfoBtn
            // 
            this.viewDevInfoBtn.BackColor = System.Drawing.Color.Transparent;
            this.viewDevInfoBtn.BtnText = "View Device Info";
            this.viewDevInfoBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.viewDevInfoBtn.Icon = global::BFAOSTool.Properties.Resources.baseline_info_white_24dp;
            this.viewDevInfoBtn.Location = new System.Drawing.Point(0, 108);
            this.viewDevInfoBtn.Name = "viewDevInfoBtn";
            this.viewDevInfoBtn.Size = new System.Drawing.Size(332, 36);
            this.viewDevInfoBtn.TabIndex = 0;
            this.viewDevInfoBtn.Click += new System.EventHandler(this.viewDevInfoBtn_Click);
            this.viewDevInfoBtn.Load += new System.EventHandler(this.viewDevInfoBtn_Load);
            // 
            // securitySettingsBtn
            // 
            this.securitySettingsBtn.BackColor = System.Drawing.Color.Transparent;
            this.securitySettingsBtn.BtnText = "Security";
            this.securitySettingsBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.securitySettingsBtn.Icon = global::BFAOSTool.Properties.Resources.baseline_security_white_24dp;
            this.securitySettingsBtn.Location = new System.Drawing.Point(0, 36);
            this.securitySettingsBtn.Name = "securitySettingsBtn";
            this.securitySettingsBtn.Size = new System.Drawing.Size(332, 36);
            this.securitySettingsBtn.TabIndex = 2;
            this.securitySettingsBtn.Click += new System.EventHandler(this.securitySettingsBtn_Click);
            this.securitySettingsBtn.Load += new System.EventHandler(this.menuItemWa1_Load);
            // 
            // networkSettingsBtn
            // 
            this.networkSettingsBtn.BackColor = System.Drawing.Color.Transparent;
            this.networkSettingsBtn.BtnText = "Network Settings";
            this.networkSettingsBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.networkSettingsBtn.Icon = global::BFAOSTool.Properties.Resources.baseline_network_wifi_white_24dp;
            this.networkSettingsBtn.Location = new System.Drawing.Point(0, 0);
            this.networkSettingsBtn.Name = "networkSettingsBtn";
            this.networkSettingsBtn.Size = new System.Drawing.Size(332, 36);
            this.networkSettingsBtn.TabIndex = 1;
            this.networkSettingsBtn.Click += new System.EventHandler(this.networkSettingsBtn_Click);
            this.networkSettingsBtn.Load += new System.EventHandler(this.networkSettingsBtn_Load);
            // 
            // mainLogo
            // 
            this.mainLogo.Image = global::BFAOSTool.Properties.Resources.logo;
            this.mainLogo.Location = new System.Drawing.Point(32, 32);
            this.mainLogo.Name = "mainLogo";
            this.mainLogo.Size = new System.Drawing.Size(256, 100);
            this.mainLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.mainLogo.TabIndex = 0;
            this.mainLogo.TabStop = false;
            // 
            // MainCP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(69)))), ((int)(((byte)(218)))));
            this.Controls.Add(this.activityList);
            this.Controls.Add(this.cdriveLabel);
            this.Controls.Add(this.mainLogo);
            this.Name = "MainCP";
            this.Size = new System.Drawing.Size(720, 576);
            this.Load += new System.EventHandler(this.MainCP_Load);
            this.activityList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox mainLogo;
        private System.Windows.Forms.Label cdriveLabel;
        private System.Windows.Forms.Panel activityList;
        private UIControls.MenuItemWa viewDevInfoBtn;
        private UIControls.MenuItemWa networkSettingsBtn;
        private UIControls.MenuItemWa securitySettingsBtn;
        private UIControls.MenuItemWa servicesBtn;
    }
}
