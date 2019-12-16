using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetsManagement
{
    public class Admin : User
    {
        //Creates a new userEntity and then calls the method UserEntity.CreateUserToDB
        public static UserEntity CreateUser(string name, EnumRole role, string username, string password, string secretQuestion, string secretAnswer)
        {
            UserEntity userentity = new UserEntity();
            
            userentity.name = name;
            userentity.role = role;
            userentity.username = username;
            userentity.password = password;
            userentity.secretQuestion = secretQuestion;
            userentity.secretAnswer = secretAnswer;

            UserEntity.CreateUserToDB(userentity);

            return userentity;
        }

        public bool EditUser(User user)
        {
            return false;
        }

        public static void DeleteUser(string username)
        {
            UserEntity user = User.GetUserByUsername(username);
            UserEntity.DeleteUserToDB(user);
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
        //Checks if username already exists
        public static Boolean CheckUsername(string username)
        {
            Boolean userFound = false;
            UserEntity user = null;

            user = UserEntity.GetUserByUsername(username);

            try
            {
                if (!user.Equals(null))
                {

                    userFound = true;
                }

            }
            catch (Exception e) 
            {

                userFound = false;
            }

            return userFound;
        }

        //Creates a new assetEntity and then calls the method AssetEntity.CreateAssetToDB
        public static AssetEntity CreateAsset(string description, string brand, string model, string series, string state)
        {

            AssetEntity asset = new AssetEntity();
            asset.description = description;
            asset.brand = brand;
            asset.model = model;
            asset.series = series;
            asset.state = state;

            AssetEntity.CreateAssetToDB(asset);

            return asset;
        }
    }
}
