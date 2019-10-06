using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetsManagement
{
    public class Lab
    {
        [Key]
        public int id { get; set; }

        public List<Asset> Assets {get; set;}
    }
}
