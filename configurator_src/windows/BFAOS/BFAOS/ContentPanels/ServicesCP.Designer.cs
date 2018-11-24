namespace BFAOSTool.ContentPanels
{
    partial class ServicesCP
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
            this.applyBtn = new System.Windows.Forms.Button();
            this.webDavGrp = new System.Windows.Forms.GroupBox();
            this.servicesCheck = new System.Windows.Forms.CheckBox();
            this.toolbar = new System.Windows.Forms.Panel();
            this.winTitle = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.view.SuspendLayout();
            this.webDavGrp.SuspendLayout();
            this.toolbar.SuspendLayout();
            this.SuspendLayout();
            // 
            // view
            // 
            this.view.Controls.Add(this.applyBtn);
            this.view.Controls.Add(this.webDavGrp);
            this.view.Dock = System.Windows.Forms.DockStyle.Fill;
            this.view.Location = new System.Drawing.Point(0, 48);
            this.view.Name = "view";
            this.view.Padding = new System.Windows.Forms.Padding(90, 30, 90, 30);
            this.view.Size = new System.Drawing.Size(720, 528);
            this.view.TabIndex = 5;
            // 
            // applyBtn
            // 
            this.applyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.applyBtn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.applyBtn.ForeColor = System.Drawing.Color.White;
            this.applyBtn.Location = new System.Drawing.Point(479, 117);
            this.applyBtn.Name = "applyBtn";
            this.applyBtn.Size = new System.Drawing.Size(135, 30);
            this.applyBtn.TabIndex = 4;
            this.applyBtn.Text = "Apply Settings";
            this.applyBtn.UseVisualStyleBackColor = true;
            this.applyBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // webDavGrp
            // 
            this.webDavGrp.Controls.Add(this.servicesCheck);
            this.webDavGrp.Dock = System.Windows.Forms.DockStyle.Top;
            this.webDavGrp.Font = new System.Drawing.Font("Tahoma", 11F);
            this.webDavGrp.ForeColor = System.Drawing.Color.White;
            this.webDavGrp.Location = new System.Drawing.Point(90, 30);
            this.webDavGrp.Name = "webDavGrp";
            this.webDavGrp.Size = new System.Drawing.Size(540, 72);
            this.webDavGrp.TabIndex = 1;
            this.webDavGrp.TabStop = false;
            this.webDavGrp.Text = "WebDAV";
            // 
            // servicesCheck
            // 
            this.servicesCheck.AutoSize = true;
            this.servicesCheck.Location = new System.Drawing.Point(22, 32);
            this.servicesCheck.Name = "servicesCheck";
            this.servicesCheck.Size = new System.Drawing.Size(338, 22);
            this.servicesCheck.TabIndex = 6;
            this.servicesCheck.Text = "Enable WebDAV (authentication recommended)";
            this.servicesCheck.UseVisualStyleBackColor = true;
            // 
            // toolbar
            // 
            this.toolbar.Controls.Add(this.winTitle);
            this.toolbar.Controls.Add(this.backButton);
            this.toolbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.toolbar.Location = new System.Drawing.Point(0, 0);
            this.toolbar.Name = "toolbar";
            this.toolbar.Size = new System.Drawing.Size(720, 48);
            this.toolbar.TabIndex = 4;
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
            this.winTitle.Text = "Services";
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
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // ServicesCP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(69)))), ((int)(((byte)(218)))));
            this.Controls.Add(this.view);
            this.Controls.Add(this.toolbar);
            this.Name = "ServicesCP";
            this.Size = new System.Drawing.Size(720, 576);
            this.Load += new System.EventHandler(this.ServicesCP_Load);
            this.view.ResumeLayout(false);
            this.webDavGrp.ResumeLayout(false);
            this.webDavGrp.PerformLayout();
            this.toolbar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel view;
        private System.Windows.Forms.Button applyBtn;
        private System.Windows.Forms.GroupBox webDavGrp;
        private System.Windows.Forms.CheckBox servicesCheck;
        private System.Windows.Forms.Panel toolbar;
        private System.Windows.Forms.Label winTitle;
        private System.Windows.Forms.Button backButton;
    }
}
