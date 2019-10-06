using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetsManagement
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public EnumRole Role { get; set; }

        public void CreateUser()
        {

        }

        public void EditUser()
        {

        }

        public void ChangePassword()
        {

        }

        public void GetUserById()
        {

        }

        public void DeleteUser()
        {

        }
    }
}
