using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetsManagement.DTO.Reports
{
   public class IteratorAssetItem:IIteratorAssetItem
    {
        private List<AssetItem> assetItem;

        private int position = -1;

        public IteratorAssetItem(List<AssetItem> assets)
        {
            this.assetItem = assets;
        }

        public void FirstAsset()
        {
            this.position = -1;
        }

        public AssetItem Actual()
        {
            if ((this.assetItem == null) || (this.assetItem.Count == 0) || (this.position < 0))
            {
                return null;
            }
            else
            {
                return (AssetItem)this.assetItem[position];
            }
        }

        public AssetItem Next()
        {
            if ((this.assetItem == null) || (this.assetItem.Count == 0) || (position + 1 > this.assetItem.Count - 1))
            {
                return null;
            }
            else
            {
                return (AssetItem)this.assetItem[++position];
            }
        }

        public bool ElementsLeft()
        {
            return (position + 1 <= this.assetItem.Count - 1);
        }
    }
}

