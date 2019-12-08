namespace AssetsManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AssetEntity1 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.AssetEntities", "lab");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AssetEntities", "lab", c => c.Int(nullable: false));
        }
    }
}
