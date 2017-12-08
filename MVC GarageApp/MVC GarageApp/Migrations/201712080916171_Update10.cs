namespace MVC_GarageApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update10 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ParkedVehicles", "Color", c => c.String(nullable: false, maxLength: 20));
            AddColumn("dbo.ParkedVehicles", "CheckIn", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
            AlterColumn("dbo.ParkedVehicles", "RegistrationNumber", c => c.String(nullable: false, maxLength: 6));
            AlterColumn("dbo.ParkedVehicles", "Brand", c => c.String(nullable: false, maxLength: 40));
            AlterColumn("dbo.ParkedVehicles", "Model", c => c.String(nullable: false, maxLength: 20));
            DropColumn("dbo.ParkedVehicles", "Colour");
            DropColumn("dbo.ParkedVehicles", "TStampIn");
            DropColumn("dbo.ParkedVehicles", "TStampOut");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ParkedVehicles", "TStampOut", c => c.DateTime());
            AddColumn("dbo.ParkedVehicles", "TStampIn", c => c.DateTime(nullable: false));
            AddColumn("dbo.ParkedVehicles", "Colour", c => c.String(nullable: false));
            AlterColumn("dbo.ParkedVehicles", "Model", c => c.String(nullable: false));
            AlterColumn("dbo.ParkedVehicles", "Brand", c => c.String(nullable: false));
            AlterColumn("dbo.ParkedVehicles", "RegistrationNumber", c => c.String(nullable: false));
            DropColumn("dbo.ParkedVehicles", "CheckIn");
            DropColumn("dbo.ParkedVehicles", "Color");
        }
    }
}
