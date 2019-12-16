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
        public EnumRole role { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string secretQuestion { get; set; }
        public string secretAnswer { get; set; }

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

        public static UserEntity MapUserInputToUserEntity(string name, EnumRole role, string username, string password, string userQuestion, string userAnswer)
        {
            var user = GetUserByUsername(username);
            user.name = name;
            user.role = role;
            user.username = username; // check if it exists
            user.password = password;
            user.secretQuestion = userQuestion;
            user.secretAnswer = userAnswer;
            return user;
        }

        public static string GetSecretQuestionByUsername(string username)
        {
            using (DbModel db = new DbModel())
            {
                return db.User.Where(x => x.username == username).Select(x => x.secretQuestion).FirstOrDefault();
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

        public static void TransferAsset(string serial, string username, int idLab, int toLab)
        {
            AssetEntity asset = AssetEntity.GetAssetBySerialNumber(serial);
            UserEntity user = UserEntity.GetUserByUsername(username);
            string description = asset.description;
            LabEntity fromLab = Lab.GetLabById(idLab);
            LabEntity tolabtransf = Lab.GetLabById(toLab);
            AssetTransferHistoryEntity assettransferred = AssetTransferHistory.CreateAssetTransferHistory(asset, DateTime.Now, fromLab, tolabtransf, user, description);
        }
        public static UserEntity ModifyUser(UserEntity userentity)
        {
            return userentity;
        }
    }
}
