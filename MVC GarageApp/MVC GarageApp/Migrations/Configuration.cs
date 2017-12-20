namespace MVC_GarageApp.Migrations
{
    using Models;
    using System;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<MVC_GarageApp.DataAccessLayer.VehicleContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MVC_GarageApp.DataAccessLayer.VehicleContext context)
        {
            context.Members.AddOrUpdate(x => x.MemberNr,
                new Models.Member()
                {
                    FName = "Michael",
                    LName = "Jackson",
                    DateOfBirth = DateTime.Now.AddYears(-30),
                    Adress = "123 LA Avenue",
                    City = "Stockholm",
                    PostCode = "123456",
                    MemberNr = 1,
                    TelNr = "0708886987",
                },
                new Member()
                {
                    FName = "Boy",
                    LName = "George",
                    DateOfBirth = DateTime.Now.AddYears(-25),
                    Adress = "123 Rimbo Lane",
                    City = "Washington",
                    PostCode = "555632",
                    MemberNr = 8,
                    TelNr = "0708663211",
                });
                
            context.Types.AddOrUpdate(x=>x.VehTypeName,
                new Models.VehicleType() { VehTypeName="Car"},
                new Models.VehicleType() { VehTypeName="Motorcycle"},
                new Models.VehicleType() { VehTypeName="Boat"},
                new Models.VehicleType() { VehTypeName= "Airplane"});
            



            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            //context.ParkeraVehicles.AddOrUpdate(x => x.RegistrationNumber,
            //    new ParkedVehicle()
            //    {
            //        Type = Models.Type.Car,
            //        RegistrationNumber = "ABC123",
            //        Color = "Red",
            //        Brand = "Ferrari",
            //        Model = "2017",
            //        NumberOfWheels = 4,
            //    },
            //    new ParkedVehicle()
            //    {
            //        Type = Models.Type.Motorcycle,
            //        RegistrationNumber = "MC640",
            //        Color = "Black-orange",
            //        Brand = "BMW",
            //        Model = "2010",
            //        NumberOfWheels = 2,
            //    },
            //    new ParkedVehicle()
            //    {
            //        Type = Models.Type.Boat,
            //        RegistrationNumber = "MC639",
            //        Color = "White",
            //        Brand = "Sad-eye",
            //        Model = "2000",
            //        NumberOfWheels = 0,
            //    },
            //    new ParkedVehicle()
            //    {
            //        Type = Models.Type.Airplane,
            //        RegistrationNumber = "CAR007",
            //        Color = "Silver",
            //        Brand = "F-16",
            //        Model = "2014",
            //        NumberOfWheels = 6,
            //    });

            ////extend the database to 100
            //for (int i = 0; i < 10; i++)
            //    {
            //    context.Vehicles.AddOrUpdate(r => r.RegistrationNumber,

            //         new ParkedVehicle
            //         {
            //        Type = Models.Type.Car,
            //             RegistrationNumber = "CAR00" + i.ToString(),
            //             Color = "White",
            //             Brand = "Mercedes",
            //             Model = "2010",
            //             NumberOfWheels = 4,
            //         });
            //}

            //for (int i = 0; i < 10; i++)
            //{
            //    context.Vehicles.AddOrUpdate(r => r.RegistrationNumber,

            //         new ParkedVehicle
            //         {
            //             Type = Models.Type.Car,
            //             RegistrationNumber = "JPL0" + i.ToString() + "6",
            //        Color = "Red",
            //        Brand = "Ferrari",
            //             Model = "2016",
            //        NumberOfWheels = 4,
            //         });
            //}

            //for (int i = 0; i < 10; i++)
            //    {
            //    context.Vehicles.AddOrUpdate(r => r.RegistrationNumber,

            //         new ParkedVehicle
            //         {
            //             Type = Models.Type.Boat,
            //             RegistrationNumber = "BOA" + i.ToString() + "82",
            //             Color = "Blue",
            //             Brand = "Yamaha",
            //        Model = "2010",
            //             NumberOfWheels = 0,
            //         });
            //}
            //for (int i = 0; i < 10; i++)
            //{
            //    context.Vehicles.AddOrUpdate(r => r.RegistrationNumber,

            //         new ParkedVehicle
            //    {
            //        Type = Models.Type.Boat,
            //             RegistrationNumber = "PLK" + i.ToString() + "99",
            //             Color = "Yellow/White",
            //             Brand = "Kawasaki",
            //             Model = "2016",
            //        NumberOfWheels = 0,
            //         });
            //}
            //for (int i = 0; i < 10; i++)
            //{
            //    context.Vehicles.AddOrUpdate(r => r.RegistrationNumber,

            //         new ParkedVehicle
            //    {
            //        Type = Models.Type.Airplane,
            //             RegistrationNumber = "ÄPÅ" + i.ToString() + "47",
            //             Color = "White",
            //             Brand = "Airbus",
            //             Model = "2009",
            //        NumberOfWheels = 6,
            //    });
            //}
            //for (int i = 0; i < 10; i++)
            //{
            //    context.Vehicles.AddOrUpdate(r => r.RegistrationNumber,

            //         new ParkedVehicle
            //         {
            //             Type = Models.Type.Airplane,
            //             RegistrationNumber = "PÖÄ" + i.ToString() + "78",
            //             Color = "Green",
            //             Brand = "Boeing",
            //             Model = "2013",
            //             NumberOfWheels = 8,
            //         });
            //}
            //for (int i = 0; i < 10; i++)
            //{
            //    context.Vehicles.AddOrUpdate(r => r.RegistrationNumber,

            //         new ParkedVehicle
            //         {
            //             Type = Models.Type.Motorcycle,
            //             RegistrationNumber = "MCP00" + i.ToString(),
            //             Color = "Black",
            //             Brand = "Harley",
            //             Model = "2015",
            //             NumberOfWheels = 2,
            //         });
            //}
            //for (int i = 0; i < 10; i++)
            //{
            //    context.Vehicles.AddOrUpdate(r => r.RegistrationNumber,

            //         new ParkedVehicle
            //         {
            //             Type = Models.Type.Motorcycle,
            //             RegistrationNumber = "JOI" + i.ToString() + "65",
            //             Color = "Silver",
            //             Brand = "Chopper",
            //             Model = "2014",
            //             NumberOfWheels = 2,
            //         });
            //}
            }
        }
    }
