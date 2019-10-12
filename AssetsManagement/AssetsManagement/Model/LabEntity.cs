using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetsManagement
{
    public class LabEntity
    {
        [Key]
        public int id { get; set; }

        public List<AssetEntity> Assets {get; set;}
    }
}
