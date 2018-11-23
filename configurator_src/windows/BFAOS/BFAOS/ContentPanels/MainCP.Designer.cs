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
            this.mainLogo = new System.Windows.Forms.PictureBox();
            this.viewDevInfoBtn = new BFAOSTool.UIControls.MenuItemWa();
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
            this.activityList.Location = new System.Drawing.Point(336, 32);
            this.activityList.Name = "activityList";
            this.activityList.Size = new System.Drawing.Size(332, 492);
            this.activityList.TabIndex = 2;
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
            // viewDevInfoBtn
            // 
            this.viewDevInfoBtn.BackColor = System.Drawing.Color.Transparent;
            this.viewDevInfoBtn.BtnText = "View Device Info";
            this.viewDevInfoBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.viewDevInfoBtn.Icon = global::BFAOSTool.Properties.Resources.baseline_info_white_36dp;
            this.viewDevInfoBtn.Location = new System.Drawing.Point(0, 0);
            this.viewDevInfoBtn.Name = "viewDevInfoBtn";
            this.viewDevInfoBtn.Size = new System.Drawing.Size(332, 36);
            this.viewDevInfoBtn.TabIndex = 0;
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
    }
}
