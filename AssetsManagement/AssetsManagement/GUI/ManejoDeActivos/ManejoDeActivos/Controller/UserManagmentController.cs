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
        //Allows to create user entity according to the role and then add it to the database
        public void CreateUser(string nameUser, string username, string password, string userRole, string userQuestion, string userAnswer)
        {
            switch (userRole)
            {
                case "Administrador":
                    //Creates the user
                    UserEntity userentityAdmin = Admin.CreateUser(7, nameUser, EnumRole.Admin, username, EncryptPassword(password), userQuestion, userAnswer);

                    //Adds user to the database
                    UserEntity.CreateUserToDB(userentityAdmin);
                    break;
                case "Profesor":
                    //Creates the user
                    UserEntity userentityTeacher = Admin.CreateUser(7, nameUser, EnumRole.Teacher, username, EncryptPassword(password), userQuestion, userAnswer);

                    //Adds user to the database
                    UserEntity.CreateUserToDB(userentityTeacher);
                    break;
                case "Observador":
                    //Creates the user
                    UserEntity userentityGatherer = Admin.CreateUser(7, nameUser, EnumRole.Gatherer, username, EncryptPassword(password), userQuestion, userAnswer);

                    //Adds user to the database
                    UserEntity.CreateUserToDB(userentityGatherer);
                    break;
                default:
                    break;
            }
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

        public Boolean VerifyUsername(string username)
        {
            Boolean usernameFound = Admin.CheckUsername(username);

            return usernameFound;
        }

        public void RemoveUser(string username)
        {
            Admin.DeleteUser(username);
        }

        //Allows to create user entity according to the role and then add it to the database
        public void ModifyUser(string nameUser, string username, string password, string userRole, string userQuestion, string userAnswer)
        {
            switch (userRole)
            {
                case "Administrador":
                    //Creates the user
                    UserEntity userAdmin = Admin.CreateUser(7, nameUser, EnumRole.Admin, username, EncryptPassword(password), userQuestion, userAnswer);
                    UserEntity.ModifyUserToDB(userAdmin);

                    break;
                case "Profesor":
                    //Creates the user
                    UserEntity userTeacher = Admin.CreateUser(7, nameUser, EnumRole.Teacher, username, EncryptPassword(password), userQuestion, userAnswer);
                    UserEntity.ModifyUserToDB(userTeacher);

                    break;
                case "Observador":
                    //Creates the user
                    UserEntity userGatherer = Admin.CreateUser(7, nameUser, EnumRole.Gatherer, username, EncryptPassword(password), userQuestion, userAnswer);
                    UserEntity.ModifyUserToDB(userGatherer);

                    break;
                default:
                    break;
            }
        }
    }
}
