namespace AssetsManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AssetEntities",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        LabEntity_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.LabEntities", t => t.LabEntity_id)
                .Index(t => t.LabEntity_id);
            
            CreateTable(
                "dbo.AssetTransferHistoryEntities",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        transferDate = c.DateTime(nullable: false),
                        description = c.String(),
                        assetTransfered_id = c.Int(),
                        transferedByUser_id = c.Int(),
                        transferedFromLab_id = c.Int(),
                        transferedToLab_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.AssetEntities", t => t.assetTransfered_id)
                .ForeignKey("dbo.UserEntities", t => t.transferedByUser_id)
                .ForeignKey("dbo.LabEntities", t => t.transferedFromLab_id)
                .ForeignKey("dbo.LabEntities", t => t.transferedToLab_id)
                .Index(t => t.assetTransfered_id)
                .Index(t => t.transferedByUser_id)
                .Index(t => t.transferedFromLab_id)
                .Index(t => t.transferedToLab_id);
            
            CreateTable(
                "dbo.UserEntities",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        role = c.Int(nullable: false),
                        username = c.String(),
                        password = c.String(),
                        secretQuestion = c.String(),
                        secretAnswer = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.LabEntities",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AssetTransferHistoryEntities", "transferedToLab_id", "dbo.LabEntities");
            DropForeignKey("dbo.AssetTransferHistoryEntities", "transferedFromLab_id", "dbo.LabEntities");
            DropForeignKey("dbo.AssetEntities", "LabEntity_id", "dbo.LabEntities");
            DropForeignKey("dbo.AssetTransferHistoryEntities", "transferedByUser_id", "dbo.UserEntities");
            DropForeignKey("dbo.AssetTransferHistoryEntities", "assetTransfered_id", "dbo.AssetEntities");
            DropIndex("dbo.AssetTransferHistoryEntities", new[] { "transferedToLab_id" });
            DropIndex("dbo.AssetTransferHistoryEntities", new[] { "transferedFromLab_id" });
            DropIndex("dbo.AssetTransferHistoryEntities", new[] { "transferedByUser_id" });
            DropIndex("dbo.AssetTransferHistoryEntities", new[] { "assetTransfered_id" });
            DropIndex("dbo.AssetEntities", new[] { "LabEntity_id" });
            DropTable("dbo.LabEntities");
            DropTable("dbo.UserEntities");
            DropTable("dbo.AssetTransferHistoryEntities");
            DropTable("dbo.AssetEntities");
        }
    }
}
