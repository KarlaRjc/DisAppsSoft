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
        public AssetManagment()
        {
            InitializeComponent();
        }

        private void AssetManagment_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_AssetsManagement_DbModelDataSet1.AssetEntities' table. You can move, or remove it, as needed.
            this.assetEntitiesTableAdapter.Fill(this._AssetsManagement_DbModelDataSet1.AssetEntities);

        }
    }
}
