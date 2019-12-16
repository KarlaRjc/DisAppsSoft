using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetsManagement.DTO.Reports
{
    //This is the interface that contain the methods to work with the iterator
    public interface IIteratorAssetItem
    {
        void FirstAsset();
        AssetItem Actual();
        AssetItem Next();
        bool ElementsLeft();
    }
}
