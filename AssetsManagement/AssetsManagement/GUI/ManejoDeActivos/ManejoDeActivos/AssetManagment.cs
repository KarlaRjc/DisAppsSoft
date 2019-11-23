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
    public partial class AssetManagment : Form
    {
        bool button1WasClicked = false;

        

        Regex reg = new Regex(@"^-?\d+[.]?\d*$");
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
            ErrorEmptyField(assestDescriptionTxt.Text);

            ErrorNumberField(assestIdNumberTxt.Text);
            NegativeNumberField(assestIdNumberTxt.Text);

            //CHECKEAR QUE SE REPITEN LOS ERRORES SI LLAMO LOS METODOS DE LOS DEMÁS FIELDS
//CHECKEAR SI SE VAN A USAR MESSAGE BOX, SI SE USAN SE TENDRÁN QUE HACER MUCHOS IF PARA DETECTAR DE CUÁL FIELD ES
        }public void ErrorEmptyField(string error)
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

        }public void NegativeNumberField(string error) {
            //VER SI EN EL ID SOLO SE AGREGAN NÚMEROS
            int number = 0;

            if (button1WasClicked == true && int.TryParse(error, out number));
            {
                if (number <0)
                {
                    MessageBox.Show("Error, no se pueden agregar negativos.");
                }
            }
        }

        private void editAssestBtn_Click(object sender, EventArgs e)
        {
            button1WasClicked = true;
        }

        private void removeAssetBtn_Click(object sender, EventArgs e)
        {
            //¿En eliminar se tienen que agregar toda la información?
            assetsManagmentTable.Rows.RemoveAt(assetsManagmentTable.CurrentRow.Index);
        }
    }
}
