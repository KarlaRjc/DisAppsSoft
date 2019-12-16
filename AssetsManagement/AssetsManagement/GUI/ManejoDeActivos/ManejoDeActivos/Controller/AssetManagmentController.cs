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
        //Creates a new user calling the Admin.CreateAsset method. It will return boolean if new asset was able to create 
        public bool CreateAsset(string description, string brand, string model, string series, string state)
        {
            bool assetCreated = false;

            if (!VerifySerialNumber(series))
            {
                Admin.CreateAsset(description, brand, model, series, state);
                assetCreated = true;
            }

            return assetCreated;
        }

        //Verifies if the serial number already exists 
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
