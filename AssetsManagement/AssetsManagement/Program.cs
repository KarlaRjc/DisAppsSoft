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


            //Así se crea un UserEntity con los parámetros
            //Importante! El ID que se va a asignar no es el que uno lo ponga, es un número consecutivo que depende de la DB

            UserEntity userentity = User.CreateUser(7, "Prueba", EnumRole.Admin, "user", "password");

            //Así se agrega ese user a la DB
            UserEntity.CreateUserToDB(userentity);

            //Obtiene el rol del userentity
            Console.WriteLine(UserEntity.GetUserRole(userentity));

            //Para usar el Modify y el delete, se reciben parámetros user, no user entity entonces hay que tener un usuario
            //El usuario no se puede instanciar, hay que darle un tipo
            Gatherer user = new Gatherer();
            user.id = 10;
            user.name = "Esteban";
            user.role = EnumRole.Gatherer;
            user.username = "jmero";
            user.password = "1243";
            
            //Así se modifica un usuario (la información en user es la nueva, que va a modificar la que está en la DB)
            UserEntity.ModifyUserToDB(user);

            //Así se borra
            UserEntity.DeleteUserToDB(user);


            //Así se crea un AssetEntity con los parámetros
            //Importante! El ID que se va a asignar no es el que uno lo ponga, es un número consecutivo que depende de la DB

            AssetEntity assetentity = Asset.CreateAsset(1, "Desc", "Bra", "Mod", "Ser", "Stat");
            
            //Así se agrega a la DB
            
            AssetEntity.CreateAssetToDB(assetentity);

            //Para usar el Modify y el delete, se reciben parámetros asset, no asset entity entonces hay que tener un asset
            Asset asset = new Asset();
            asset.id = 1;
            asset.description = "Cable";
            asset.brand = "System";
            asset.model = "Ia 300";
            asset.series = "1254asd875as";
            asset.state = "In Stock";

            //Así se modifica un asset (la información en asset es la nueva, que va a modificar la que está en la DB)
            AssetEntity.ModifyAssetToDB(asset);

            //Así se borra
            AssetEntity.DeleteAssetToDB(asset);



            //Así se crea un LabEntity con los parámetros
            //Importante! El ID que se va a asignar no es el que uno lo ponga, es un número consecutivo que depende de la DB

            LabEntity labentity = Lab.CreateLab(20, "Lab 2");

            //Así se agrega a la DB
            LabEntity.CreateLabToDB(labentity);

            //Para usar el Modify y el delete, se reciben parámetros lab, no lab entity entonces hay que tener un asset
            Lab lab = new Lab();
            lab.id = 3;
            lab.name = "Laboratiorio3";


            //Así se modifica un lab (la información en lab es la nueva, que va a modificar la que está en la DB)
            LabEntity.ModifyLabToDB(lab);

            //Así se borra
            LabEntity.DeleteLabToDB(lab);

            Console.ReadLine();
        }
    }
}

