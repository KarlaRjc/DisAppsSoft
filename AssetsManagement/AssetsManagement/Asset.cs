using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetsManagement
{
    public class Asset
    {
        [Key]
        public int id { get; set; }

        public string Name { get; set; }

        public new string ToString()
        {
            return "";
        }

        public static bool TransferAsset(EnumRole Role, Asset asset)
        {
            return false;
        }

        public static void CreateAsset(Asset assetToCreate)
        {

        }

        public static void EditAssetById(int id, Asset assetToModify)
        {

        }

        public static void DeleteAssetById()
        {

        }
    }
}
