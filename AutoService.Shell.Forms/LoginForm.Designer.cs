namespace AutoService.Shell.Forms
{
    partial class LoginForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.signInPanel = new System.Windows.Forms.Panel();
            this.forgotPasswordButton = new System.Windows.Forms.LinkLabel();
            this.createAccountButton = new System.Windows.Forms.Button();
            this.signInButton = new System.Windows.Forms.Button();
            this.rememberMeCheckBox = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.registrationPanel = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tokenTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.confirmPasswordTextBox = new System.Windows.Forms.TextBox();
            this.alreadyRegisteredButton = new System.Windows.Forms.LinkLabel();
            this.registerButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.passwordRegTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.loginRegTextbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.signInPanel.SuspendLayout();
            this.registrationPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // signInPanel
            // 
            this.signInPanel.Controls.Add(this.forgotPasswordButton);
            this.signInPanel.Controls.Add(this.createAccountButton);
            this.signInPanel.Controls.Add(this.signInButton);
            this.signInPanel.Controls.Add(this.rememberMeCheckBox);
            this.signInPanel.Controls.Add(this.label3);
            this.signInPanel.Controls.Add(this.passwordTextBox);
            this.signInPanel.Controls.Add(this.label2);
            this.signInPanel.Controls.Add(this.loginTextBox);
            this.signInPanel.Controls.Add(this.label1);
            this.signInPanel.Location = new System.Drawing.Point(80, 40);
            this.signInPanel.Name = "signInPanel";
            this.signInPanel.Size = new System.Drawing.Size(400, 400);
            this.signInPanel.TabIndex = 0;
            // 
            // forgotPasswordButton
            // 
            this.forgotPasswordButton.AutoSize = true;
            this.forgotPasswordButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.forgotPasswordButton.Location = new System.Drawing.Point(250, 340);
            this.forgotPasswordButton.Name = "forgotPasswordButton";
            this.forgotPasswordButton.Size = new System.Drawing.Size(116, 16);
            this.forgotPasswordButton.TabIndex = 8;
            this.forgotPasswordButton.TabStop = true;
            this.forgotPasswordButton.Text = "Forgot password?";
            this.forgotPasswordButton.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.forgotPasswordButton_LinkClicked);
            // 
            // createAccountButton
            // 
            this.createAccountButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.createAccountButton.Location = new System.Drawing.Point(34, 296);
            this.createAccountButton.Name = "createAccountButton";
            this.createAccountButton.Size = new System.Drawing.Size(332, 33);
            this.createAccountButton.TabIndex = 7;
            this.createAccountButton.Text = "Create an account?";
            this.createAccountButton.UseVisualStyleBackColor = true;
            this.createAccountButton.Click += new System.EventHandler(this.createAccountButton_Click);
            // 
            // signInButton
            // 
            this.signInButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.signInButton.Location = new System.Drawing.Point(34, 257);
            this.signInButton.Name = "signInButton";
            this.signInButton.Size = new System.Drawing.Size(332, 33);
            this.signInButton.TabIndex = 6;
            this.signInButton.Text = "Sign in";
            this.signInButton.UseVisualStyleBackColor = true;
            this.signInButton.Click += new System.EventHandler(this.signInButton_Click);
            // 
            // rememberMeCheckBox
            // 
            this.rememberMeCheckBox.AutoSize = true;
            this.rememberMeCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rememberMeCheckBox.Location = new System.Drawing.Point(34, 216);
            this.rememberMeCheckBox.Name = "rememberMeCheckBox";
            this.rememberMeCheckBox.Size = new System.Drawing.Size(117, 20);
            this.rememberMeCheckBox.TabIndex = 5;
            this.rememberMeCheckBox.Text = "Remember me";
            this.rememberMeCheckBox.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(31, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordTextBox.Location = new System.Drawing.Point(34, 179);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(332, 26);
            this.passwordTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(31, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Email address";
            // 
            // loginTextBox
            // 
            this.loginTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginTextBox.Location = new System.Drawing.Point(34, 116);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(332, 26);
            this.loginTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(135, 22);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(140, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sign In";
            // 
            // registrationPanel
            // 
            this.registrationPanel.Controls.Add(this.label10);
            this.registrationPanel.Controls.Add(this.surnameTextBox);
            this.registrationPanel.Controls.Add(this.label9);
            this.registrationPanel.Controls.Add(this.nameTextBox);
            this.registrationPanel.Controls.Add(this.label8);
            this.registrationPanel.Controls.Add(this.tokenTextBox);
            this.registrationPanel.Controls.Add(this.label7);
            this.registrationPanel.Controls.Add(this.confirmPasswordTextBox);
            this.registrationPanel.Controls.Add(this.alreadyRegisteredButton);
            this.registrationPanel.Controls.Add(this.registerButton);
            this.registrationPanel.Controls.Add(this.label4);
            this.registrationPanel.Controls.Add(this.passwordRegTextBox);
            this.registrationPanel.Controls.Add(this.label5);
            this.registrationPanel.Controls.Add(this.loginRegTextbox);
            this.registrationPanel.Controls.Add(this.label6);
            this.registrationPanel.Location = new System.Drawing.Point(80, 12);
            this.registrationPanel.Name = "registrationPanel";
            this.registrationPanel.Size = new System.Drawing.Size(400, 437);
            this.registrationPanel.TabIndex = 1;
            this.registrationPanel.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(202, 76);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 18);
            this.label10.TabIndex = 16;
            this.label10.Text = "Surname";
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.surnameTextBox.Location = new System.Drawing.Point(205, 97);
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.Size = new System.Drawing.Size(161, 26);
            this.surnameTextBox.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(31, 76);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 18);
            this.label9.TabIndex = 14;
            this.label9.Text = "Name";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameTextBox.Location = new System.Drawing.Point(34, 97);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(161, 26);
            this.nameTextBox.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(31, 130);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 18);
            this.label8.TabIndex = 12;
            this.label8.Text = "Token number";
            // 
            // tokenTextBox
            // 
            this.tokenTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tokenTextBox.Location = new System.Drawing.Point(34, 151);
            this.tokenTextBox.Name = "tokenTextBox";
            this.tokenTextBox.Size = new System.Drawing.Size(332, 26);
            this.tokenTextBox.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(31, 289);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 18);
            this.label7.TabIndex = 10;
            this.label7.Text = "Confirm password";
            // 
            // confirmPasswordTextBox
            // 
            this.confirmPasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.confirmPasswordTextBox.Location = new System.Drawing.Point(34, 310);
            this.confirmPasswordTextBox.Name = "confirmPasswordTextBox";
            this.confirmPasswordTextBox.PasswordChar = '*';
            this.confirmPasswordTextBox.Size = new System.Drawing.Size(332, 26);
            this.confirmPasswordTextBox.TabIndex = 9;
            // 
            // alreadyRegisteredButton
            // 
            this.alreadyRegisteredButton.AutoSize = true;
            this.alreadyRegisteredButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.alreadyRegisteredButton.Location = new System.Drawing.Point(240, 393);
            this.alreadyRegisteredButton.Name = "alreadyRegisteredButton";
            this.alreadyRegisteredButton.Size = new System.Drawing.Size(126, 16);
            this.alreadyRegisteredButton.TabIndex = 8;
            this.alreadyRegisteredButton.TabStop = true;
            this.alreadyRegisteredButton.Text = "Already registered?";
            this.alreadyRegisteredButton.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // registerButton
            // 
            this.registerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.registerButton.Location = new System.Drawing.Point(34, 351);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(332, 33);
            this.registerButton.TabIndex = 6;
            this.registerButton.Text = "Register";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(31, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Password";
            // 
            // passwordRegTextBox
            // 
            this.passwordRegTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordRegTextBox.Location = new System.Drawing.Point(34, 257);
            this.passwordRegTextBox.Name = "passwordRegTextBox";
            this.passwordRegTextBox.PasswordChar = '*';
            this.passwordRegTextBox.Size = new System.Drawing.Size(332, 26);
            this.passwordRegTextBox.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(31, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 18);
            this.label5.TabIndex = 2;
            this.label5.Text = "Email address";
            // 
            // loginRegTextbox
            // 
            this.loginRegTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginRegTextbox.Location = new System.Drawing.Point(34, 205);
            this.loginRegTextbox.Name = "loginRegTextbox";
            this.loginRegTextbox.Size = new System.Drawing.Size(332, 26);
            this.loginRegTextbox.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(89, 16);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label6.Size = new System.Drawing.Size(229, 42);
            this.label6.TabIndex = 0;
            this.label6.Text = "Registration";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 461);
            this.Controls.Add(this.registrationPanel);
            this.Controls.Add(this.signInPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vehicle accounting system";
            this.signInPanel.ResumeLayout(false);
            this.signInPanel.PerformLayout();
            this.registrationPanel.ResumeLayout(false);
            this.registrationPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel signInPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel forgotPasswordButton;
        private System.Windows.Forms.Button createAccountButton;
        private System.Windows.Forms.Button signInButton;
        private System.Windows.Forms.CheckBox rememberMeCheckBox;
        private System.Windows.Forms.Panel registrationPanel;
        private System.Windows.Forms.LinkLabel alreadyRegisteredButton;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox passwordRegTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox loginRegTextbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox surnameTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tokenTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox confirmPasswordTextBox;
    }
}

