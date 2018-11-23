namespace BFAOSTool.ContentPanels
{
    partial class DevInfoCP
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
            this.toolbar = new System.Windows.Forms.Panel();
            this.backButton = new System.Windows.Forms.Button();
            this.winTitle = new System.Windows.Forms.Label();
            this.view = new System.Windows.Forms.Panel();
            this.info = new System.Windows.Forms.Label();
            this.toolbar.SuspendLayout();
            this.view.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolbar
            // 
            this.toolbar.Controls.Add(this.winTitle);
            this.toolbar.Controls.Add(this.backButton);
            this.toolbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.toolbar.Location = new System.Drawing.Point(0, 0);
            this.toolbar.Name = "toolbar";
            this.toolbar.Size = new System.Drawing.Size(720, 48);
            this.toolbar.TabIndex = 0;
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
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
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
            this.winTitle.Text = "Device Information";
            this.winTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // view
            // 
            this.view.Controls.Add(this.info);
            this.view.Dock = System.Windows.Forms.DockStyle.Fill;
            this.view.Location = new System.Drawing.Point(0, 48);
            this.view.Name = "view";
            this.view.Padding = new System.Windows.Forms.Padding(30);
            this.view.Size = new System.Drawing.Size(720, 528);
            this.view.TabIndex = 1;
            // 
            // info
            // 
            this.info.Dock = System.Windows.Forms.DockStyle.Fill;
            this.info.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.info.ForeColor = System.Drawing.Color.White;
            this.info.Location = new System.Drawing.Point(30, 30);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(660, 468);
            this.info.TabIndex = 0;
            this.info.Text = "Firmware Version: ${fwVersion}\r\nHostname: ${hostname}\r\nDevice SSID: ${ssid}\r\nBFAO" +
    "S Install Status: ${bfaos_status}";
            // 
            // DevInfoCP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(69)))), ((int)(((byte)(218)))));
            this.Controls.Add(this.view);
            this.Controls.Add(this.toolbar);
            this.Name = "DevInfoCP";
            this.Size = new System.Drawing.Size(720, 576);
            this.Load += new System.EventHandler(this.DevInfoCP_Load);
            this.toolbar.ResumeLayout(false);
            this.view.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel toolbar;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label winTitle;
        private System.Windows.Forms.Panel view;
        private System.Windows.Forms.Label info;
    }
}
