using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetsManagement
{

    //Class inheriting from user, this is a type of user
    //It contains the methods of the actions that this type of user can execute.
    public class Gatherer : User
    {
        public override bool ChangePassword()
        {
            return false;
        }
    }
}
