using AssetsManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejoDeActivos.Controller
{
    public class AssetManagmentController
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
            Admin.DeleteAsset(asset);
        }

        public void ModifyAsset(string description, string brand, string model, string series, string state)
        {
            bool wasSuccessful = Admin.ModifyAsset(description, brand, model, series, state);
            if (!wasSuccessful)
            {
                throw new Exception();
            }
        }
    }
}
