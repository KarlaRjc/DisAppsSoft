using ManejoDeActivos.Controller;
using ManejoDeActivos.Controller.Sanitize;
using ManejoDeActivos.Controller.Sanitize.DefinedSanitizers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManejoDeActivos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Button7_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            openUserManagment(new Reports());
        }

        private void assestManagmentBtn_Click(object sender, EventArgs e)
        {
            openUserManagment(new AssetManagment());
        }

        private void openUserManagment(object childForm) 
        {
            if (this.homePanel.Controls.Count > 0)
                this.homePanel.Controls.RemoveAt(0);
            Form fh = childForm as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.homePanel.Controls.Add(fh);
            this.homePanel.Tag = fh;
            fh.Show();
            
        }

        private void userManagmentBtn_Click(object sender, EventArgs e)
        {
            openUserManagment(new UserManagment());
        }

        private void transferAssestBtn_Click(object sender, EventArgs e)
        {
            openUserManagment(new TransferAssest());
        }

        private void transferHisotryBtn_Click(object sender, EventArgs e)
        {
            openUserManagment(new TransferHistory());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            // Set to no text.
            passwordInput.Text = "";
            // The password character is an asterisk.
            passwordInput.PasswordChar = '*';
            // The control will allow no more than 14 characters.
            passwordInput.MaxLength = 14;
        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void ResetLoginErrorMessages() 
        {
            LoginErrorMessage.ResetText();
            PasswordErrorMessage.ResetText();
            UserNameErrorMessage.ResetText();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            ResetLoginErrorMessages();
            bool isPasswordInputValid = Sanitizer.Sanitize(PasswordErrorMessage, new PasswordSanitizer(), passwordInput.Text);
            bool isUsernameInputValid = Sanitizer.Sanitize(UserNameErrorMessage, new UsernameSanitizer(), UserNameInput.Text);

            if (isPasswordInputValid && isUsernameInputValid)
            {
                var result = LoginController.Login(UserNameInput.Text, passwordInput.Text);

                if (result.ContainsKey("Success"))
                    {
                    var role = LoginController.currentUser.role;
                    switch (role)
                    {
                        case AssetsManagement.EnumRole.Administrador:
                            break;
                        case AssetsManagement.EnumRole.Profesor:
                            assestManagmentBtn.Hide();
                            userManagmentBtn.Hide();
                            break;
                        case AssetsManagement.EnumRole.Recopilador:
                            assestManagmentBtn.Hide();
                            userManagmentBtn.Hide();
                            transferHisotryBtn.Hide();
                            transferAssestBtn.Hide();
                            break;
                        default:
                            break;
                    }
                    LoginPanel.Hide();
                        CurrentRoleText.Text = result["Role"];
                    } 
                    else 
                    {
                        if (result.Count > 1)
                        {
                            foreach (KeyValuePair<string, string> entry in result)
                            {
                                LoginErrorMessage.Text += (entry.Value + ", ");
                            }
                        }
                        else 
                        {
                            LoginErrorMessage.Text = result.FirstOrDefault().Value;
                        }

                    }
                }
        }

        private void LoginButton_Paint(object sender, PaintEventArgs e)
        {


        }

        private void UserNameInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void UserNameErrorMessage_Click(object sender, EventArgs e)
        {

        }

        private void PasswordErrorMessage_Click(object sender, EventArgs e)
        {

        }

        private void LoginErrorMessage_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void verifyUser_Button_Click(object sender, EventArgs e)
        {
            resetpassword_username_error_label.ResetText();
            var username = resetPasswordUsername.Text;
            bool isUsernameInputValid = Sanitizer.Sanitize(resetpassword_username_error_label, new UsernameSanitizer(), username);
            if (isUsernameInputValid) {
            var isUserValid = LoginController.VerifyIfUserExists(username);
            if (isUserValid)
            {
                panel_resetPassword_Step2.Visible = true;
                SecretQuestionLabel_Value.Text = LoginController.GetSecretQuestionByUsername(username);
            }
            else 
            {
                resetpassword_username_error_label.Text = "El usuario no existe.";
            }
            }
        }

        private void ChangePasswordButton_Click(object sender, EventArgs e)
        {
            resetPassword_answer_error_label.ResetText();
            var username = resetPasswordUsername.Text;
            var secretAnswer = SecretAnswerInput.Text;
            var newPassword = resetpassword_newPassword_Input.Text;
            var isPasswordInputValid = Sanitizer.Sanitize(resetpassword_newpassword_error_label, new PasswordSanitizer(), newPassword);
            var isSecretAnswerInputValid = Sanitizer.Sanitize(resetPassword_answer_error_label, new GeneralInputSanitizer(), secretAnswer);
            if (isPasswordInputValid && isSecretAnswerInputValid) 
            {
                if (LoginController.ChangePassword(username, secretAnswer, newPassword))
                {
                    MessageBox.Show("La contraseña ha sido modificada.");
                    resetPasswordPanel.Visible = false;

                }
                else
                {
                    resetPassword_answer_error_label.Text = "Respuesta incorrecta.";
                }
            }

        }

        private void label9_Click_1(object sender, EventArgs e)
        {
            resetPasswordPanel.Visible = false;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            resetPasswordPanel.Visible = true;
        }

        private void resetPasswordPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LoginPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
