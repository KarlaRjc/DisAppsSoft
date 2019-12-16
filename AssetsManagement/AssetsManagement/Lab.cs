using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetsManagement
{
    public class Lab
    {
        public int id { get; set; }

        public string name { get; set; }

        /// <summary>
        /// Creates a LabEntity,receives as parameters several attributes related to a lab 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        public static LabEntity CreateLab(int id, string name)
        {
            LabEntity labentity = new LabEntity();
            labentity.id = id;
            labentity.name = name;

            return labentity;

        }

        /// <summary>
        /// Modifies an existing LabEntity, receives as parameters the LabEntity that wants to be modified and a Lab with the updated information
        /// </summary>
        /// <param name="lab"></param>
        /// <param name="labentity"></param>
        /// <returns></returns>
        public static LabEntity ModifyLab(Lab lab, LabEntity labentity)
        {
            labentity.id = lab.id;
            labentity.name = lab.name;

            return labentity;
        }

        public static LabEntity GetLabById(int id)
        {
            LabEntity lab = null;
            using (DbModel db = new DbModel())
            {
                lab = db.Lab.Where(x => x.id == id).FirstOrDefault();
            }
            return lab;
        }


    }
}
