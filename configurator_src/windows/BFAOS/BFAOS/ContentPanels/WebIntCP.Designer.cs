namespace BFAOSTool.ContentPanels
{
    partial class WebIntCP
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
            this.themeGrp = new System.Windows.Forms.GroupBox();
            this.toolbar = new System.Windows.Forms.Panel();
            this.winTitle = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.themeList = new System.Windows.Forms.ListBox();
            this.addThemeBtn = new System.Windows.Forms.Button();
            this.removeBtn = new System.Windows.Forms.Button();
            this.exp = new System.Windows.Forms.Label();
            this.view.SuspendLayout();
            this.themeGrp.SuspendLayout();
            this.toolbar.SuspendLayout();
            this.SuspendLayout();
            // 
            // view
            // 
            this.view.Controls.Add(this.applyBtn);
            this.view.Controls.Add(this.themeGrp);
            this.view.Dock = System.Windows.Forms.DockStyle.Fill;
            this.view.Location = new System.Drawing.Point(0, 48);
            this.view.Name = "view";
            this.view.Padding = new System.Windows.Forms.Padding(90, 30, 90, 30);
            this.view.Size = new System.Drawing.Size(720, 528);
            this.view.TabIndex = 5;
            this.view.Paint += new System.Windows.Forms.PaintEventHandler(this.view_Paint);
            // 
            // applyBtn
            // 
            this.applyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.applyBtn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.applyBtn.ForeColor = System.Drawing.Color.White;
            this.applyBtn.Location = new System.Drawing.Point(479, 223);
            this.applyBtn.Name = "applyBtn";
            this.applyBtn.Size = new System.Drawing.Size(135, 30);
            this.applyBtn.TabIndex = 4;
            this.applyBtn.Text = "Apply Settings";
            this.applyBtn.UseVisualStyleBackColor = true;
            // 
            // themeGrp
            // 
            this.themeGrp.Controls.Add(this.exp);
            this.themeGrp.Controls.Add(this.removeBtn);
            this.themeGrp.Controls.Add(this.addThemeBtn);
            this.themeGrp.Controls.Add(this.themeList);
            this.themeGrp.Dock = System.Windows.Forms.DockStyle.Top;
            this.themeGrp.Font = new System.Drawing.Font("Tahoma", 11F);
            this.themeGrp.ForeColor = System.Drawing.Color.White;
            this.themeGrp.Location = new System.Drawing.Point(90, 30);
            this.themeGrp.Name = "themeGrp";
            this.themeGrp.Size = new System.Drawing.Size(540, 175);
            this.themeGrp.TabIndex = 1;
            this.themeGrp.TabStop = false;
            this.themeGrp.Text = "Installed Themes";
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
            this.winTitle.Text = "Web Interface Settings";
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
            // themeList
            // 
            this.themeList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(69)))), ((int)(((byte)(218)))));
            this.themeList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.themeList.ForeColor = System.Drawing.Color.White;
            this.themeList.FormattingEnabled = true;
            this.themeList.ItemHeight = 18;
            this.themeList.Location = new System.Drawing.Point(14, 24);
            this.themeList.Name = "themeList";
            this.themeList.Size = new System.Drawing.Size(405, 110);
            this.themeList.TabIndex = 0;
            // 
            // addThemeBtn
            // 
            this.addThemeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addThemeBtn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addThemeBtn.ForeColor = System.Drawing.Color.White;
            this.addThemeBtn.Location = new System.Drawing.Point(425, 24);
            this.addThemeBtn.Name = "addThemeBtn";
            this.addThemeBtn.Size = new System.Drawing.Size(85, 32);
            this.addThemeBtn.TabIndex = 5;
            this.addThemeBtn.Text = "Add";
            this.addThemeBtn.UseVisualStyleBackColor = true;
            this.addThemeBtn.Click += new System.EventHandler(this.addThemeBtn_Click);
            // 
            // removeBtn
            // 
            this.removeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeBtn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeBtn.ForeColor = System.Drawing.Color.White;
            this.removeBtn.Location = new System.Drawing.Point(425, 62);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(85, 32);
            this.removeBtn.TabIndex = 6;
            this.removeBtn.Text = "Remove";
            this.removeBtn.UseVisualStyleBackColor = true;
            this.removeBtn.Click += new System.EventHandler(this.removeBtn_Click);
            // 
            // exp
            // 
            this.exp.Location = new System.Drawing.Point(11, 142);
            this.exp.Name = "exp";
            this.exp.Size = new System.Drawing.Size(483, 26);
            this.exp.TabIndex = 7;
            this.exp.Text = "Note: Themes can be set from the settings page on the web interface!";
            // 
            // WebIntCP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(69)))), ((int)(((byte)(218)))));
            this.Controls.Add(this.view);
            this.Controls.Add(this.toolbar);
            this.Name = "WebIntCP";
            this.Size = new System.Drawing.Size(720, 576);
            this.Load += new System.EventHandler(this.WebIntCP_Load);
            this.view.ResumeLayout(false);
            this.themeGrp.ResumeLayout(false);
            this.toolbar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel view;
        private System.Windows.Forms.Button applyBtn;
        private System.Windows.Forms.GroupBox themeGrp;
        private System.Windows.Forms.Panel toolbar;
        private System.Windows.Forms.Label winTitle;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.ListBox themeList;
        private System.Windows.Forms.Button removeBtn;
        private System.Windows.Forms.Button addThemeBtn;
        private System.Windows.Forms.Label exp;
    }
}
