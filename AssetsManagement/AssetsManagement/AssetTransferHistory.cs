using AssetsManagement.DTO.TransferAsset;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetsManagement
{
    public class AssetTransferHistory
    {
        //Attributes
        public int id { get; set; }
        public AssetEntity assetTansfered { get; set; }
        public DateTime transferDate { get; set; }
        public LabEntity transferedFromLab { get; set; }
        public LabEntity transferedToLab { get; set; }
        public UserEntity transferedByUser { get; set; }
        public string description { get; set; }

        //Method to create a new asset transfer 
        public static void CreateAssetTransferHistory(AssetEntity assetTranfered, DateTime transferDate, string transferedFromLab, LabEntity transferedToLab, UserEntity transferedByUser, string description)
        {
            AssetTransferHistoryEntity assetTransferHistoryEntity = new AssetTransferHistoryEntity();

            assetTransferHistoryEntity.assetTransfered = assetTranfered.description;
            assetTransferHistoryEntity.series = assetTranfered.series;
            assetTransferHistoryEntity.transferDate = transferDate;
            assetTransferHistoryEntity.transferedFromLab = transferedFromLab;
            assetTransferHistoryEntity.transferedToLab = transferedToLab.name;
            assetTransferHistoryEntity.transferedByUser = transferedByUser.name;
            assetTransferHistoryEntity.tranferedByUsername = transferedByUser.username;
            assetTransferHistoryEntity.description = description;
            using (DbModel db = new DbModel())
            {
                db.AssetTransferHistory.Add(assetTransferHistoryEntity);
                db.SaveChanges();
            }
        }

        //Method to modify a new asset transfer 
        public static AssetTransferHistoryEntity ModifyAssetTransferHistory(AssetTransferHistory assetTransferHistory, AssetTransferHistoryEntity assetTransferHistoryEntity)
        {
            assetTransferHistoryEntity.assetTransfered = assetTransferHistory.assetTansfered.description;
            assetTransferHistoryEntity.transferDate = assetTransferHistory.transferDate;
            assetTransferHistoryEntity.transferedFromLab = assetTransferHistory.transferedFromLab.name;
            assetTransferHistoryEntity.transferedToLab = assetTransferHistory.transferedToLab.name;
            assetTransferHistoryEntity.transferedByUser = assetTransferHistory.transferedByUser.name;
            assetTransferHistoryEntity.tranferedByUsername = assetTransferHistory.transferedByUser.username;
            assetTransferHistoryEntity.description = assetTransferHistory.description;

            return assetTransferHistoryEntity;
        }

        //Return the lab where is the asset
        public static string GetCurrentLabForAsset(string series) 
        {
            string lab = null;
            using (DbModel db = new DbModel())
            {
                lab =  db.AssetTransferHistory.Where(x => x.series == series).Select(x => x.transferedToLab).FirstOrDefault();
            }
            
            return lab != null ? lab : "N/A";
        }

        //Returns the list of labs
        public static List<LabItem> GetLabs() 
        {
            List<LabItem> labs = new List<LabItem>();
            using (DbModel db = new DbModel())
            {
                var labsEntities = db.Lab.ToList();
                foreach (var lab in labsEntities)
                {
                    labs.Add(new LabItem { LabId = lab.id, LabName = lab.name });
                }
            }
            return labs;
        }
    }
}
