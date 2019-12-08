namespace AssetsManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class LabEntity : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.LabEntities", "name", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.LabEntities", "name");
        }
    }
}
