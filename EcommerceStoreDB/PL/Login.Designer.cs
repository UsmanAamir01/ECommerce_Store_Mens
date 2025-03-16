namespace EcommerceStoreDB
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.chbLogin = new System.Windows.Forms.CheckBox();
            this.lblSignUpLink = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.picUserPassword = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picUserProfile = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.picbgLogo = new System.Windows.Forms.PictureBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.cmbRole = new System.Windows.Forms.ComboBox();
            this.lblRole = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cmbKey = new System.Windows.Forms.ComboBox();
            this.picKey = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.picUserPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUserProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbgLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picKey)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // chbLogin
            // 
            this.chbLogin.AutoSize = true;
            this.chbLogin.Location = new System.Drawing.Point(175, 455);
            this.chbLogin.Name = "chbLogin";
            this.chbLogin.Size = new System.Drawing.Size(28, 27);
            this.chbLogin.TabIndex = 104;
            this.chbLogin.UseVisualStyleBackColor = true;
            this.chbLogin.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // lblSignUpLink
            // 
            this.lblSignUpLink.AutoSize = true;
            this.lblSignUpLink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSignUpLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignUpLink.Location = new System.Drawing.Point(277, 655);
            this.lblSignUpLink.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSignUpLink.Name = "lblSignUpLink";
            this.lblSignUpLink.Size = new System.Drawing.Size(333, 29);
            this.lblSignUpLink.TabIndex = 103;
            this.lblSignUpLink.Text = "Not have an account? Sign Up";
            this.lblSignUpLink.Click += new System.EventHandler(this.lblSignUpLink_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(216, 378);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(508, 44);
            this.txtPassword.TabIndex = 101;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // txtUsername
            // 
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(216, 278);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUsername.Multiline = true;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(508, 39);
            this.txtUsername.TabIndex = 100;
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(27)))), ((int)(((byte)(96)))));
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLogin.Location = new System.Drawing.Point(167, 595);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(556, 55);
            this.btnLogin.TabIndex = 99;
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Location = new System.Drawing.Point(175, 427);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(555, 3);
            this.panel2.TabIndex = 98;
            // 
            // picUserPassword
            // 
            this.picUserPassword.Image = ((System.Drawing.Image)(resources.GetObject("picUserPassword.Image")));
            this.picUserPassword.Location = new System.Drawing.Point(170, 378);
            this.picUserPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picUserPassword.Name = "picUserPassword";
            this.picUserPassword.Size = new System.Drawing.Size(38, 39);
            this.picUserPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picUserPassword.TabIndex = 97;
            this.picUserPassword.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(170, 327);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(555, 3);
            this.panel1.TabIndex = 96;
            // 
            // picUserProfile
            // 
            this.picUserProfile.Image = ((System.Drawing.Image)(resources.GetObject("picUserProfile.Image")));
            this.picUserProfile.Location = new System.Drawing.Point(170, 278);
            this.picUserProfile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picUserProfile.Name = "picUserProfile";
            this.picUserProfile.Size = new System.Drawing.Size(38, 39);
            this.picUserProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picUserProfile.TabIndex = 95;
            this.picUserProfile.TabStop = false;
            this.picUserProfile.Click += new System.EventHandler(this.picUserProfile_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(350, 184);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 71);
            this.label3.TabIndex = 94;
            this.label3.Text = "LOGIN";
            // 
            // picLogo
            // 
            this.picLogo.BackColor = System.Drawing.Color.White;
            this.picLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(374, 20);
            this.picLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(150, 150);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 113;
            this.picLogo.TabStop = false;
            // 
            // picbgLogo
            // 
            this.picbgLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(27)))), ((int)(((byte)(96)))));
            this.picbgLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picbgLogo.Location = new System.Drawing.Point(362, 7);
            this.picbgLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picbgLogo.Name = "picbgLogo";
            this.picbgLogo.Size = new System.Drawing.Size(175, 175);
            this.picbgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbgLogo.TabIndex = 114;
            this.picbgLogo.TabStop = false;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(210, 453);
            this.lblFirstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(191, 31);
            this.lblFirstName.TabIndex = 115;
            this.lblFirstName.Text = "Show Password";
            // 
            // cmbRole
            // 
            this.cmbRole.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRole.FormattingEnabled = true;
            this.cmbRole.Location = new System.Drawing.Point(167, 519);
            this.cmbRole.Name = "cmbRole";
            this.cmbRole.Size = new System.Drawing.Size(557, 33);
            this.cmbRole.TabIndex = 118;
            this.cmbRole.SelectedIndexChanged += new System.EventHandler(this.cmbRole_SelectedIndexChanged);
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRole.Location = new System.Drawing.Point(164, 485);
            this.lblRole.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(73, 31);
            this.lblRole.TabIndex = 117;
            this.lblRole.Text = "ROLE";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel4.Location = new System.Drawing.Point(175, 560);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(555, 3);
            this.panel4.TabIndex = 116;
            // 
            // cmbKey
            // 
            this.cmbKey.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKey.FormattingEnabled = true;
            this.cmbKey.Location = new System.Drawing.Point(658, 386);
            this.cmbKey.Name = "cmbKey";
            this.cmbKey.Size = new System.Drawing.Size(65, 33);
            this.cmbKey.TabIndex = 120;
            // 
            // picKey
            // 
            this.picKey.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picKey.Image = ((System.Drawing.Image)(resources.GetObject("picKey.Image")));
            this.picKey.Location = new System.Drawing.Point(658, 389);
            this.picKey.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picKey.Name = "picKey";
            this.picKey.Size = new System.Drawing.Size(36, 33);
            this.picKey.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picKey.TabIndex = 121;
            this.picKey.TabStop = false;
            this.picKey.Click += new System.EventHandler(this.picKey_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.Controls.Add(this.picKey);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.picLogo);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.cmbRole);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.txtUsername);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.lblSignUpLink);
            this.panel3.Controls.Add(this.picbgLogo);
            this.panel3.Controls.Add(this.lblRole);
            this.panel3.Controls.Add(this.btnLogin);
            this.panel3.Controls.Add(this.picUserProfile);
            this.panel3.Controls.Add(this.picUserPassword);
            this.panel3.Controls.Add(this.chbLogin);
            this.panel3.Controls.Add(this.lblFirstName);
            this.panel3.Controls.Add(this.txtPassword);
            this.panel3.Controls.Add(this.cmbKey);
            this.panel3.Location = new System.Drawing.Point(252, -7);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(869, 692);
            this.panel3.TabIndex = 122;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1340, 697);
            this.Controls.Add(this.panel3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.Resize += new System.EventHandler(this.Login_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.picUserPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUserProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbgLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picKey)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.CheckBox chbLogin;
        private System.Windows.Forms.Label lblSignUpLink;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox picUserPassword;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picUserProfile;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.PictureBox picbgLogo;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.ComboBox cmbRole;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox cmbKey;
        private System.Windows.Forms.PictureBox picKey;
        private System.Windows.Forms.Panel panel3;
    }
}