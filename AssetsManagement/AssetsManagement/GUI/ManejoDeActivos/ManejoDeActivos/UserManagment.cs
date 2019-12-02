using AssetsManagement;
using ManejoDeActivos.Controller;
using ManejoDeActivos.Encrypt;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ManejoDeActivos
{
    public partial class UserManagment:Form,IEncryptPassword
    {
        UserManagmentController userManagmenteController = new UserManagmentController();
        public UserManagment()
        {
            InitializeComponent();
        }


        public string EncryptPassword(string passwordEncryted)
        {
           
            HashAlgorithm hashAlgorithm = new SHA256CryptoServiceProvider();// Uses the fuction SHA256 from library Cryptography to ecrypt password
            var byteValue = System.Text.Encoding.UTF8.GetBytes(passwordEncryted); 
            var byteHash = hashAlgorithm.ComputeHash(byteValue);/// here it encrypts the value 
            return Convert.ToBase64String(byteHash);
             /*Returns the length of the encrypted password, in this case it will be 64 bits
            confirms the password with the length of bytes, without having to decrypt it */

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

        //Gets the information from the text inputs to then add a new user
        private void addUserBtn_Click(object sender, EventArgs e)
        {

            string nameUser = nameUserTxt.Text;
            string username = usernameTxt.Text;
            string password = passwordTxt.Text;
            string userRole = (string) userRolCbx.SelectedItem;

            Boolean usernameFound = userManagmenteController.VerifyUsername(username);

            if (!usernameFound)
            {
                userManagmenteController.CreateUser(nameUser, username, password, userRole);
                outputUserLbl.Text = "";
                ClearForm();
                MessageBox.Show("Usuario Agregado Correctamente");
            }
            else
            {
                outputUserLbl.Text = "Nombre de usuario ya existe";
            }    
        }

        //Allow to clear all text inputs and calls the UpdateUsersTable()
        private void ClearForm()
        {
            nameUserTxt.Text = "";
            usernameTxt.Text = "";
            passwordTxt.Text = "";
            userRolCbx.ResetText();
            userRolCbx.SelectedItem = -1;
            outputUserLbl.Text = "";

            UpdateUsersTable();

        }

        private void UserManagment_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_AssetsManagement_DbModelDataSet.UserEntities' table. You can move, or remove it, as needed.
            this.userEntitiesTableAdapter.Fill(this._AssetsManagement_DbModelDataSet.UserEntities);

        }

        // Allows to refresh the datagrid after inserting new record
        private void UpdateUsersTable()
        {
            using (DbModel db = new DbModel())
            {
                usersTable.DataSource = db.User.ToList<UserEntity>();
            }
        }
    }
}
