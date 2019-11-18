using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetsManagement
{
    public class LabEntity
    {
        [Key]
        public int id { get; set; }

        public string name { get; set; }


        public List<AssetEntity> Assets {get; set;}

        public static void CreateLabToDB(LabEntity lab)
        {
            using (DbModel db = new DbModel())
            {
                db.Lab.Add(lab);
                db.SaveChanges();
            }
        }

        public static LabEntity CreateLab(int id, string name)
        {
            LabEntity lab = new LabEntity();
            lab.id = id;
            lab.name = name;
            return lab;
        }

        public static void ModifyLabToDB(int id)
        {
            using (DbModel db = new DbModel())
            {
                LabEntity lab = db.Lab.SingleOrDefault(l => l.id == id);
                lab.name = "Nuevo Nombre";
                db.Entry(lab).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }

        public static void DeleteLabToDB(int id)
        {
            using (DbModel db = new DbModel())
            {
                LabEntity lab = db.Lab.SingleOrDefault(l => l.id == id);
                db.Lab.Remove(lab);
                db.SaveChanges();
            }
        }
    }
}
