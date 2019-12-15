using AssetsManagement;
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
    public partial class AssetManagment : Form
    {
        AssetManagmentController assetManagmentController = new AssetManagmentController();
        public AssetManagment()
        {
            InitializeComponent();
        }

        private void AssetManagment_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_AssetsManagement_DbModelDataSet1.AssetEntities' table. You can move, or remove it, as needed.
            this.assetEntitiesTableAdapter.Fill(this._AssetsManagement_DbModelDataSet1.AssetEntities);

        }
        private bool ValidateAssetManagementInputs (string description, string brand, string model, string serialNumber, string state)
        {
            bool isDescriptionValid = Sanitizer.Sanitize(assestDescriptionTxt_ErrorLabel, new GeneralInputSanitizer(), description);
            bool isBrandValid = Sanitizer.Sanitize(assestBrandTxt_ErrorLabel, new GeneralInputSanitizer(), brand);
            bool isModelValid = Sanitizer.Sanitize(assestModelTxt_ErrorLabel, new GeneralInputSanitizer(), model);
            bool isSerialNumberValid = Sanitizer.Sanitize(assestSerialNumberTxt_ErrorLabel, new GeneralInputSanitizer(), serialNumber);
            bool isStateValid = Sanitizer.Sanitize(assestStateCbx_ErrorLabel, new GeneralInputSanitizer(), state);

            return isDescriptionValid && isBrandValid && isModelValid && isSerialNumberValid && isStateValid;
        }
        //Adds new asset
        private void addAssestBtn_Click(object sender, EventArgs e)
        {
            string description = assestDescriptionTxt.Text;
            string brand = assestBrandTxt.Text;
            string model = assestModelTxt.Text;
            string serialNumber = assestSerialNumberTxt.Text;
            string state = (string)assestStateCbx.SelectedItem;

            bool areInputsValid = ValidateAssetManagementInputs(description, brand, model, serialNumber, state);
            if (areInputsValid) 
            {
                Boolean assetFound = assetManagmentController.VerifySerialNumber(serialNumber);

                if (!assetFound)
                {
                    assetManagmentController.CreateAsset(description, brand, model, serialNumber, state);
                    outputAssestLbl.Text = "";
                    ClearForm();
                    MessageBox.Show("Activo Agregado Correctamente");
                }
                else
                {
                    outputAssestLbl.Text = "Número de serie ya se encuentra registrado";
                }
            }
        }
        
        private void ClearForm()
        {
            assestDescriptionTxt.Text = "";
            assestBrandTxt.Text = "";
            assestSerialNumberTxt.Text = "";
            assestStateCbx.ResetText();
            assestStateCbx.SelectedItem = -1;
            outputAssestLbl.Text = "";

            UpdateAssetsTable();

        }

        //Updates all records from the database
        private void UpdateAssetsTable()
        {
            using (DbModel db = new DbModel())
            {
                assetsManagmentTable.DataSource = db.Asset.ToList<AssetEntity>();
            }
        }

        private void RemoveAssetBtn_Click(object sender, EventArgs e)
        {
            if (assetsManagmentTable.SelectedCells.Count > 0)
            {
                int selectedrowindex = assetsManagmentTable.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = assetsManagmentTable.Rows[selectedrowindex];
                string serial = Convert.ToString(selectedRow.Cells[5].Value);
                assetManagmentController.RemoveAsset(serial);
                UpdateAssetsTable();
            }
        }

        private void editAssestBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
