using AssetsManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManejoDeActivos.Controller
{

    //This class contains the querys to work the asset transfer
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
        public static void TransfersByUserReport(DataGridView grid, string name)
        {
            using (DbModel db = new DbModel())
            {
                grid.DataSource = (from transfer in db.AssetTransferHistory
                                   select new
                                   {
                                       Usuario = transfer.transferedByUser,
                                       Activo = transfer.assetTransfered,
                                       Serie = transfer.series,
                                       Fecha_de_transferencia = transfer.transferDate,
                                       Transferido_desde = transfer.transferedFromLab,
                                       Transferido_hacia = transfer.transferedToLab,
                                       Motivo = transfer.description
                                   }).Where(x => x.Usuario.Contains(name) || name == "").OrderBy(x => x.Usuario).ThenByDescending(x => x.Fecha_de_transferencia).ToList();
            }
        }
        public static void TransfersByAssetReport(DataGridView grid, string asset)
        {
            using (DbModel db = new DbModel())
            {
                grid.DataSource = (from transfer in db.AssetTransferHistory
                                   select new
                                   {
                                       Usuario = transfer.transferedByUser,
                                       Activo = transfer.assetTransfered,
                                       Serie = transfer.series,
                                       Fecha_de_transferencia = transfer.transferDate,
                                       Transferido_desde = transfer.transferedFromLab,
                                       Transferido_hacia = transfer.transferedToLab,
                                       Motivo = transfer.description
                                   }).Where(x => x.Activo.Contains(asset) || asset == "").OrderBy(x => x.Activo).ThenByDescending(x => x.Fecha_de_transferencia).ToList();
            }
        }
        public static void AssetsByStateReport(DataGridView grid, string state)
        {
            using (DbModel db = new DbModel())
            {
                grid.DataSource = (from asset in db.Asset
                                   select new
                                   {
                                       Nombre = asset.description,
                                       Marca = asset.brand,
                                       Modelo = asset.model,
                                       Estado = asset.state,
                                       Serie = asset.series
                                   }).Where(x => x.Estado.Contains(state) || state == "").OrderBy(x => x.Estado).ToList();
            }
        }
    }
}
