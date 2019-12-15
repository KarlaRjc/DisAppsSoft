using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetsManagement
{
    public class AssetTransferHistory
    {
        public int id { get; set; }
        public AssetEntity assetTansfered { get; set; }
        public DateTime transferDate { get; set; }

        public LabEntity transferedFromLab { get; set; }

        public LabEntity transferedToLab { get; set; }

        public UserEntity transferedByUser { get; set; }

        public string description { get; set; }

        public static AssetTransferHistoryEntity CreateAssetTransferHistory(AssetEntity assetTranfered, DateTime transferDate, LabEntity transferedFromLab, LabEntity transferedToLab, UserEntity transferedByUser, string description)
        {
            AssetTransferHistoryEntity assetTransferHistoryEntity = new AssetTransferHistoryEntity();

            assetTransferHistoryEntity.assetTransfered = assetTranfered;
            assetTransferHistoryEntity.transferDate = transferDate;
            assetTransferHistoryEntity.transferedFromLab = transferedFromLab;
            assetTransferHistoryEntity.transferedToLab = transferedToLab;
            assetTransferHistoryEntity.transferedByUser = transferedByUser;
            assetTransferHistoryEntity.description = description;

            return assetTransferHistoryEntity;
        }

        public static AssetTransferHistoryEntity ModifyAssetTransferHistory(AssetTransferHistory assetTransferHistory, AssetTransferHistoryEntity assetTransferHistoryEntity)
        {
            assetTransferHistoryEntity.assetTransfered = assetTransferHistory.assetTansfered;
            assetTransferHistoryEntity.transferDate = assetTransferHistory.transferDate;
            assetTransferHistoryEntity.transferedFromLab = assetTransferHistory.transferedFromLab;
            assetTransferHistoryEntity.transferedToLab = assetTransferHistory.transferedToLab;
            assetTransferHistoryEntity.transferedByUser = assetTransferHistory.transferedByUser;
            assetTransferHistoryEntity.description = assetTransferHistory.description;

            return assetTransferHistoryEntity;
        }
    }
}
