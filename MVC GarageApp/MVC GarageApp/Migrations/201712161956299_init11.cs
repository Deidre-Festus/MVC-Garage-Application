namespace MVC_GarageApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init11 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ParkedVehicles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Type = c.Int(nullable: false),
                        RegistrationNumber = c.String(nullable: false, maxLength: 6),
                        Color = c.String(nullable: false, maxLength: 20),
                        Brand = c.String(nullable: false, maxLength: 40),
                        Model = c.String(nullable: false, maxLength: 20),
                        NumberOfWheels = c.Int(nullable: false),
                        CheckIn = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        CheckOut = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ParkedVehicles");
        }
    }
}
