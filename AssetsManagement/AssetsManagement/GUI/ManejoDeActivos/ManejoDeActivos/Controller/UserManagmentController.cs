using AssetsManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ManejoDeActivos.Controller
{
    class UserManagmentController
    {
        //Creates a new user calling the Admin.CreateUser method. It will return boolean if new user was able to create 
        public bool CreateUser(string nameUser, string username, string password, string userRole, string userQuestion, string userAnswer)
        {
            bool userCreated = false;

            if (!VerifyUsername(username))
            {
                Admin.CreateUser(nameUser, mapInputToEnumRole(userRole), username, EncryptPassword(password), userQuestion, userAnswer);
                userCreated = true;
            }

            return userCreated;

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

        //Verifies if the username already exists
        public Boolean VerifyUsername(string username)
        {
            Boolean usernameFound = Admin.CheckUsername(username);

            return usernameFound;
        }

        public void RemoveUser(string username)
        {
            Admin.DeleteUser(username);
        }

        private EnumRole mapInputToEnumRole(string role) 
        {
            switch (role)
            {
                case "Administrador":
                    return EnumRole.Administrador;
                case "Profesor":
                    return EnumRole.Profesor;
                case "Recopilador":
                    return EnumRole.Recopilador;
                default:
                    throw new System.ArgumentException("Role does not exist", "original");
            }
        }
        //Allows to modify user entity according to the role and then add it to the database
        public void ModifyUser(string nameUser, string username, String password, string userRole, string userQuestion, string userAnswer)
        {    
            
           bool wasSuccessful = Admin.ModifyUser(nameUser, mapInputToEnumRole(userRole), username, EncryptPassword(password), userQuestion, userAnswer);
            if (!wasSuccessful) 
            {
                throw new Exception();
            }
        }
        }
    }

