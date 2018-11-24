namespace BFAOSTool.UIControls
{
    partial class MenuItemWa
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
            this.button = new System.Windows.Forms.Button();
            this.iconBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.iconBox)).BeginInit();
            this.SuspendLayout();
            // 
            // button
            // 
            this.button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button.FlatAppearance.BorderSize = 0;
            this.button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button.ForeColor = System.Drawing.Color.White;
            this.button.Location = new System.Drawing.Point(36, 0);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(296, 36);
            this.button.TabIndex = 1;
            this.button.Text = "Untitled";
            this.button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // iconBox
            // 
            this.iconBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.iconBox.Location = new System.Drawing.Point(0, 0);
            this.iconBox.Name = "iconBox";
            this.iconBox.Size = new System.Drawing.Size(36, 36);
            this.iconBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.iconBox.TabIndex = 0;
            this.iconBox.TabStop = false;
            // 
            // MenuItemWa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.button);
            this.Controls.Add(this.iconBox);
            this.Name = "MenuItemWa";
            this.Size = new System.Drawing.Size(332, 36);
            this.Load += new System.EventHandler(this.MenuItemWa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iconBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox iconBox;
        private System.Windows.Forms.Button button;
    }
}
