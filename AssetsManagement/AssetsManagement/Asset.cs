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

        /// <summary>
        /// Modifies an existing AssetEntity, receives as parameters the AssetEntity that wants to be modified and an Asset with the updated information
        /// </summary>
        /// <param name="asset"></param>
        /// <param name="assetentity"></param>
        /// <returns></returns>
        public static bool ModifyAsset(string description, string brand, string model, string series, string state)
        {
            bool wasSuccessful = false;
            try
            {
                var asset = mapAssetInputToAssetEntity (description, brand, model, series, state);
                AssetEntity.ModifyAssetToDB(asset);
                wasSuccessful = true;
            }
            catch (Exception)
            {

                wasSuccessful = false;
            }
            return wasSuccessful;
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
