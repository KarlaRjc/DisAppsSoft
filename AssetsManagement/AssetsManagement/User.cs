﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetsManagement
{
    public abstract class User : Reports
    {
        public int id { get; set; }
        public string name { get; set; }
        public EnumRole role { get; set; }
        public string username { get; set; }
        public string password { get; set; }

        public abstract bool ChangePassword();

        public User GetUserById(int id)
        {
            return null;
        }
        public UserEntity GetUserEntityById(int id)
        {
            return null;
        }

        /// <summary>
        /// Creates an UserEntity,receives as parameters several attributes related to a user 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="role"></param>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Modifies an existing UserEntity, receives as parameters the UserEntity that wants to be modified and a User with the updated information
        /// </summary>
        /// <param name="user"></param>
        /// <param name="userentity"></param>
        /// <returns></returns>
        public static UserEntity ModifyUser(User user, UserEntity userentity)
        {
            userentity.name = user.name;
            userentity.role = user.role;
            userentity.username = user.username;
            userentity.password = user.password;

            return userentity;
        }
    }
}
