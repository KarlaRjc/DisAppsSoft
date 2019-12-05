using AssetsManagement;
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
using static AssetsManagement.User;

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

            if (formFilledOut) 
            {
                switch (userRole) 
                {
                    case "Administrador":
                        UserEntity userentityAdmin = User.CreateUser(7, nameUser, EnumRole.Admin, username, password);

                        //Así se agrega ese user a la DB
                        UserEntity.CreateUserToDB(userentityAdmin);

                        MessageBox.Show("Usuario Agregado Correctamente");

                        Clear();
                        break;
                    case "Profesor":
                        UserEntity userentityTeacher = User.CreateUser(7, nameUser, EnumRole.Teacher, username, password);

                        //Así se agrega ese user a la DB
                        UserEntity.CreateUserToDB(userentityTeacher);

                        MessageBox.Show("Usuario Agregado Correctamente");
                        Clear();
                        break;
                    case "Observador":
                        UserEntity userentityGatherer = User.CreateUser(7, nameUser, EnumRole.Gatherer, username, password);

                        //Así se agrega ese user a la DB
                        UserEntity.CreateUserToDB(userentityGatherer);

                        MessageBox.Show("Usuario Agregado Correctamente");
                        Clear();
                        break;
                }
            }

        }

        private void Clear()
        {
            nameUserTxt.Text = "";
            usernameTxt.Text = "";
            passwordTxt.Text = "";
            userRolCbx.SelectedItem = "";

            usersTable.Update();
            usersTable.Refresh();
        }

        private void UserManagment_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_AssetsManagement_DbModelDataSet.UserEntities' table. You can move, or remove it, as needed.
            this.userEntitiesTableAdapter.Fill(this._AssetsManagement_DbModelDataSet.UserEntities);

        }

        private void userEntitiesBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void editUserBtn_Click(object sender, EventArgs e)
        {

            string nameUser = nameUserTxt.Text;
            string username = usernameTxt.Text;
            string password = passwordTxt.Text;
            string userRole = (string)userRolCbx.SelectedItem;

            

            

            
        }
    }
}
