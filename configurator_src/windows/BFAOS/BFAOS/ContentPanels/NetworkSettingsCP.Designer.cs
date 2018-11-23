namespace BFAOSTool.ContentPanels
{
    partial class NetworkSettingsCP
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
            this.view = new System.Windows.Forms.Panel();
            this.toolbar = new System.Windows.Forms.Panel();
            this.winTitle = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.basicSettingsGrp = new System.Windows.Forms.GroupBox();
            this.ssidLabel = new System.Windows.Forms.Label();
            this.ssidInput = new System.Windows.Forms.TextBox();
            this.keyInput = new System.Windows.Forms.TextBox();
            this.keyLabel = new System.Windows.Forms.Label();
            this.hostnameInput = new System.Windows.Forms.TextBox();
            this.hostnameLabel = new System.Windows.Forms.Label();
            this.optionsGrp = new System.Windows.Forms.GroupBox();
            this.ipsCheck = new System.Windows.Forms.CheckBox();
            this.dnsRedirCheck = new System.Windows.Forms.CheckBox();
            this.ipsGrp = new System.Windows.Forms.GroupBox();
            this.ips_passwd = new System.Windows.Forms.TextBox();
            this.ips_passwd_lbl = new System.Windows.Forms.Label();
            this.ips_ssid = new System.Windows.Forms.TextBox();
            this.ips_ssid_lbl = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.view.SuspendLayout();
            this.toolbar.SuspendLayout();
            this.basicSettingsGrp.SuspendLayout();
            this.optionsGrp.SuspendLayout();
            this.ipsGrp.SuspendLayout();
            this.SuspendLayout();
            // 
            // view
            // 
            this.view.Controls.Add(this.button1);
            this.view.Controls.Add(this.ipsGrp);
            this.view.Controls.Add(this.optionsGrp);
            this.view.Controls.Add(this.basicSettingsGrp);
            this.view.Dock = System.Windows.Forms.DockStyle.Fill;
            this.view.Location = new System.Drawing.Point(0, 48);
            this.view.Name = "view";
            this.view.Padding = new System.Windows.Forms.Padding(90, 30, 90, 30);
            this.view.Size = new System.Drawing.Size(720, 528);
            this.view.TabIndex = 3;
            // 
            // toolbar
            // 
            this.toolbar.Controls.Add(this.winTitle);
            this.toolbar.Controls.Add(this.backButton);
            this.toolbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.toolbar.Location = new System.Drawing.Point(0, 0);
            this.toolbar.Name = "toolbar";
            this.toolbar.Size = new System.Drawing.Size(720, 48);
            this.toolbar.TabIndex = 2;
            // 
            // winTitle
            // 
            this.winTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.winTitle.Font = new System.Drawing.Font("Tahoma", 14F);
            this.winTitle.ForeColor = System.Drawing.Color.White;
            this.winTitle.Location = new System.Drawing.Point(48, 0);
            this.winTitle.Name = "winTitle";
            this.winTitle.Size = new System.Drawing.Size(672, 48);
            this.winTitle.TabIndex = 1;
            this.winTitle.Text = "Network Settings";
            this.winTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // backButton
            // 
            this.backButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.backButton.FlatAppearance.BorderSize = 0;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Image = global::BFAOSTool.Properties.Resources.baseline_arrow_back_white_24dp;
            this.backButton.Location = new System.Drawing.Point(0, 0);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(48, 48);
            this.backButton.TabIndex = 0;
            this.backButton.UseVisualStyleBackColor = true;
            // 
            // basicSettingsGrp
            // 
            this.basicSettingsGrp.Controls.Add(this.hostnameInput);
            this.basicSettingsGrp.Controls.Add(this.hostnameLabel);
            this.basicSettingsGrp.Controls.Add(this.keyInput);
            this.basicSettingsGrp.Controls.Add(this.keyLabel);
            this.basicSettingsGrp.Controls.Add(this.ssidInput);
            this.basicSettingsGrp.Controls.Add(this.ssidLabel);
            this.basicSettingsGrp.Dock = System.Windows.Forms.DockStyle.Top;
            this.basicSettingsGrp.Font = new System.Drawing.Font("Tahoma", 11F);
            this.basicSettingsGrp.ForeColor = System.Drawing.Color.White;
            this.basicSettingsGrp.Location = new System.Drawing.Point(90, 30);
            this.basicSettingsGrp.Name = "basicSettingsGrp";
            this.basicSettingsGrp.Size = new System.Drawing.Size(540, 156);
            this.basicSettingsGrp.TabIndex = 0;
            this.basicSettingsGrp.TabStop = false;
            this.basicSettingsGrp.Text = "Basic Settings";
            // 
            // ssidLabel
            // 
            this.ssidLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(69)))), ((int)(((byte)(168)))));
            this.ssidLabel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ssidLabel.Location = new System.Drawing.Point(22, 34);
            this.ssidLabel.Name = "ssidLabel";
            this.ssidLabel.Size = new System.Drawing.Size(236, 24);
            this.ssidLabel.TabIndex = 0;
            this.ssidLabel.Text = "SSID";
            this.ssidLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ssidInput
            // 
            this.ssidInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ssidInput.Location = new System.Drawing.Point(264, 34);
            this.ssidInput.Name = "ssidInput";
            this.ssidInput.Size = new System.Drawing.Size(230, 25);
            this.ssidInput.TabIndex = 1;
            // 
            // keyInput
            // 
            this.keyInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.keyInput.Location = new System.Drawing.Point(264, 67);
            this.keyInput.Name = "keyInput";
            this.keyInput.Size = new System.Drawing.Size(230, 25);
            this.keyInput.TabIndex = 3;
            // 
            // keyLabel
            // 
            this.keyLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(69)))), ((int)(((byte)(168)))));
            this.keyLabel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.keyLabel.Location = new System.Drawing.Point(22, 67);
            this.keyLabel.Name = "keyLabel";
            this.keyLabel.Size = new System.Drawing.Size(236, 24);
            this.keyLabel.TabIndex = 2;
            this.keyLabel.Text = "Password";
            this.keyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // hostnameInput
            // 
            this.hostnameInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hostnameInput.Location = new System.Drawing.Point(264, 99);
            this.hostnameInput.Name = "hostnameInput";
            this.hostnameInput.Size = new System.Drawing.Size(230, 25);
            this.hostnameInput.TabIndex = 5;
            // 
            // hostnameLabel
            // 
            this.hostnameLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(69)))), ((int)(((byte)(168)))));
            this.hostnameLabel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hostnameLabel.Location = new System.Drawing.Point(22, 99);
            this.hostnameLabel.Name = "hostnameLabel";
            this.hostnameLabel.Size = new System.Drawing.Size(236, 24);
            this.hostnameLabel.TabIndex = 4;
            this.hostnameLabel.Text = "Hostname";
            this.hostnameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // optionsGrp
            // 
            this.optionsGrp.Controls.Add(this.dnsRedirCheck);
            this.optionsGrp.Controls.Add(this.ipsCheck);
            this.optionsGrp.Dock = System.Windows.Forms.DockStyle.Top;
            this.optionsGrp.Font = new System.Drawing.Font("Tahoma", 11F);
            this.optionsGrp.ForeColor = System.Drawing.Color.White;
            this.optionsGrp.Location = new System.Drawing.Point(90, 186);
            this.optionsGrp.Name = "optionsGrp";
            this.optionsGrp.Size = new System.Drawing.Size(540, 102);
            this.optionsGrp.TabIndex = 1;
            this.optionsGrp.TabStop = false;
            this.optionsGrp.Text = "Options";
            // 
            // ipsCheck
            // 
            this.ipsCheck.AutoSize = true;
            this.ipsCheck.Location = new System.Drawing.Point(25, 32);
            this.ipsCheck.Name = "ipsCheck";
            this.ipsCheck.Size = new System.Drawing.Size(212, 22);
            this.ipsCheck.TabIndex = 0;
            this.ipsCheck.Text = "Enable Internet Passthrough";
            this.ipsCheck.UseVisualStyleBackColor = true;
            this.ipsCheck.CheckedChanged += new System.EventHandler(this.ipsCheck_CheckedChanged);
            // 
            // dnsRedirCheck
            // 
            this.dnsRedirCheck.AutoSize = true;
            this.dnsRedirCheck.Location = new System.Drawing.Point(25, 60);
            this.dnsRedirCheck.Name = "dnsRedirCheck";
            this.dnsRedirCheck.Size = new System.Drawing.Size(447, 22);
            this.dnsRedirCheck.TabIndex = 1;
            this.dnsRedirCheck.Text = "DNS Redirect (e.g. redirect /hostname to /flashair automatically)";
            this.dnsRedirCheck.UseVisualStyleBackColor = true;
            // 
            // ipsGrp
            // 
            this.ipsGrp.Controls.Add(this.ips_passwd);
            this.ipsGrp.Controls.Add(this.ips_passwd_lbl);
            this.ipsGrp.Controls.Add(this.ips_ssid);
            this.ipsGrp.Controls.Add(this.ips_ssid_lbl);
            this.ipsGrp.Dock = System.Windows.Forms.DockStyle.Top;
            this.ipsGrp.Enabled = false;
            this.ipsGrp.Font = new System.Drawing.Font("Tahoma", 11F);
            this.ipsGrp.ForeColor = System.Drawing.Color.White;
            this.ipsGrp.Location = new System.Drawing.Point(90, 288);
            this.ipsGrp.Name = "ipsGrp";
            this.ipsGrp.Size = new System.Drawing.Size(540, 116);
            this.ipsGrp.TabIndex = 2;
            this.ipsGrp.TabStop = false;
            this.ipsGrp.Text = "Internet Passthrough Settings";
            // 
            // ips_passwd
            // 
            this.ips_passwd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ips_passwd.Location = new System.Drawing.Point(264, 67);
            this.ips_passwd.Name = "ips_passwd";
            this.ips_passwd.Size = new System.Drawing.Size(230, 25);
            this.ips_passwd.TabIndex = 3;
            // 
            // ips_passwd_lbl
            // 
            this.ips_passwd_lbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(69)))), ((int)(((byte)(168)))));
            this.ips_passwd_lbl.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ips_passwd_lbl.Location = new System.Drawing.Point(22, 67);
            this.ips_passwd_lbl.Name = "ips_passwd_lbl";
            this.ips_passwd_lbl.Size = new System.Drawing.Size(236, 24);
            this.ips_passwd_lbl.TabIndex = 2;
            this.ips_passwd_lbl.Text = "Password";
            this.ips_passwd_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ips_ssid
            // 
            this.ips_ssid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ips_ssid.Location = new System.Drawing.Point(264, 34);
            this.ips_ssid.Name = "ips_ssid";
            this.ips_ssid.Size = new System.Drawing.Size(230, 25);
            this.ips_ssid.TabIndex = 1;
            // 
            // ips_ssid_lbl
            // 
            this.ips_ssid_lbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(69)))), ((int)(((byte)(168)))));
            this.ips_ssid_lbl.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ips_ssid_lbl.Location = new System.Drawing.Point(22, 34);
            this.ips_ssid_lbl.Name = "ips_ssid_lbl";
            this.ips_ssid_lbl.Size = new System.Drawing.Size(236, 24);
            this.ips_ssid_lbl.TabIndex = 0;
            this.ips_ssid_lbl.Text = "SSID";
            this.ips_ssid_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(479, 419);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 30);
            this.button1.TabIndex = 3;
            this.button1.Text = "Apply Settings";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // NetworkSettingsCP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(69)))), ((int)(((byte)(218)))));
            this.Controls.Add(this.view);
            this.Controls.Add(this.toolbar);
            this.Name = "NetworkSettingsCP";
            this.Size = new System.Drawing.Size(720, 576);
            this.Load += new System.EventHandler(this.NetworkSettingsCP_Load);
            this.view.ResumeLayout(false);
            this.toolbar.ResumeLayout(false);
            this.basicSettingsGrp.ResumeLayout(false);
            this.basicSettingsGrp.PerformLayout();
            this.optionsGrp.ResumeLayout(false);
            this.optionsGrp.PerformLayout();
            this.ipsGrp.ResumeLayout(false);
            this.ipsGrp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel view;
        private System.Windows.Forms.Panel toolbar;
        private System.Windows.Forms.Label winTitle;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.GroupBox basicSettingsGrp;
        private System.Windows.Forms.TextBox ssidInput;
        private System.Windows.Forms.Label ssidLabel;
        private System.Windows.Forms.TextBox hostnameInput;
        private System.Windows.Forms.Label hostnameLabel;
        private System.Windows.Forms.TextBox keyInput;
        private System.Windows.Forms.Label keyLabel;
        private System.Windows.Forms.GroupBox optionsGrp;
        private System.Windows.Forms.CheckBox dnsRedirCheck;
        private System.Windows.Forms.CheckBox ipsCheck;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox ipsGrp;
        private System.Windows.Forms.TextBox ips_passwd;
        private System.Windows.Forms.Label ips_passwd_lbl;
        private System.Windows.Forms.TextBox ips_ssid;
        private System.Windows.Forms.Label ips_ssid_lbl;
    }
}
