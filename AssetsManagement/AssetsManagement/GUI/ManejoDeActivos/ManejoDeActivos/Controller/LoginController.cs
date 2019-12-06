using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AssetsManagement;
using System.Security.Cryptography;

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
                if (user.password == EncryptPassword(password)) 
                {
                    result.Add("Success","The login was successful");
                    result.Add("Role", user.role.ToString());
                    currentUser = user;
                }
            }
            return result;
        }

        public static string EncryptPassword(string passwordEncryted)
        {
           
                HashAlgorithm hashAlgorithm = new SHA256CryptoServiceProvider();
                var byteValue = System.Text.Encoding.UTF8.GetBytes(passwordEncryted);
                var byteHash = hashAlgorithm.ComputeHash(byteValue);
                return Convert.ToBase64String(byteHash);


            /* 
             *line 1. Uses method SHA256 from library Cryptography to encrypt password
             * line2. Gets the bytes from the encrypted password
             * line3. Calculates the specified value 
             * line4 Converts the 8 bits value into 64 digits
            */
        }
    }
}
