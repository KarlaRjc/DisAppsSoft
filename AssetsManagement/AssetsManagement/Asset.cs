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
        public static AssetEntity CreateAsset(int id, string description, string brand, string model, string series, string state)
        {

            AssetEntity asset = new AssetEntity();
            asset.id = id;
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
        public static AssetEntity ModifyAsset(Asset asset, AssetEntity assetentity)
        {

            assetentity.description = asset.description;
            assetentity.brand = asset.brand;
            assetentity.model = asset.model;
            assetentity.series = asset.series;
            assetentity.state = asset.state;

            return assetentity;

        }


    }

}
