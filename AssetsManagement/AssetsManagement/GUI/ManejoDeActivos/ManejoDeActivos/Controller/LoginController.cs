using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AssetsManagement;
namespace ManejoDeActivos.Controller
{
    public static class LoginController
    {
        static UserEntity currentUser;

        public static Dictionary<string,string> Login(string userName, string password) 
        {
            var result = new Dictionary<string, string>();

            var user = UserEntity.GetUserByUsername(userName);
            if (user != null) 
            {
                if (user.password == password) 
                {
                    result.Add("Success","The login was successful");
                    result.Add("Role", user.role.ToString());
                    currentUser = user;
                }
            }
            return result;
        }
    }
}
