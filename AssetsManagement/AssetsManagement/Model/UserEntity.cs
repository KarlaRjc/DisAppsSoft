using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetsManagement
{
    public class UserEntity
    {
        [Key]
        public int id { get; set; }

        public string name { get; set; }

        public EnumRole role { get; set; }

        public string username { get; set; }

        public string password { get; set; }

        public string secretQuestion { get; set; }

        public string secretAnswer { get; set; }

        public void ChangePassword(UserEntity user, string Answer, string newPassword)
        {

        }

        public void ChangePassword(UserEntity user, string newPassword)
        {
            //validate if caller is admin
        }
    }
}
