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

        public AssetEntity assetTransfered { get; set; }

        public DateTime transferDate { get; set; }

        public LabEntity transferedFromLab { get; set; }

        public LabEntity transferedToLab { get; set; }

        public UserEntity transferedByUser { get; set; }

        public string description { get; set; }
    }
}
