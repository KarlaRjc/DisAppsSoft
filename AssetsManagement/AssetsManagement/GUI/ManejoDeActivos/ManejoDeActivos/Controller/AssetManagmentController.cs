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
        public void CreateAsset(string description, string brand, string model, string series, string state)
        {
            AssetEntity assetentity = Asset.CreateAsset(description, brand, model, series, state);

            AssetEntity.CreateAssetToDB(assetentity);
        }


        public bool VerifySerialNumber(string serial)
        {
            return Asset.VerifySerialNumber(serial);
        }

        public void RemoveAsset(string asset)
        {
            AssetEntity.DeleteAssetToDB(AssetEntity.GetAssetBySerialNumber(asset));
        }
    }
}
