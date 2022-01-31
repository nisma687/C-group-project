
namespace GameStore
{
    partial class Register
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
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelAlreadyHaveAnAccount = new System.Windows.Forms.Label();
            this.showPassCheckbox1 = new System.Windows.Forms.CheckBox();
            this.registerButton = new System.Windows.Forms.Button();
            this.labelPassword = new System.Windows.Forms.Label();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.labelUsername = new System.Windows.Forms.Label();
            this.usernameBox = new System.Windows.Forms.TextBox();
            this.labelRegisterBanner = new System.Windows.Forms.Label();
            this.showPassCheckbox2 = new System.Windows.Forms.CheckBox();
            this.labelConfirmPassword = new System.Windows.Forms.Label();
            this.confirmPasswordBox = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelLogin.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelLogin.Location = new System.Drawing.Point(155, 408);
            this.labelLogin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(37, 13);
            this.labelLogin.TabIndex = 18;
            this.labelLogin.Text = "Log In";
            // 
            // labelAlreadyHaveAnAccount
            // 
            this.labelAlreadyHaveAnAccount.AutoSize = true;
            this.labelAlreadyHaveAnAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelAlreadyHaveAnAccount.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelAlreadyHaveAnAccount.Location = new System.Drawing.Point(114, 395);
            this.labelAlreadyHaveAnAccount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAlreadyHaveAnAccount.Name = "labelAlreadyHaveAnAccount";
            this.labelAlreadyHaveAnAccount.Size = new System.Drawing.Size(130, 13);
            this.labelAlreadyHaveAnAccount.TabIndex = 17;
            this.labelAlreadyHaveAnAccount.Text = "Already have an Account!";
            // 
            // showPassCheckbox1
            // 
            this.showPassCheckbox1.AutoSize = true;
            this.showPassCheckbox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.showPassCheckbox1.Location = new System.Drawing.Point(61, 229);
            this.showPassCheckbox1.Margin = new System.Windows.Forms.Padding(2);
            this.showPassCheckbox1.Name = "showPassCheckbox1";
            this.showPassCheckbox1.Size = new System.Drawing.Size(102, 17);
            this.showPassCheckbox1.TabIndex = 16;
            this.showPassCheckbox1.Text = "Show Password";
            this.showPassCheckbox1.UseVisualStyleBackColor = true;
            // 
            // registerButton
            // 
            this.registerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerButton.Location = new System.Drawing.Point(84, 357);
            this.registerButton.Margin = new System.Windows.Forms.Padding(2);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(189, 36);
            this.registerButton.TabIndex = 15;
            this.registerButton.Text = "Register";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelPassword.Location = new System.Drawing.Point(58, 180);
            this.labelPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(69, 17);
            this.labelPassword.TabIndex = 14;
            this.labelPassword.Text = "Password";
            // 
            // passwordBox
            // 
            this.passwordBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordBox.Location = new System.Drawing.Point(61, 199);
            this.passwordBox.Margin = new System.Windows.Forms.Padding(2);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(242, 26);
            this.passwordBox.TabIndex = 13;
            this.passwordBox.TextChanged += new System.EventHandler(this.passwordBox_TextChanged);
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelUsername.Location = new System.Drawing.Point(57, 123);
            this.labelUsername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(73, 17);
            this.labelUsername.TabIndex = 12;
            this.labelUsername.Text = "Username";
            // 
            // usernameBox
            // 
            this.usernameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.usernameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameBox.Location = new System.Drawing.Point(61, 142);
            this.usernameBox.Margin = new System.Windows.Forms.Padding(2);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.Size = new System.Drawing.Size(242, 26);
            this.usernameBox.TabIndex = 11;
            this.usernameBox.TextChanged += new System.EventHandler(this.usernameBox_TextChanged);
            // 
            // labelRegisterBanner
            // 
            this.labelRegisterBanner.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelRegisterBanner.AutoSize = true;
            this.labelRegisterBanner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelRegisterBanner.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegisterBanner.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelRegisterBanner.Location = new System.Drawing.Point(138, 27);
            this.labelRegisterBanner.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRegisterBanner.Name = "labelRegisterBanner";
            this.labelRegisterBanner.Size = new System.Drawing.Size(97, 30);
            this.labelRegisterBanner.TabIndex = 10;
            this.labelRegisterBanner.Text = "Register";
            this.labelRegisterBanner.Click += new System.EventHandler(this.labelRegisterBanner_Click);
            // 
            // showPassCheckbox2
            // 
            this.showPassCheckbox2.AutoSize = true;
            this.showPassCheckbox2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.showPassCheckbox2.Location = new System.Drawing.Point(61, 307);
            this.showPassCheckbox2.Margin = new System.Windows.Forms.Padding(2);
            this.showPassCheckbox2.Name = "showPassCheckbox2";
            this.showPassCheckbox2.Size = new System.Drawing.Size(102, 17);
            this.showPassCheckbox2.TabIndex = 21;
            this.showPassCheckbox2.Text = "Show Password";
            this.showPassCheckbox2.UseVisualStyleBackColor = true;
            // 
            // labelConfirmPassword
            // 
            this.labelConfirmPassword.AutoSize = true;
            this.labelConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConfirmPassword.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelConfirmPassword.Location = new System.Drawing.Point(57, 258);
            this.labelConfirmPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelConfirmPassword.Name = "labelConfirmPassword";
            this.labelConfirmPassword.Size = new System.Drawing.Size(121, 17);
            this.labelConfirmPassword.TabIndex = 20;
            this.labelConfirmPassword.Text = "Confirm Password";
            this.labelConfirmPassword.Click += new System.EventHandler(this.label6_Click);
            // 
            // confirmPasswordBox
            // 
            this.confirmPasswordBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.confirmPasswordBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmPasswordBox.Location = new System.Drawing.Point(61, 277);
            this.confirmPasswordBox.Margin = new System.Windows.Forms.Padding(2);
            this.confirmPasswordBox.Name = "confirmPasswordBox";
            this.confirmPasswordBox.Size = new System.Drawing.Size(242, 26);
            this.confirmPasswordBox.TabIndex = 19;
            this.confirmPasswordBox.TextChanged += new System.EventHandler(this.confirmPasswordBox_TextChanged);
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelEmail.Location = new System.Drawing.Point(58, 54);
            this.labelEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(42, 17);
            this.labelEmail.TabIndex = 23;
            this.labelEmail.Text = "Email";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmail.Location = new System.Drawing.Point(60, 84);
            this.textBoxEmail.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(242, 26);
            this.textBoxEmail.TabIndex = 22;
            this.textBoxEmail.TextChanged += new System.EventHandler(this.textBoxEmail_TextChanged);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(348, 446);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.showPassCheckbox2);
            this.Controls.Add(this.labelConfirmPassword);
            this.Controls.Add(this.confirmPasswordBox);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.labelAlreadyHaveAnAccount);
            this.Controls.Add(this.showPassCheckbox1);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.usernameBox);
            this.Controls.Add(this.labelRegisterBanner);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Register_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label labelAlreadyHaveAnAccount;
        private System.Windows.Forms.CheckBox showPassCheckbox1;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.TextBox usernameBox;
        private System.Windows.Forms.Label labelRegisterBanner;
        private System.Windows.Forms.CheckBox showPassCheckbox2;
        private System.Windows.Forms.Label labelConfirmPassword;
        private System.Windows.Forms.TextBox confirmPasswordBox;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox textBoxEmail;
    }
}