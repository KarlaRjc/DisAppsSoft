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

        /// <summary>
        /// Modifies an existing UserEntity, receives as parameters the UserEntity that wants to be modified and a User with the updated information
        /// </summary>
        /// <param name="user"></param>
        /// <param name="userentity"></param>
        /// <returns></returns>
        public static bool ModifyUser(string name, EnumRole role, string username, string password, string userQuestion, string userAnswer)
        {
            bool wasSuccessful = false;
            try
            {
                var user = MapUserInputToUserEntity(name, role, username, password, userQuestion, userAnswer);
                UserEntity.ModifyUserToDB(user);
                wasSuccessful = true;
            }
            catch (Exception)
            {

                wasSuccessful = false;
            }
            return wasSuccessful;
        }

        public bool EditAsset(AssetEntity asset)
        {
            return false;
        }

        public bool CreateAsset(AssetEntity asset)
        {
            return false;
        }

        public static void DeleteAsset(string serial)
        {
            AssetEntity asset = Asset.GetAssetBySerialNumber(serial);
            AssetEntity.DeleteAssetToDB(asset);
        }


        private UserEntity MapAssetToEntity(Asset asset)
        {
            return null;
        }

        /// <summary>
        /// Modifies an existing AssetEntity, receives as parameters the AssetEntity that wants to be modified and an Asset with the updated information
        /// </summary>
        /// <param name="asset"></param>
        /// <param name="assetentity"></param>
        /// <returns></returns>
        public static bool ModifyAsset(string description, string brand, string model, string series, string state)
        {
            bool wasSuccessful = false;
            try
            {
                var asset = Asset.mapAssetInputToAssetEntity(description, brand, model, series, state);
                AssetEntity.ModifyAssetToDB(asset);
                wasSuccessful = true;
            }
            catch (Exception)
            {

                wasSuccessful = false;
            }
            return wasSuccessful;
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
