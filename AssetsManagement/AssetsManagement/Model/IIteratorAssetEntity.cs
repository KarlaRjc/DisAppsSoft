using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetsManagement
{
    interface IIteratorAssetEntity
    {
        void FirstAsset();
        AssetEntity Actual();
        AssetEntity Next();
        bool ElementsLeft();

    }
}
