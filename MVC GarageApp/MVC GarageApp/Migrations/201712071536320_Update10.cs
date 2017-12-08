namespace MVC_GarageApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update10 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ParkedVehicles", "TStampOut", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ParkedVehicles", "TStampOut", c => c.DateTime(nullable: false));
        }
    }
}
