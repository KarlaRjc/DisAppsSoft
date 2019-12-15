using AssetsManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejoDeActivos.Controller
{
    class TransferAssetController
    {

        public void transferAsset(string description, string assetTransferId, string username, int destinationLab) {
            
            User.TransferAsset(description, assetTransferId, username, 0, destinationLab);
        }
    }
}
