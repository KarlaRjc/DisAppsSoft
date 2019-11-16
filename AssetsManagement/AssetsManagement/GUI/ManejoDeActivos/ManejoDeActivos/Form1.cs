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
    }
}
