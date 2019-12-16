using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetsManagement
{
    public class AssetTransferHistoryEntity
    {
        //Attributes
        [Key]
        public int id { get; set; }
        public string assetTransfered { get; set; }
        public string series { get; set; }
        public DateTime transferDate { get; set; }
        public string transferedFromLab { get; set; }
        public string transferedToLab { get; set; }
        public string transferedByUser { get; set; }
        public string tranferedByUsername { get; set; }
        public string description { get; set; }

        //Method that create a new transfer to DB
        public static void CreateAssetTransferHistoryEntityToDB(AssetTransferHistoryEntity assetTransferHistoryEntity)
        {
            //Open connection to DB
            using (DbModel db = new DbModel())
            {
                //Add the transfer to the history
                db.AssetTransferHistory.Add(assetTransferHistoryEntity);

                db.SaveChanges();
            }
        }

        //Method that modify the history to DB
        public static void ModifyAssetTransferHistoryEntityToDB(AssetTransferHistory assetTransferHistory)
        {
            //Open connection to DB
            using (DbModel db = new DbModel())
            {
                //Use the id to tranfer
                AssetTransferHistoryEntity assetTransferHistoryEntity = db.AssetTransferHistory.SingleOrDefault(d => d.id == assetTransferHistory.id);

                Console.WriteLine(assetTransferHistory.id);
                Console.WriteLine(assetTransferHistoryEntity.id);

                //Call the modify asset method
                assetTransferHistoryEntity = AssetTransferHistory.ModifyAssetTransferHistory(assetTransferHistory, assetTransferHistoryEntity);

                db.Entry(assetTransferHistoryEntity).State = System.Data.Entity.EntityState.Modified;

                db.SaveChanges();
            }
        }

        //Method that delete trasfered of the history to DB
        public static void DeleteAssetTransferHistoryEntityToDB(AssetTransferHistory assetTransferHistory)
        {
            //Open connection
            using (DbModel db = new DbModel())
            {
                //Use the id to tranfer
                AssetTransferHistoryEntity assetTransferHistoryEntity = db.AssetTransferHistory.SingleOrDefault(d => d.id == assetTransferHistory.id);

                //Call the remove asset method
                db.AssetTransferHistory.Remove(assetTransferHistoryEntity);

                db.SaveChanges();
            }
        }

        //Method that return the transfer asset entity
        public static AssetTransferHistoryEntity GetAssetTransferHistoryEntityById(int id)
        {
            AssetTransferHistoryEntity assetTransferHistoryEntity = null;

            //Open connection
            using (DbModel db = new DbModel())
            {
                assetTransferHistoryEntity = db.AssetTransferHistory.Where(x => x.id == id).FirstOrDefault();
            }
            return assetTransferHistoryEntity;
        }
    }
}
