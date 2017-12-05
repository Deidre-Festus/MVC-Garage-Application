namespace MVC_GarageApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initi1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ParkedVehicles", "RegistrationNumber", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ParkedVehicles", "RegistrationNumber", c => c.String());
        }
    }
}
