using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetsManagement.DTO.Reports

{
    //The AssetItem class contains the return of the Iterator
    public class AssetItem
    {
        public int Id { get; set; }
        public string Name { get; set; }

        //Method for return the asset
        public static IteratorAssetItem ObtainIterator()
        {
            return new IteratorAssetItem(Asset.GetAssets());
        }
    }
    
}
