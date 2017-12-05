namespace MVC_GarageApp.Migrations
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MVC_GarageApp.DataAccessLayer.VehicleContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MVC_GarageApp.DataAccessLayer.VehicleContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            context.ParkeraVehicles.AddOrUpdate(x => x.Type,
                new ParkedVehicle()
                {
                    Type = Models.Type.Car,
                    RegistrationNumber = "ABC123",
                    Color = "Red",
                    Brand = "Ferrari",
                    Model = "2017",
                    NumberOfWheels = 4,
                },
                new ParkedVehicle()
                {
                    Type = Models.Type.Motorcycle,
                    RegistrationNumber = "MC639",
                    Color = "Black-orange",
                    Brand = "BMW",
                    Model = "2010",
                    NumberOfWheels = 2,
                },
                new ParkedVehicle()
                {
                    Type = Models.Type.Boat,
                    RegistrationNumber = "MC639",
                    Color = "White",
                    Brand = "Sad-eye",
                    Model = "2000",
                    NumberOfWheels = 0,
                },
                new ParkedVehicle()
                {
                    Type = Models.Type.Airplane,
                    RegistrationNumber = "CAR007",
                    Color = "Silver",
                    Brand = "F-16",
                    Model = "2014",
                    NumberOfWheels = 6,
                });
        }
    }
}
