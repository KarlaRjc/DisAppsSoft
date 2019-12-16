namespace AssetsManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.AssetEntities", "lab_id", "dbo.Labs");
            DropIndex("dbo.AssetEntities", new[] { "lab_id" });
            DropColumn("dbo.AssetEntities", "lab_id");
            DropTable("dbo.Labs");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Labs",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            AddColumn("dbo.AssetEntities", "lab_id", c => c.Int());
            CreateIndex("dbo.AssetEntities", "lab_id");
            AddForeignKey("dbo.AssetEntities", "lab_id", "dbo.Labs", "id");
        }
    }
}
