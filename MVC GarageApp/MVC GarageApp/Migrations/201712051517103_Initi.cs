namespace MVC_GarageApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initi : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ParkedVehicles", "Type", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ParkedVehicles", "Type", c => c.String());
        }
    }
}
