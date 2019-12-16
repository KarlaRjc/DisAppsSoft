using AssetsManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManejoDeActivos.Controller
{
    class ReportsController
    {
        public static void AssetsByLabReport(DataGridView grid) 
        {
            using (DbModel db = new DbModel())
            {
                grid.DataSource = (from asset in db.Asset
                                  select new { Nombre = asset.description, 
                                               Marca = asset.brand, 
                                               Estado = asset.state,  
                                               Serie = asset.series}).ToList();
            }
        }
    }
}
