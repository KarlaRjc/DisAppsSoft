using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetsManagement
{
    public class AdminAsset : Asset
    {
        public bool EditAsset(AssetEntity asset)
        {
            return false;
        }

        public bool CreateAsset(AssetEntity asset)
        {
            return false;
        }

        public static void DeleteAsset(string serial)
        {
            AssetEntity asset = Asset.GetAssetBySerialNumber(serial);
            AssetEntity.DeleteAssetToDB(asset);
        }


        private UserEntity MapAssetToEntity(Asset asset)
        {
            return null;
        }

    }
}
