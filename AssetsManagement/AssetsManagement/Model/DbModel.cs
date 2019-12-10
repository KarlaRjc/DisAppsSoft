namespace AssetsManagement
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class DbModel : DbContext
    {
        public DbModel()
            : base("name=DbModel") { }
        public virtual DbSet<UserEntity> User { get; set; }
        public virtual DbSet<LabEntity> Lab { get; set; }
        public virtual DbSet<AssetTransferHistoryEntity> AssetTransferHistory { get; set; }
        public virtual DbSet<AssetEntity> Asset { get; set; }
        
    }
}