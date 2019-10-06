namespace AssetsManagement
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class DbModel : DbContext
    {
        public DbModel()
            : base("name=DbModel") { }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<Lab> Lab { get; set; }
        public virtual DbSet<AssetTransferHistory> AssetTransferHistory { get; set; }
        public virtual DbSet<Asset> Asset { get; set; }
    }
}