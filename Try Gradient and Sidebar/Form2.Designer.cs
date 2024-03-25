namespace Try_Gradient_and_Sidebar
{
    partial class Form2
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.erpLogo = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.htaLogo = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.TextboxUsername = new ReaLTaiizor.Controls.DungeonTextBox();
            this.TextboxPassword = new ReaLTaiizor.Controls.DungeonTextBox();
            this.buttonLogin = new ReaLTaiizor.Controls.DungeonButtonLeft();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.erpLogo)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.htaLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // erpLogo
            // 
            this.erpLogo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.erpLogo.Image = ((System.Drawing.Image)(resources.GetObject("erpLogo.Image")));
            this.erpLogo.Location = new System.Drawing.Point(36, 107);
            this.erpLogo.Name = "erpLogo";
            this.erpLogo.Size = new System.Drawing.Size(275, 239);
            this.erpLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.erpLogo.TabIndex = 1;
            this.erpLogo.TabStop = false;
            this.erpLogo.Click += new System.EventHandler(this.erpLogo_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel2.Controls.Add(this.erpLogo);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(345, 423);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // htaLogo
            // 
            this.htaLogo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.htaLogo.Image = ((System.Drawing.Image)(resources.GetObject("htaLogo.Image")));
            this.htaLogo.Location = new System.Drawing.Point(110, 79);
            this.htaLogo.Name = "htaLogo";
            this.htaLogo.Size = new System.Drawing.Size(150, 54);
            this.htaLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.htaLogo.TabIndex = 0;
            this.htaLogo.TabStop = false;
            this.htaLogo.Click += new System.EventHandler(this.htaLogo_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(84, 181);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 30);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(88, 223);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(21, 30);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 2;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // TextboxUsername
            // 
            this.TextboxUsername.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.TextboxUsername.BackColor = System.Drawing.Color.Transparent;
            this.TextboxUsername.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.TextboxUsername.EdgeColor = System.Drawing.Color.White;
            this.TextboxUsername.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextboxUsername.ForeColor = System.Drawing.Color.DimGray;
            this.TextboxUsername.Location = new System.Drawing.Point(142, 183);
            this.TextboxUsername.MaxLength = 32767;
            this.TextboxUsername.Multiline = false;
            this.TextboxUsername.Name = "TextboxUsername";
            this.TextboxUsername.ReadOnly = false;
            this.TextboxUsername.Size = new System.Drawing.Size(135, 30);
            this.TextboxUsername.TabIndex = 3;
            this.TextboxUsername.Text = "Username";
            this.TextboxUsername.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.TextboxUsername.UseSystemPasswordChar = false;
            this.TextboxUsername.TextChanged += new System.EventHandler(this.TextboxUsername_TextChanged);
            // 
            // TextboxPassword
            // 
            this.TextboxPassword.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.TextboxPassword.BackColor = System.Drawing.Color.Transparent;
            this.TextboxPassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.TextboxPassword.EdgeColor = System.Drawing.Color.White;
            this.TextboxPassword.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.TextboxPassword.ForeColor = System.Drawing.Color.DimGray;
            this.TextboxPassword.Location = new System.Drawing.Point(142, 225);
            this.TextboxPassword.MaxLength = 32767;
            this.TextboxPassword.Multiline = false;
            this.TextboxPassword.Name = "TextboxPassword";
            this.TextboxPassword.ReadOnly = false;
            this.TextboxPassword.Size = new System.Drawing.Size(135, 30);
            this.TextboxPassword.TabIndex = 4;
            this.TextboxPassword.Text = "Password";
            this.TextboxPassword.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.TextboxPassword.UseSystemPasswordChar = false;
            this.TextboxPassword.TextChanged += new System.EventHandler(this.TextboxPassword_TextChanged);
            this.TextboxPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxPassword_KeyDown);
            // 
            // buttonLogin
            // 
            this.buttonLogin.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonLogin.BackColor = System.Drawing.Color.Transparent;
            this.buttonLogin.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.buttonLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLogin.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.buttonLogin.Image = null;
            this.buttonLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLogin.InactiveColorA = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.buttonLogin.InactiveColorB = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(237)))), ((int)(((byte)(236)))));
            this.buttonLogin.Location = new System.Drawing.Point(84, 269);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.PressedColorA = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.buttonLogin.PressedColorB = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.buttonLogin.PressedContourColorA = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(167)))), ((int)(((byte)(167)))));
            this.buttonLogin.PressedContourColorB = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(167)))), ((int)(((byte)(167)))));
            this.buttonLogin.Size = new System.Drawing.Size(193, 28);
            this.buttonLogin.TabIndex = 6;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.TextAlignment = System.Drawing.StringAlignment.Center;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel1.BackColor = System.Drawing.Color.DarkRed;
            this.panel1.Controls.Add(this.buttonLogin);
            this.panel1.Controls.Add(this.TextboxPassword);
            this.panel1.Controls.Add(this.TextboxUsername);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.htaLogo);
            this.panel1.Location = new System.Drawing.Point(345, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(345, 423);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(674, 423);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Form";
            ((System.ComponentModel.ISupportInitialize)(this.erpLogo)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.htaLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox erpLogo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox htaLogo;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private ReaLTaiizor.Controls.DungeonTextBox TextboxUsername;
        private ReaLTaiizor.Controls.DungeonTextBox TextboxPassword;
        private ReaLTaiizor.Controls.DungeonButtonLeft buttonLogin;
        private System.Windows.Forms.Panel panel1;
    }
}