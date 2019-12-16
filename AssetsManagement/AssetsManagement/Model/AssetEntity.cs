using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetsManagement
{
    public class AssetEntity
    {
        [Key]
        public int id { get; set; }

        public string description { get; set; }

        public string brand { get; set; }

        public string model { get; set; }

        public string series { get; set; }

        public string state { get; set; }


        /// <summary>
        /// Adds a new AssetEntity to the Database
        /// </summary>
        /// <param name="assetentity"></param>
        public static void CreateAssetToDB(AssetEntity assetentity)
        {
            //Opens a conection with the DB
            using (DbModel db = new DbModel())
            {
                //Adds an Asset
                db.Asset.Add(assetentity);

                //Saves the changes
                db.SaveChanges();
            }
        }


        /// <summary>
        /// Modifies an existing AssetEntity in the Database, searches for the corresponding AssetEntity and modifies it
        /// </summary>
        /// <param name="asset"></param>
        public static void ModifyAssetToDB(AssetEntity asset)
        {
            //Opens a conection with the DB
            using (DbModel db = new DbModel())

            {
                db.Entry(asset).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }


        }

        /// <summary>
        /// Deletes an AssetEntity from the Database, searches for the corresponding AssetEntity and deletes it
        /// </summary>
        /// <param name="asset"></param>
        public static void DeleteAssetToDB(AssetEntity asset)
        {
            //Opens a conection with the DB
            using (DbModel db = new DbModel())
            {
                //Searches for the assetentity related to that asset id
                AssetEntity assetentity = db.Asset.SingleOrDefault(a => a.id == asset.id);

                //Removes the Assetentity from the DB
                db.Asset.Remove(assetentity);

                //Saves the changes
                db.SaveChanges();
            }
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

    }
}
