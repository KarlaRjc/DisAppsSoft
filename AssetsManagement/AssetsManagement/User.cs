using System;
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
        public int username { get; set; }
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

        public bool GetUserRole(UserEntity user)
        {
            if (user.role.ToString() == "Admin")
            {
                return true;
            }
            else return false;
        }

        public void CreateUserToDB(UserEntity user)
        {
            using (DbModel db = new DbModel())
            {
                db.User.Add(user);
                db.SaveChanges();
            }
        }

        public UserEntity CreateUser(int id, string name, EnumRole role, string username, string password)
        {
            UserEntity user = new UserEntity();
            user.id = id;
            user.name = name;
            user.role = role;
            user.username = username;
            user.password = password;

            return user;
        }

        public void ModifyUserToDB(UserEntity user)
        {
            //Preguntar como se usa el using

            using (DbModel db = new DbModel())
            {
                db.Entry(user).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }

        public UserEntity ModifyUser(int id, DbModel db)
        {
            UserEntity user = db.User.Find(id);

            //Ver como vamos a manejar la parte de modificar

            user.name = "Nuevo Nombre";

            return user;
        }

        public void DeleteUserToDB(UserEntity user, DbModel db)
        {
            using (db)
            {
                db.User.Remove(user);
                db.SaveChanges();
            }
        }

        public UserEntity DeleteUser(User us, DbModel db)
        {
            UserEntity user = db.User.Find(us.id);

            return user;
        }
    }
}
