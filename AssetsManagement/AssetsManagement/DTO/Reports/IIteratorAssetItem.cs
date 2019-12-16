using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetsManagement.DTO.Reports
{
    interface IIteratorAssetItem
    {
        void FirstAsset();
        AssetItem Actual();
        AssetItem Next();
        bool ElementsLeft();
    }
}
