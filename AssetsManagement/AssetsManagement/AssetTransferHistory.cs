using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetsManagement
{
    public class AssetTransferHistory
    {
        [Key]
        public int id { get; set; }

        public Asset AssetTransfered { get; set; }

        public DateTime TransferDate { get; set; }

        public Lab TransferedFromLab { get; set; }

        public Lab TransferedToLab { get; set; }

        public User TransferedByUser { get; set; }

        public string Description { get; set; }
    }
}
