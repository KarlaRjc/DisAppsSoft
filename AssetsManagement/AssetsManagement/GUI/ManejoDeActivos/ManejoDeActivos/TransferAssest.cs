using AssetsManagement;
using AssetsManagement.DTO.TransferAsset;
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
    public partial class TransferAssest : Form
    {
        AssetManagmentController assetManagmentController = new AssetManagmentController();

        public TransferAssest()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void nameUserTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void TransferAssest_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_AssetsManagement_assets.AssetEntities' table. You can move, or remove it, as needed.
            this.assetEntitiesTableAdapter1.Fill(this._AssetsManagement_assets.AssetEntities);
            foreach (var lab in AssetTransferHistory.GetLabs())
            {
                labCbx.Items.Add(lab);
            }
            
            labCbx.ValueMember = "LabId";
            labCbx.DisplayMember = "LabName";
        }
        private void UpdateTransferAssetsTable()
        {
            using (DbModel db = new DbModel())
            {
                assetsTransferTable.DataSource = db.Asset.ToList<AssetEntity>();
            }
        }

        //Button that triggers the transfer of assets
        private void TransferAssetBtn_Click(object sender, EventArgs e)
        {
            cmbx_lab_error.ResetText();
            if (labCbx.SelectedItem != null)
            {
                int labid = (labCbx.SelectedItem as LabItem).LabId;
                int selectedrowindex = assetsTransferTable.SelectedCells[0].RowIndex;
                string transferComment = transfer_comment_text.Text;
                bool isInputValid = Sanitizer.Sanitize(trasnfer_comment_label, new GeneralInputSanitizer(), transferComment);
                if (isInputValid)
                {
                    DataGridViewRow selectedRow = assetsTransferTable.Rows[selectedrowindex];
                    string series = (selectedRow.Cells[4].Value.ToString());

                    string username = LoginController.currentUser.username;

                    User.TransferAsset(series, username, labid, transferComment);

                    MessageBox.Show("Activo Transferido Correctamente");
                }
            }
            else
            {
                cmbx_lab_error.Text = "Valor requerido"; 
            } 
            


            
        }

        private void assetsTransferTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //This is the table of transfer asset
        private void assetsTransferTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedrowindex = assetsTransferTable.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = assetsTransferTable.Rows[selectedrowindex];

            asset_to_transfer_label.Text = Convert.ToString(selectedRow.Cells[1].Value);
        }

        private void labCbx_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
