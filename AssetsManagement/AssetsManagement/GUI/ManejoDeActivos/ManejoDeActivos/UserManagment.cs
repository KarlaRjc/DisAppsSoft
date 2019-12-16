using AssetsManagement;
using ManejoDeActivos.Controller;
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
    public partial class UserManagment:Form
    {
        UserManagmentController userManagmenteController = new UserManagmentController();
        public UserManagment()
        {
            InitializeComponent();
            UpdateUsersTable();
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
            string userRole = (string) ((userRolCbx.SelectedItem == null)? "": userRolCbx.SelectedItem);
            string userQuestion = (string) ((userQuestionCbx.SelectedItem == null)? "": userQuestionCbx.SelectedItem);
            string userAnswer = userAnswerTxt.Text;

            Boolean userCreated = userManagmenteController.CreateUser(nameUser, username, password, userRole, userQuestion, userAnswer);

            if (userCreated)
            {
                userManagmenteController.CreateUser(nameUser, username, password, userRole, userQuestion, userAnswer);
                outputUserLbl.Text = "";
                ClearForm();
                UpdateUsersTable();
                MessageBox.Show("Usuario Agregado Correctamente");
            }
            else
            {
                outputUserLbl.Text = "Nombre de usuario ya existe";
            }    
        }

        //Clears all inputs from the form
        private void ClearForm()
        {
            nameUserTxt.ResetText();
            usernameTxt.ResetText();
            passwordTxt.ResetText();
            userRolCbx.ResetText();
            userRolCbx.SelectedItem = -1;
            userQuestionCbx.ResetText();
            userQuestionCbx.SelectedItem = -1;
            userAnswerTxt.ResetText();
            outputUserLbl.ResetText();

        }

        private void UserManagment_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_AssetsManagement_DbModelDataSet.UserEntities' table. You can move, or remove it, as needed.
            this.userEntitiesTableAdapter.Fill(this._AssetsManagement_DbModelDataSet.UserEntities);

        }

        // Updates the datagrid after CRUD new record
        private void UpdateUsersTable()
        {
            using (DbModel db = new DbModel())
            {
                usersTable.DataSource = db.User.ToList<UserEntity>();
            }
        }

        private void RemoveUserBtn_Click(object sender, EventArgs e)
        {

            if(MessageBox.Show("¿Esta seguro(a) que desea eliminar el usuario?", "Alerta", MessageBoxButtons.YesNo) == DialogResult.Yes) 
            {
                if (usersTable.SelectedCells.Count > 0)
                {
                    int selectedrowindex = usersTable.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = usersTable.Rows[selectedrowindex];
                    string a = Convert.ToString(selectedRow.Cells[1].Value);
                    userManagmenteController.RemoveUser(a);
                    UpdateUsersTable();
                    ClearForm();
                }
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            
        }
        public void editUserBtn_Click(object sender, EventArgs e)
        {

            if (usersTable.SelectedCells.Count > 0)
            {
                string nameUser = nameUserTxt.Text;
                string username = usernameTxt.Text;
                string password = passwordTxt.Text;
                string userRole = (string)((userRolCbx.SelectedItem == null) ? "" : userRolCbx.SelectedItem);
                string userQuestion = (string)((userQuestionCbx.SelectedItem == null) ? "" : userQuestionCbx.SelectedItem);
                string userAnswer = userAnswerTxt.Text;

                Boolean usernameFound = userManagmenteController.VerifyUsername(username);

                if (usernameFound)
                {
                    userManagmenteController.ModifyUser(nameUser, username, password, userRole, userQuestion, userAnswer);
                    outputUserLbl.Text = "";
                    ClearForm();
                    UpdateUsersTable();
                    MessageBox.Show("Usuario modificado Correctamente");
                }
                else
                {
                    outputUserLbl.Text = "Nombre de usuario no existe";
                }
            }

        }

        private void usersTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedrowindex = usersTable.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = usersTable.Rows[selectedrowindex];

            nameUserTxt.Text = Convert.ToString(selectedRow.Cells[0].Value);
            usernameTxt.Text = Convert.ToString(selectedRow.Cells[1].Value);
            passwordTxt.Text = Convert.ToString(selectedRow.Cells[2].Value);
            userRolCbx.Text = Convert.ToString(selectedRow.Cells[3].Value);
            userQuestionCbx.Text = Convert.ToString(selectedRow.Cells[4].Value);
            userAnswerTxt.Text = Convert.ToString(selectedRow.Cells[5].Value);
        }

        //Calls the ClearForm method
        private void cleanFormBtn_Click(object sender, EventArgs e)
        {
            ClearForm();
        }
    }
}
