using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssetsManagement
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());

            /*UserEntity user = User.CreateUser(7, "Nuevo", EnumRole.Admin, "user", "password");
            UserEntity.CreateUserToDB(user);
            Console.WriteLine(User.GetUserRole(user));
            UserEntity.ModifyUserToDB(1);
            UserEntity.DeleteUserToDB(3);*/

            /*AssetEntity asset = AssetEntity.CreateAsset(7, "Descripcion", "Marca", "Modelo", "Serie", "Estado");
            AssetEntity.CreateAssetToDB(asset);
            AssetEntity.ModifyAssetToDB(1);
            AssetEntity.DeleteAssetToDB(2);*/

            /*LabEntity lab = LabEntity.CreateLab(20, "Lab 1");
            LabEntity.CreateLabToDB(lab);
            LabEntity.ModifyLabToDB(1);
            LabEntity.DeleteLabToDB(2);*/

            Console.ReadLine();
        }
    }
}
