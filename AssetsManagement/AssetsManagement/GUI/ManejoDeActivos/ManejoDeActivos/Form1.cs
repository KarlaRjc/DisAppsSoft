using ManejoDeActivos.Controller;
using ManejoDeActivos.Controller.Sanitize;
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

        private void label7_Click(object sender, EventArgs e)
        {
            LoginErrorBox.ResetText();

            Sanitizer userNameSanitizer = new SpecialCharsNotAllowed(new CharInput());
            Sanitizer passwordSanitizer = new CharInput();
            var resultPasswordSanitizer = passwordSanitizer.SanitizeInput(passwordInput.Text);
            var resultUserNameSanitizer = userNameSanitizer.SanitizeInput(UserNameInput.Text);
            if (resultUserNameSanitizer.Count == 0)
            {
                if (resultPasswordSanitizer.Count == 0)
                {
                    var result = LoginController.Login(UserNameInput.Text, passwordInput.Text);
                    if (result.ContainsKey("Success"))
                    {
                        LoginPanel.Hide();
                        CurrentRoleText.Text = result["Role"];
                    }
                }
                else 
                {
                    LoginErrorBox.Show();
                    LoginErrorBox.AppendText("Password input errors: \n");
                    foreach (KeyValuePair<EnumSanitizeErrors, string> entry in resultPasswordSanitizer)
                    {
                        LoginErrorBox.AppendText(entry.Value + "\n");
                    }
                }
            }
            else 
            {
                LoginErrorBox.Show();
                LoginErrorBox.AppendText("Username input errors: \n");
                foreach (KeyValuePair<EnumSanitizeErrors, string> entry in resultUserNameSanitizer)
                {
                    LoginErrorBox.AppendText(entry.Value + "\n");
                }
            }
        }

        private void LoginButton_Paint(object sender, PaintEventArgs e)
        {


        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
