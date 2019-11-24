using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetsManagement
{
    public class Admin : User
    {

        public bool CreateUser(User user)
        {
            return false;
        }

        public bool EditUser(User user)
        {
            return false;
        }

        public bool DeleteUser(User user)
        {
            return false;
        }

        public bool EditAsset(AssetEntity asset)
        {
            return false;
        }

        public bool CreateAsset(AssetEntity asset)
        {
            return false;
        }

        public bool DeleteAsset(AssetEntity asset)
        {
            return false;
        }

        public override bool ChangePassword()
        {
            return false;
        }

        /// <summary>
        /// This method maps the properties in User base
        /// class and matches 
        /// them in UserEntity
        /// </summary>
        /// <param name="user"></param>
        /// <returns>UserEntity</returns>
        private UserEntity MapUserToEntity(User user)
        {
            return null;
        }
    }
}
