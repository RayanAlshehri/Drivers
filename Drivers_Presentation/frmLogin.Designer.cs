namespace Drivers_Project
{
    partial class frmLogin
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
            this.tbNationalNumber = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.ibLockIcon = new FontAwesome.Sharp.IconButton();
            this.btnLogin = new System.Windows.Forms.Button();
            this.cbRememberMe = new System.Windows.Forms.CheckBox();
            this.ibtnClose = new FontAwesome.Sharp.IconButton();
            this.btnEnter = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.ibtnCheck = new FontAwesome.Sharp.IconButton();
            this.tbConfirmPassword = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbNationalNumber
            // 
            this.tbNationalNumber.Location = new System.Drawing.Point(252, 178);
            this.tbNationalNumber.MaxLength = 5;
            this.tbNationalNumber.Name = "tbNationalNumber";
            this.tbNationalNumber.Size = new System.Drawing.Size(158, 20);
            this.tbNationalNumber.TabIndex = 0;
            this.tbNationalNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNationalNumber_KeyPress);
            // 
            // tbPassword
            // 
            this.tbPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPassword.Location = new System.Drawing.Point(252, 229);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(158, 20);
            this.tbPassword.TabIndex = 1;
            this.tbPassword.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(37, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "National Number:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblPassword.Location = new System.Drawing.Point(37, 230);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(91, 20);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Password:";
            this.lblPassword.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(147, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(255, 74);
            this.label3.TabIndex = 4;
            this.label3.Text = "   Welcome to\r\n Drivers System";
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.Transparent;
            this.iconButton1.Enabled = false;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 24;
            this.iconButton1.Location = new System.Drawing.Point(209, 175);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(30, 24);
            this.iconButton1.TabIndex = 5;
            this.iconButton1.UseVisualStyleBackColor = false;
            // 
            // ibLockIcon
            // 
            this.ibLockIcon.BackColor = System.Drawing.Color.Transparent;
            this.ibLockIcon.Enabled = false;
            this.ibLockIcon.FlatAppearance.BorderSize = 0;
            this.ibLockIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibLockIcon.IconChar = FontAwesome.Sharp.IconChar.Lock;
            this.ibLockIcon.IconColor = System.Drawing.Color.White;
            this.ibLockIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibLockIcon.IconSize = 24;
            this.ibLockIcon.Location = new System.Drawing.Point(209, 226);
            this.ibLockIcon.Name = "ibLockIcon";
            this.ibLockIcon.Size = new System.Drawing.Size(30, 24);
            this.ibLockIcon.TabIndex = 6;
            this.ibLockIcon.UseVisualStyleBackColor = false;
            this.ibLockIcon.Visible = false;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(55)))));
            this.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(55)))));
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnLogin.Location = new System.Drawing.Point(211, 393);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(179, 38);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = " Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Visible = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // cbRememberMe
            // 
            this.cbRememberMe.AutoSize = true;
            this.cbRememberMe.BackColor = System.Drawing.Color.Transparent;
            this.cbRememberMe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRememberMe.ForeColor = System.Drawing.Color.Gainsboro;
            this.cbRememberMe.Location = new System.Drawing.Point(215, 336);
            this.cbRememberMe.Name = "cbRememberMe";
            this.cbRememberMe.Size = new System.Drawing.Size(144, 24);
            this.cbRememberMe.TabIndex = 3;
            this.cbRememberMe.Text = "Remember Me";
            this.cbRememberMe.UseVisualStyleBackColor = false;
            this.cbRememberMe.Visible = false;
            // 
            // ibtnClose
            // 
            this.ibtnClose.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ibtnClose.FlatAppearance.BorderSize = 0;
            this.ibtnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(55)))));
            this.ibtnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(55)))));
            this.ibtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnClose.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.ibtnClose.IconColor = System.Drawing.Color.Gainsboro;
            this.ibtnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnClose.IconSize = 35;
            this.ibtnClose.Location = new System.Drawing.Point(475, 12);
            this.ibtnClose.Name = "ibtnClose";
            this.ibtnClose.Size = new System.Drawing.Size(41, 33);
            this.ibtnClose.TabIndex = 8;
            this.ibtnClose.UseVisualStyleBackColor = true;
            this.ibtnClose.Click += new System.EventHandler(this.ibtnClose_Click);
            // 
            // btnEnter
            // 
            this.btnEnter.BackColor = System.Drawing.Color.Transparent;
            this.btnEnter.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEnter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(55)))));
            this.btnEnter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(55)))));
            this.btnEnter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnter.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnEnter.Location = new System.Drawing.Point(211, 393);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(179, 38);
            this.btnEnter.TabIndex = 4;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = false;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.Transparent;
            this.btnRegister.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnRegister.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(55)))));
            this.btnRegister.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(55)))));
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnRegister.Location = new System.Drawing.Point(211, 393);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(179, 38);
            this.btnRegister.TabIndex = 6;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Visible = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmPassword.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblConfirmPassword.Location = new System.Drawing.Point(37, 282);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(158, 20);
            this.lblConfirmPassword.TabIndex = 10;
            this.lblConfirmPassword.Text = "Confirm Password:";
            this.lblConfirmPassword.Visible = false;
            // 
            // ibtnCheck
            // 
            this.ibtnCheck.BackColor = System.Drawing.Color.Transparent;
            this.ibtnCheck.Enabled = false;
            this.ibtnCheck.FlatAppearance.BorderSize = 0;
            this.ibtnCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnCheck.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.ibtnCheck.IconColor = System.Drawing.Color.White;
            this.ibtnCheck.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnCheck.IconSize = 24;
            this.ibtnCheck.Location = new System.Drawing.Point(209, 279);
            this.ibtnCheck.Name = "ibtnCheck";
            this.ibtnCheck.Size = new System.Drawing.Size(30, 24);
            this.ibtnCheck.TabIndex = 11;
            this.ibtnCheck.UseVisualStyleBackColor = false;
            this.ibtnCheck.Visible = false;
            // 
            // tbConfirmPassword
            // 
            this.tbConfirmPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbConfirmPassword.Location = new System.Drawing.Point(252, 279);
            this.tbConfirmPassword.Name = "tbConfirmPassword";
            this.tbConfirmPassword.PasswordChar = '*';
            this.tbConfirmPassword.Size = new System.Drawing.Size(158, 20);
            this.tbConfirmPassword.TabIndex = 2;
            this.tbConfirmPassword.Visible = false;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBack.Enabled = false;
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(55)))));
            this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(55)))));
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnBack.Location = new System.Drawing.Point(115, 393);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(90, 38);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmLogin
            // 
            this.AcceptButton = this.btnEnter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(55)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btnBack;
            this.ClientSize = new System.Drawing.Size(528, 474);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.tbConfirmPassword);
            this.Controls.Add(this.ibtnCheck);
            this.Controls.Add(this.lblConfirmPassword);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.ibtnClose);
            this.Controls.Add(this.cbRememberMe);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.ibLockIcon);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbNationalNumber);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNationalNumber;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton ibLockIcon;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.CheckBox cbRememberMe;
        private FontAwesome.Sharp.IconButton ibtnClose;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label lblConfirmPassword;
        private FontAwesome.Sharp.IconButton ibtnCheck;
        private System.Windows.Forms.TextBox tbConfirmPassword;
        private System.Windows.Forms.Button btnBack;
    }
}