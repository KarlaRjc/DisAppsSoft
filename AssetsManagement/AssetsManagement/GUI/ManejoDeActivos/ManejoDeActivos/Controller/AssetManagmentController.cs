using AssetsManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejoDeActivos.Controller
{
    class AssetManagmentController
    {
        public void CreateAsset(int id, string description, string brand, string model, string series, string state)
        {
            AssetEntity assetentity = Asset.CreateAsset(id, description, brand, model, series, state);

            AssetEntity.CreateAssetToDB(assetentity);
        }


        public Boolean VerifySerialNumber(string serial)
        {
            Boolean assetFound = Asset.VerifySerialNumber(serial);

            return assetFound;
        }
    }
}
