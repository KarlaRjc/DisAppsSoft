using AssetsManagement.DTO.Reports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetsManagement
{
    public class Asset
    {
        public int id { get; set; }

        public string description { get; set; }

        public string brand { get; set; }

        public string model { get; set; }

        public string series { get; set; }

        public string state { get; set; }


        /// <summary>
        /// Creates an AssetEntity,receives as parameters several attributes related to an asset 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="description"></param>
        /// <param name="brand"></param>
        /// <param name="model"></param>
        /// <param name="series"></param>
        /// <param name="state"></param>
        /// <returns></returns>
        public static AssetEntity CreateAsset(string description, string brand, string model, string series, string state)
        {

            AssetEntity asset = new AssetEntity();
            asset.description = description;
            asset.brand = brand;
            asset.model = model;
            asset.series = series;
            asset.state = state;

            return asset;

        }

        public static List<AssetItem> GetAssets() 
        {
            List<AssetItem> result = new List<AssetItem>();
            using (DbModel db = new DbModel()) 
            {
                var assets = db.Asset.ToList();
                foreach (var asset in assets)
                {
                    result.Add(new AssetItem() { Id = asset.id, Name= asset.description });
                }
                
            }
            return result;
        }

        //Returns the assest if the serial number exists otherwise returns null
        public static AssetEntity GetAssetBySerialNumber(string serial)
        {
            AssetEntity asset = null;
            using (DbModel db = new DbModel())
            {
                asset = db.Asset.Where(x => x.series == serial).FirstOrDefault();
            }
            return asset;
        }

        public static AssetEntity mapAssetInputToAssetEntity(string description, string brand, string model, string series, string state)
        {
            var asset = GetAssetBySerialNumber(series);
            asset.description = description;
            asset.brand = brand;
            asset.model = model;
            asset.series = series;
            asset.state = state;

            return asset;
        }

        //Checks if serial number already exists
        public static Boolean VerifySerialNumber(string serial)
        {
            Boolean assestFound = false;
            AssetEntity asset = null;

            asset = AssetEntity.GetAssetBySerialNumber(serial);

            try
            {
                if (!asset.Equals(null))
                {

                    assestFound = true;
                }

            }
            catch (Exception e)
            {

                assestFound = false;
            }

            return assestFound;
        }


    }
}
