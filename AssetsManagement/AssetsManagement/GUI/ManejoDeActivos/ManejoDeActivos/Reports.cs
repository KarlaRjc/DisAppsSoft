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
        public Reports()
        {
            InitializeComponent();
        }

        private void Reports_Load(object sender, EventArgs e)
        {
            ReportsController.AssetsByLabReport(assetsByLab_Grid);
        }

        private void assetsByLab_Grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
