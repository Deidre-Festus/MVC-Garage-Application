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
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(MVC_GarageApp.DataAccessLayer.VehicleContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            context.Vehicles.AddOrUpdate(x => x.RegistrationNumber,
                new ParkedVehicle()
                {
                    Type = Models.Type.Car,                   
                    RegistrationNumber = "ABC123",
                    Colour = "Blue",
                    Brand = "Audi",
                    Model = "2004",
                    NumberOfWheels = 4,
                    TStamp = DateTime.Now,
                    
                },
                new ParkedVehicle()
                {
                    Type = Models.Type.Motorcycle,
                    RegistrationNumber = "MC639",
                    Colour = "Red",
                    Brand = "Yamaha",
                    Model = "2016",
                    NumberOfWheels = 2,
                    TStamp = DateTime.Now,

                },
                new ParkedVehicle()
                {
                    Type = Models.Type.Car,
                    RegistrationNumber = "CAR007",
                    Colour = "Silver",
                    Brand = "Toyota",
                    Model = "2017",
                    NumberOfWheels = 4,
                    TStamp = DateTime.Now,

                });



        }
    }
}
