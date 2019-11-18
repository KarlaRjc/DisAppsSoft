using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetsManagement
{
    public class AssetEntity
    {
        [Key]
        public int id { get; set; }

        public string description { get; set; }

        public string brand { get; set; }

        public string model { get; set; }

        public string series { get; set; }

        public string state { get; set; }

        public static void CreateAssetToDB(AssetEntity asset)
        {
            using (DbModel db = new DbModel())
            {
                db.Asset.Add(asset);
                db.SaveChanges();
            }
        }

        public static AssetEntity CreateAsset(int id, string description, string brand, string model, string series, string state)
        {
            AssetEntity asset = new AssetEntity();
            asset.id = id;
            asset.description = description;
            asset.brand = brand;
            asset.model = model;
            asset.series = series;
            asset.state = state;
            return asset;
        }

        public static void ModifyAssetToDB(int id)
        {
            using (DbModel db = new DbModel())
            {
                AssetEntity asset = db.Asset.SingleOrDefault(a => a.id == id);
                asset.description = "Nueva Descripción";
                db.Entry(asset).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }

        public static void DeleteAssetToDB(int id)
        {
            using (DbModel db = new DbModel())
            {
                AssetEntity asset = db.Asset.SingleOrDefault(a => a.id == id);
                db.Asset.Remove(asset);
                db.SaveChanges();
            }
        }

    }
}
