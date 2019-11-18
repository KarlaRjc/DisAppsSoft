using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetsManagement
{
    public abstract class User : Reports
    {
        public int id { get; set; }
        public string name { get; set; }
        public int username { get; set; }
        public string password { get; set; }

        public abstract bool ChangePassword();

        public User GetUserById(int id)
        {
            return null;
        }
        public UserEntity GetUserEntityById(int id)
        {
            return null;
        }


        public static UserEntity CreateUser(int id, string name, EnumRole role, string username, string password)
        {
            UserEntity user = new UserEntity();
            user.id = id;
            user.name = name;
            user.role = role;
            user.username = username;
            user.password = password;

            return user;
        }

    }
}
