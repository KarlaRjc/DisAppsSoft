using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetsManagement
{
    public class Teacher : User
    {

        public bool TransferAsset()
        {
            return false;
        }

        public override bool ChangePassword()
        {
            return false;
        }
    }
}
