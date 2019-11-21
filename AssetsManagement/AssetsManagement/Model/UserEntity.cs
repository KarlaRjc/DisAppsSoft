using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
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

        public void ChangePassword(UserEntity user, string Answer, string newPassword)
        {

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

        public static void ModifyUserToDB(int id)
        {
            using (DbModel db = new DbModel())
            {
                UserEntity user = db.User.SingleOrDefault(d => d.id == id);
                user.name = "New name";
                db.Entry(user).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }

        public static void DeleteUserToDB(int id)
        {
            using (DbModel db = new DbModel())
            {
                UserEntity user = db.User.SingleOrDefault(d => d.id == id);
                db.User.Remove(user);
                db.SaveChanges();
            }
        }

        public static void CreateUserToDB(UserEntity user)
        {
            using (DbModel db = new DbModel())
            {
                db.User.Add(user);
                db.SaveChanges();
            }
        }

    }
}
