using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AssetsManagement
{
    public class UserEntity
    {
        [Key]
        public int id { get; set; }

        public string name { get; set; }

        public EnumRole role { get; set; }

        public string username { get; set; }

        public string password { get; set; }

        public string secretQuestion { get; set; }

        public string secretAnswer { get; set; }

        

       
        public static bool ChangePassword(string username, string secretAnswer, string newPassword)
        {
            try
            {
                using (DbModel db = new DbModel())
                {
                    var user = db.User.Where(x => x.username == username && x.secretAnswer == secretAnswer).FirstOrDefault();
                    user.password = newPassword;
                    db.SaveChanges();
                }
                return true;
            }
            catch (Exception e) 
            {
                return false;
            }
                
        }

        public void ChangePassword(UserEntity user, string newPassword)
        {
            //validate if caller is admin
        }

        public static bool GetUserRole(UserEntity user)
        {
            if (user.role == 0)
            {
                return true;
            }
            else return false;
        }

        /// <summary>
        /// Adds a new UserEntity to the Database
        /// </summary>
        /// <param name="userentity"></param>
        public static void CreateUserToDB(UserEntity userentity)
        {
            //Opens a conection with the DB
            using (DbModel db = new DbModel())
            {
                //Adds a User
                db.User.Add(userentity);

                //Saves the changes
                db.SaveChanges();
            }
        }

        /// <summary>
        /// Modifies an existing UserEntity in the Database, searches for the corresponding UserEntity and modifies it
        /// </summary>
        /// <param name="user"></param>
        public static void ModifyUserToDB(User user)
        {
            //Opens a conection with the DB
            using (DbModel db = new DbModel())
            {
                //Searches for the userentity related to that user id
                UserEntity userentity = db.User.SingleOrDefault(d => d.id == user.id);

                //Calls ModifyUser function, assigns to userentity the new parameters
                userentity = User.ModifyUser(user, userentity);

                //Modifies the record in the DB
                db.Entry(userentity).State = System.Data.Entity.EntityState.Modified;

                //Saves the changes
                db.SaveChanges();
            }
        }

        /// <summary>
        /// Deletes an UserEntity from the Database, searches for the corresponding UserEntity and deletes it
        /// </summary>
        /// <param name="user"></param>
        public static void DeleteUserToDB(UserEntity user)
        {
            //Opens a connection with the DB
            using (DbModel db = new DbModel())
            {
                //Searches for the userentity related to that user id
                UserEntity userentity = db.User.SingleOrDefault(d => d.id == user.id);

                //Romves the userentity from the DB
                db.User.Remove(userentity);

                //Saves the changes
                db.SaveChanges();
            }
        }

        public static UserEntity GetUserByUsername(string username)
        {
            UserEntity user = null;
            using (DbModel db = new DbModel())
            {
                user = db.User.Where(x => x.username == username).FirstOrDefault();
            }
            return user;
        }
    }
}
