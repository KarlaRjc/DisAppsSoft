using AssetsManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejoDeActivos.Controller
{
    class UserManagmentController
    {
        //Allows to create user entity according to the role and then add it to the database
        public void CreateUser(string nameUser, string username, string password, string userRole)
        {
            switch (userRole)
            {
                case "Administrador":
                    //Create the user
                    UserEntity userentityAdmin = Admin.CreateUser(7, nameUser, EnumRole.Admin, username, password);

                    //Add user to the database
                    UserEntity.CreateUserToDB(userentityAdmin);
                    break;
                case "Profesor":
                    //Create the user
                    UserEntity userentityTeacher = Admin.CreateUser(7, nameUser, EnumRole.Teacher, username, password);

                    //Add user to the database
                    UserEntity.CreateUserToDB(userentityTeacher);
                    break;
                case "Observador":
                    //Create the user
                    UserEntity userentityGatherer = Admin.CreateUser(7, nameUser, EnumRole.Gatherer, username, password);

                    //Add user to the database
                    UserEntity.CreateUserToDB(userentityGatherer);

                    break;
            }
        }

        public Boolean VerifyUsername(string username)
        {
            Boolean usernameFound = Admin.CheckUsername(username);

            return usernameFound;
        }
    }
}
