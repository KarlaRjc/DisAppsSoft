namespace AssetsManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AssetEntity : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AssetEntities", "description", c => c.String());
            AddColumn("dbo.AssetEntities", "brand", c => c.String());
            AddColumn("dbo.AssetEntities", "model", c => c.String());
            AddColumn("dbo.AssetEntities", "series", c => c.String());
            AddColumn("dbo.AssetEntities", "state", c => c.String());
            AddColumn("dbo.AssetEntities", "lab", c => c.Int(nullable: false));
            DropColumn("dbo.AssetEntities", "name");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AssetEntities", "name", c => c.String());
            DropColumn("dbo.AssetEntities", "lab");
            DropColumn("dbo.AssetEntities", "state");
            DropColumn("dbo.AssetEntities", "series");
            DropColumn("dbo.AssetEntities", "model");
            DropColumn("dbo.AssetEntities", "brand");
            DropColumn("dbo.AssetEntities", "description");
        }
    }
}
