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



        /// <summary>
        /// Adds a new LabEntity to the Database
        /// </summary>
        /// <param name="labentity"></param>
        public static void CreateLabToDB(LabEntity labentity)
        {
            //Opens a conection with the DB
            using (DbModel db = new DbModel())
            {
                //Adds a Lab
                db.Lab.Add(labentity);

                //Saves the changes
                db.SaveChanges();
            }
        }


        /// <summary>
        /// Modifies an existing LabEntity in the Database, searches for the corresponding LabEntity and modifies it
        /// </summary>
        /// <param name="lab"></param>
        public static void ModifyLabToDB(Lab lab)
        {
            //Opens a conection with the DB
            using (DbModel db = new DbModel())
            {
                //Searches for the labentity related to that lab id
                LabEntity labentity = db.Lab.SingleOrDefault(l => l.id == lab.id);

                //Calls ModifyLab function, assigns to labentity the new parameters
                labentity = Lab.ModifyLab(lab, labentity);

                //Modifies the record in the DB
                db.Entry(labentity).State = System.Data.Entity.EntityState.Modified;

                //Saves the changes
                db.SaveChanges();
            }
        }


        /// <summary>
        /// Deletes a LabEntity from the Database, searches for the corresponding LabEntity and deletes it
        /// </summary>
        /// <param name="lab"></param>
        public static void DeleteLabToDB(Lab lab)
        {
            //Opens a conection with the DB
            using (DbModel db = new DbModel())
            {
                //Searches for the labentity related to that lab id
                LabEntity labentity = db.Lab.SingleOrDefault(l => l.id == lab.id);

                //Removes the labentty from the DB
                db.Lab.Remove(labentity);

                //Saves the changes
                db.SaveChanges();
            }
        }
    }
}
