using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetsManagement
{
    public class IteratorAssetEntity : IIteratorAssetEntity
    {
        private List<AssetEntity> assetEntities;

        private int position = -1;

        public IteratorAssetEntity(List<AssetEntity> assets)
        {
            this.assetEntities = assets;
        }

        public void FirstAsset()
        {
            this.position = -1;
        }

        public AssetEntity Actual()
        {
            if ((this.assetEntities == null) || (this.assetEntities.Count == 0) || (this.position < 0)){
                return null;
            }
            else
            {
                return (AssetEntity)this.assetEntities[position];
            }
        }

        public AssetEntity Next()
        {
            if ((this.assetEntities == null) || (this.assetEntities.Count == 0) || (position + 1 > this.assetEntities.Count - 1))
            {
                return null;
            }
            else
            {
                return (AssetEntity)this.assetEntities[++position];
            }  
        }

        public bool ElementsLeft()
        {
            return (position + 1 <= this.assetEntities.Count - 1);
        }
    }
}
