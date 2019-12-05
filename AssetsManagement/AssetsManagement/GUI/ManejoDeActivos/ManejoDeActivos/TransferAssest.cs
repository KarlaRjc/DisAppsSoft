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
            // TODO: This line of code loads data into the '_AssetsManagement_DbModelDataSet2.AssetTransferHistoryEntities' table. You can move, or remove it, as needed.
            this.assetTransferHistoryEntitiesTableAdapter.Fill(this._AssetsManagement_DbModelDataSet2.AssetTransferHistoryEntities);

        }
    }
}
