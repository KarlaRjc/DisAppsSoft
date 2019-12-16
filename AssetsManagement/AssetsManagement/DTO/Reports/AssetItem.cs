using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetsManagement.DTO.Reports

{ 

    public class AssetItem
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public static IteratorAssetItem ObtainIterator()
        {
            return new IteratorAssetItem(Asset.GetAssets());
        }
    }
    
}
