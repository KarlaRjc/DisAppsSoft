using AssetsManagement;
using AssetsManagement.DTO.Reports;
using AssetsManagement.DTO.TransferAsset;
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
    public partial class Reports : Form

    {
        public List<AssetItem> Assets { get; set; }

        public Reports()

        {
                InitializeComponent();
        }

        public IteratorAssetItem ObtainIterator() {

            return new IteratorAssetItem(Assets);
        }

        private void Reports_Load(object sender, EventArgs e)
        {
            ReportsController.AssetsByStateReport(assets_by_state_grid, "");
            ReportsController.TransfersByUserReport(tranfers_by_user_report, "");
            ReportsController.TransfersByAssetReport(transfers_by_asset_report, "");
           

            foreach (var user in User.GetUsers())
            {
                user_comboBox.Items.Add(user);
            }
            user_comboBox.ValueMember = "Id";
            user_comboBox.DisplayMember = "Name";
 
            Reports report = new Reports();
            report.Assets = Asset.GetAssets();
            IteratorAssetItem iterator = report.ObtainIterator();

          
            while(iterator.ElementsLeft())
            {
                AssetItem assetItem = iterator.Next();
                assets_comboBox.Items.Add(assetItem);
            }
            assets_comboBox.ValueMember = "Id";
            assets_comboBox.DisplayMember = "Name";
        }

        private void assetsByLab_Grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void assets_by_state_btn_Click(object sender, EventArgs e)
        {
            string state = (state_ComboBox.SelectedItem != null ? state_ComboBox.SelectedItem.ToString(): (state_ComboBox.Text != "" ? state_ComboBox.Text:""));
            ReportsController.AssetsByStateReport(assets_by_state_grid, state);
        }

        private void tranfers_by_user_btn_Click(object sender, EventArgs e)
        {
            string userName = (user_comboBox.SelectedItem != null ? (user_comboBox.SelectedItem as UserItem).Name : (user_comboBox.Text != "" ? user_comboBox.Text : ""));;
            ReportsController.TransfersByUserReport(tranfers_by_user_report, userName);
        }

        private void transfers_by_asset_Click(object sender, EventArgs e)
        {
            string asset = (assets_comboBox.SelectedItem != null ? (assets_comboBox.SelectedItem as AssetItem).Name : (assets_comboBox.Text != "" ? assets_comboBox.Text : ""));
            ReportsController.TransfersByAssetReport(transfers_by_asset_report, asset);
        }

        private void state_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
