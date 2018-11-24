namespace BFAOSTool.ContentPanels
{
    partial class SecurityCP
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
            this.authGrp = new System.Windows.Forms.GroupBox();
            this.authCheck = new System.Windows.Forms.CheckBox();
            this.passInput = new System.Windows.Forms.TextBox();
            this.passwdLabel = new System.Windows.Forms.Label();
            this.userInput = new System.Windows.Forms.TextBox();
            this.unameLabel = new System.Windows.Forms.Label();
            this.toolbar = new System.Windows.Forms.Panel();
            this.winTitle = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.view.SuspendLayout();
            this.authGrp.SuspendLayout();
            this.toolbar.SuspendLayout();
            this.SuspendLayout();
            // 
            // view
            // 
            this.view.Controls.Add(this.applyBtn);
            this.view.Controls.Add(this.authGrp);
            this.view.Dock = System.Windows.Forms.DockStyle.Fill;
            this.view.Location = new System.Drawing.Point(0, 48);
            this.view.Name = "view";
            this.view.Padding = new System.Windows.Forms.Padding(90, 30, 90, 30);
            this.view.Size = new System.Drawing.Size(720, 528);
            this.view.TabIndex = 3;
            // 
            // applyBtn
            // 
            this.applyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.applyBtn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.applyBtn.ForeColor = System.Drawing.Color.White;
            this.applyBtn.Location = new System.Drawing.Point(479, 201);
            this.applyBtn.Name = "applyBtn";
            this.applyBtn.Size = new System.Drawing.Size(135, 30);
            this.applyBtn.TabIndex = 4;
            this.applyBtn.Text = "Apply Settings";
            this.applyBtn.UseVisualStyleBackColor = true;
            this.applyBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // authGrp
            // 
            this.authGrp.Controls.Add(this.authCheck);
            this.authGrp.Controls.Add(this.passInput);
            this.authGrp.Controls.Add(this.passwdLabel);
            this.authGrp.Controls.Add(this.userInput);
            this.authGrp.Controls.Add(this.unameLabel);
            this.authGrp.Dock = System.Windows.Forms.DockStyle.Top;
            this.authGrp.Font = new System.Drawing.Font("Tahoma", 11F);
            this.authGrp.ForeColor = System.Drawing.Color.White;
            this.authGrp.Location = new System.Drawing.Point(90, 30);
            this.authGrp.Name = "authGrp";
            this.authGrp.Size = new System.Drawing.Size(540, 156);
            this.authGrp.TabIndex = 1;
            this.authGrp.TabStop = false;
            this.authGrp.Text = "Authentication";
            // 
            // authCheck
            // 
            this.authCheck.AutoSize = true;
            this.authCheck.Location = new System.Drawing.Point(22, 32);
            this.authCheck.Name = "authCheck";
            this.authCheck.Size = new System.Drawing.Size(170, 22);
            this.authCheck.TabIndex = 6;
            this.authCheck.Text = "Require authentication";
            this.authCheck.UseVisualStyleBackColor = true;
            this.authCheck.CheckedChanged += new System.EventHandler(this.authCheck_CheckedChanged);
            // 
            // passInput
            // 
            this.passInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passInput.Enabled = false;
            this.passInput.Location = new System.Drawing.Point(264, 99);
            this.passInput.Name = "passInput";
            this.passInput.Size = new System.Drawing.Size(230, 25);
            this.passInput.TabIndex = 5;
            // 
            // passwdLabel
            // 
            this.passwdLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(69)))), ((int)(((byte)(168)))));
            this.passwdLabel.Enabled = false;
            this.passwdLabel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwdLabel.Location = new System.Drawing.Point(22, 99);
            this.passwdLabel.Name = "passwdLabel";
            this.passwdLabel.Size = new System.Drawing.Size(236, 24);
            this.passwdLabel.TabIndex = 4;
            this.passwdLabel.Text = "Password";
            this.passwdLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // userInput
            // 
            this.userInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userInput.Enabled = false;
            this.userInput.Location = new System.Drawing.Point(264, 67);
            this.userInput.Name = "userInput";
            this.userInput.Size = new System.Drawing.Size(230, 25);
            this.userInput.TabIndex = 3;
            // 
            // unameLabel
            // 
            this.unameLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(69)))), ((int)(((byte)(168)))));
            this.unameLabel.Enabled = false;
            this.unameLabel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unameLabel.Location = new System.Drawing.Point(22, 67);
            this.unameLabel.Name = "unameLabel";
            this.unameLabel.Size = new System.Drawing.Size(236, 24);
            this.unameLabel.TabIndex = 2;
            this.unameLabel.Text = "Username";
            this.unameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.winTitle.Text = "Security";
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
            // SecurityCP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(69)))), ((int)(((byte)(218)))));
            this.Controls.Add(this.view);
            this.Controls.Add(this.toolbar);
            this.Name = "SecurityCP";
            this.Size = new System.Drawing.Size(720, 576);
            this.Load += new System.EventHandler(this.SecurityCP_Load);
            this.view.ResumeLayout(false);
            this.authGrp.ResumeLayout(false);
            this.authGrp.PerformLayout();
            this.toolbar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel view;
        private System.Windows.Forms.Panel toolbar;
        private System.Windows.Forms.Label winTitle;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.GroupBox authGrp;
        private System.Windows.Forms.CheckBox authCheck;
        private System.Windows.Forms.TextBox passInput;
        private System.Windows.Forms.Label passwdLabel;
        private System.Windows.Forms.TextBox userInput;
        private System.Windows.Forms.Label unameLabel;
        private System.Windows.Forms.Button applyBtn;
    }
}
