namespace MVC_GarageApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initi2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ParkedVehicles", "Color", c => c.String(nullable: false));
            AlterColumn("dbo.ParkedVehicles", "Brand", c => c.String(nullable: false));
            AlterColumn("dbo.ParkedVehicles", "Model", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ParkedVehicles", "Model", c => c.String());
            AlterColumn("dbo.ParkedVehicles", "Brand", c => c.String());
            AlterColumn("dbo.ParkedVehicles", "Color", c => c.String());
        }
    }
}
