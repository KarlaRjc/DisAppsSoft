﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetsManagement
{
    public class Admin : User
    {

        public static UserEntity CreateUser(int id, string name, EnumRole role, string username, string password)
        {
            UserEntity userentity = new UserEntity();
            userentity.id = id;
            userentity.name = name;
            userentity.role = role;
            userentity.username = username;
            userentity.password = password;

            return userentity;
        }

        public bool EditUser(User user)
        {
            return false;
        }

        public bool DeleteUser(User user)
        {
            return false;
        }

        public bool EditAsset(AssetEntity asset)
        {
            return false;
        }

        public bool CreateAsset(AssetEntity asset)
        {
            return false;
        }

        public bool DeleteAsset(AssetEntity asset)
        {
            return false;
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
    }
}
