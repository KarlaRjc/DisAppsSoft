using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetsManagement
{
    //This is the interface that contain the methods to work with the iterator
    interface IIteratorAssetEntity
    {
        void FirstAsset();
        AssetEntity Actual();
        AssetEntity Next();
        bool ElementsLeft();

    }
}
