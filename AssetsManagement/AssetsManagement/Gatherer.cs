using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetsManagement
{
    class Gatherer : User
    {
        public override bool ChangePassword()
        {
            return false;
        }
    }
}
