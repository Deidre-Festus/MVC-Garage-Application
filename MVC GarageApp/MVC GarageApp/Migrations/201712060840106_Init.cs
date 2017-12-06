namespace MVC_GarageApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ParkedVehicles", "RegistrationNumber", c => c.String(nullable: false, maxLength: 6));
            AlterColumn("dbo.ParkedVehicles", "Color", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.ParkedVehicles", "Brand", c => c.String(nullable: false, maxLength: 40));
            AlterColumn("dbo.ParkedVehicles", "Model", c => c.String(nullable: false, maxLength: 20));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ParkedVehicles", "Model", c => c.String(nullable: false));
            AlterColumn("dbo.ParkedVehicles", "Brand", c => c.String(nullable: false));
            AlterColumn("dbo.ParkedVehicles", "Color", c => c.String(nullable: false));
            AlterColumn("dbo.ParkedVehicles", "RegistrationNumber", c => c.String(nullable: false));
        }
    }
}
