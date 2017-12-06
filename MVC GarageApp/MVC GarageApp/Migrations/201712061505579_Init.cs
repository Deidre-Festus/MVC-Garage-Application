namespace MVC_GarageApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
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
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ParkedVehicles");
        }
    }
}
