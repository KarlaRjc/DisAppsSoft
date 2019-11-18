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
    public partial class AssetManagment : Form
    {
        bool button1WasClicked = false;
       
        public AssetManagment()

        {
           
            InitializeComponent();
        }

        private void assestIdNumberTxt_TextChanged(object sender, EventArgs e)
        {
           
        }
       
       
        private void addAssestBtn_Click(object sender, EventArgs e)
        {
            button1WasClicked = true;
           
            ErrorEmptyField(assestIdNumberTxt.Text);
         
            ErrorNumberField(assestIdNumberTxt.Text);
        }

        public void ErrorEmptyField(string error)
        {
            
            if (button1WasClicked == true && string.IsNullOrEmpty(error))
            {
                MessageBox.Show("Por favor rellene todos los campos");
            }

        }public void ErrorNumberField(string error)
        {

            if (button1WasClicked == true && !int.TryParse(error, out int i))
            {
                MessageBox.Show("Por favor agrege solo números");
              
            }

        }
    }
}
