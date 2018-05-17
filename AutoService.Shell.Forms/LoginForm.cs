using AutoService.Business.Enums;
using AutoService.Business.Interfaces;
using System;
using System.Windows.Forms;

namespace AutoService.Shell.Forms
{
    public partial class LoginForm : Form
    {
        private readonly IUserManager userManager;
        private readonly MainForm mainForm;

        public LoginForm(IUserManager userManager, MainForm mainForm)
        {
            InitializeComponent();
            this.userManager = userManager;
            this.mainForm = mainForm;
        }

        #region SIGN IN

        // Кнопка Sign In
        private async void signInButton_Click(object sender, EventArgs e)
        {
            LoginResult loginResult = LoginResult.Failed;
            string resultMessage = "Login or password is incorrect, try again";
            string login = loginTextBox.Text;
            string password = passwordTextBox.Text;

            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
            {
                resultMessage = "Not all fields are filled, try again";
            }
            else
            {
                loginResult = await userManager.LoginAsync(login, password);

                if (loginResult == LoginResult.Success)
                {
                    resultMessage = "You are successfully authenticated";
                }
            }

            MessageBox.Show(resultMessage, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            if (loginResult == LoginResult.Success)
            {
                mainForm.Show();
                this.Hide();
            }
        }

        // Кнопка Create an account?
        private void createAccountButton_Click(object sender, EventArgs e)
        {
            registrationPanel.Visible = true;
            signInPanel.Visible = false;
        }

        // Кнопка Forgot password?
        private void forgotPasswordButton_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        #endregion

        #region REGISTRATION

        // Кнопка Already registered?
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            signInPanel.Visible = true;
            registrationPanel.Visible = false;
        }

        // Кнопка Register
        private async void registerButton_Click(object sender, EventArgs e)
        {
            string resultMessage = "Something went wrong, try again";
            string name = nameTextBox.Text;
            string surname = surnameTextBox.Text;
            string tokenNumber = tokenTextBox.Text;
            string login = loginRegTextbox.Text;
            string password = passwordRegTextBox.Text;
            string passwordConfirm = confirmPasswordTextBox.Text;

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(surname) || string.IsNullOrEmpty(tokenNumber) ||
                string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(passwordConfirm))
            {
                resultMessage = "Not all fields are filled, try again";
            }
            else
            {
                if (password != passwordConfirm)
                {
                    resultMessage = "Passwords dont match, try again";
                }
                else
                {
                    RegisterResult registerResult = await userManager.RegisterAsync(name, surname, int.Parse(tokenNumber), login, password);

                    if (registerResult == RegisterResult.LoginExists)
                    {
                        resultMessage = "User with this login is already registered, try again";
                    }

                    if (registerResult == RegisterResult.TokenExists)
                    {
                        resultMessage = "User with this token is already registered, try again";
                    }

                    if (registerResult == RegisterResult.Success)
                    {
                        resultMessage = "You are successfully registered";
                    }
                }
            }

            MessageBox.Show(resultMessage, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        #endregion        
    }
}