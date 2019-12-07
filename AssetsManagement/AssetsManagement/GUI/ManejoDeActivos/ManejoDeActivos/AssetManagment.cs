using AssetsManagement;
using ManejoDeActivos.Controller;
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
        //Adds new asset
        private void addAssestBtn_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(assestIdNumberTxt.Text);
            string description = assestDescriptionTxt.Text;
            string brand = assestBrandTxt.Text;
            string model = assestModelTxt.Text;
            string serialNumber = assestSerialNumberTxt.Text;
            string state = (string)assestStateCbx.SelectedItem;
            string location = (string)assetLocationCbx.SelectedItem;

            Boolean assetFound = assetManagmentController.VerifySerialNumber(serialNumber);

            if (!assetFound)
            {
                assetManagmentController.CreateAsset(id, description, brand, model, serialNumber, state);
                outputAssestLbl.Text = "";
                ClearForm();
                MessageBox.Show("Activo Agregado Correctamente");
            }
            else
            {
                outputAssestLbl.Text = "Número de serie ya se encuentra registrado";
            }

            
        }
        
        private void ClearForm()
        {
            assestIdNumberTxt.Text = "";
            assestDescriptionTxt.Text = "";
            assestBrandTxt.Text = "";
            assestSerialNumberTxt.Text = "";
            assestStateCbx.ResetText();
            assestStateCbx.SelectedItem = -1;
            assetLocationCbx.ResetText();
            assetLocationCbx.SelectedItem = -1;
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
                string a = Convert.ToString(selectedRow.Cells["Serie"].Value);
                assetManagmentController.RemoveAsset(a);
                UpdateAssetsTable();
            }
        }
    }
}
