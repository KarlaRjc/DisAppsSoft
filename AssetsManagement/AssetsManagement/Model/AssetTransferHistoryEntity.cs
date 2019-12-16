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

        public static void CreateAssetTransferHistoryEntityToDB(AssetTransferHistoryEntity assetTransferHistoryEntity)
        {
            using (DbModel db = new DbModel())
            {
                db.AssetTransferHistory.Add(assetTransferHistoryEntity);

                db.SaveChanges();
            }
        }

        public static void ModifyAssetTransferHistoryEntityToDB(AssetTransferHistory assetTransferHistory)
        {
            using (DbModel db = new DbModel())
            {
                AssetTransferHistoryEntity assetTransferHistoryEntity = db.AssetTransferHistory.SingleOrDefault(d => d.id == assetTransferHistory.id);

                Console.WriteLine(assetTransferHistory.id);
                Console.WriteLine(assetTransferHistoryEntity.id);

                assetTransferHistoryEntity = AssetTransferHistory.ModifyAssetTransferHistory(assetTransferHistory, assetTransferHistoryEntity);

                db.Entry(assetTransferHistoryEntity).State = System.Data.Entity.EntityState.Modified;

                db.SaveChanges();
            }
        }

        public static void DeleteAssetTransferHistoryEntityToDB(AssetTransferHistory assetTransferHistory)
        {
            using (DbModel db = new DbModel())
            {
                AssetTransferHistoryEntity assetTransferHistoryEntity = db.AssetTransferHistory.SingleOrDefault(d => d.id == assetTransferHistory.id);

                db.AssetTransferHistory.Remove(assetTransferHistoryEntity);

                db.SaveChanges();
            }
        }

        public static AssetTransferHistoryEntity GetAssetTransferHistoryEntityById(int id)
        {
            AssetTransferHistoryEntity assetTransferHistoryEntity = null;
            using (DbModel db = new DbModel())
            {
                assetTransferHistoryEntity = db.AssetTransferHistory.Where(x => x.id == id).FirstOrDefault();
            }
            return assetTransferHistoryEntity;
        }
    }
}
