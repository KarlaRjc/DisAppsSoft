using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManejoDeActivos
{
    public partial class UserManagment : Form
    {
        public UserManagment()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void addUserBtn_Click(object sender, EventArgs e)
        {

            string nameUser = nameUserTxt.Text;
            string username = usernameTxt.Text;
            string password = passwordTxt.Text;
            string userRole = (string) userRolCbx.SelectedItem;


            Boolean formFilledOut = true;

            if (string.IsNullOrEmpty(nameUser))
            {
                errorNameUserLbl.Text = "Nombre vacío";
                formFilledOut = false;
            }
            else if (Regex.IsMatch(nameUserTxt.Text, @"^[\p{L}]+$"))
            {
                errorNameUserLbl.Text = "Solo se permiten letras";
                formFilledOut = false;
            }
            else 
            {
                errorNameUserLbl.Text = "";
            }

            if (string.IsNullOrEmpty(username))
            {
                errorUsernameLbl.Text = "Usuario vacío";
                formFilledOut = false;

            }
            else if(username.Contains(" "))
            {
                errorUsernameLbl.Text = "Espacios no son permitidos";
                formFilledOut = false;
            }
            else
            {
                errorUsernameLbl.Text = "";
            }

            if (string.IsNullOrEmpty(password))
            {
                errorPasswordLbl.Text = "Contraseña vacío";
                formFilledOut = false;
            }
            else if (password.Contains(" "))
            {
                errorPasswordLbl.Text = "Espacios no son permitidos";
                formFilledOut = false;
            }
            else
            {
                errorPasswordLbl.Text = "";
            }

            if (string.IsNullOrEmpty(userRole))
            {
                errorUserRoleLbl.Text = "Debe seleccionar rol de la lista";
                formFilledOut = false;
            }
            else
            {
                errorUserRoleLbl.Text = "";
            }




        }


        
    }
}
