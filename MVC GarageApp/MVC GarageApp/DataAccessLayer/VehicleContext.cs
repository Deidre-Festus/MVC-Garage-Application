using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MVC_GarageApp.DataAccessLayer
{
    public class VehicleContext : DbContext
    {
        public VehicleContext() : base ("MVC-Garage") {}
                                                                              
        public DbSet<Models.ParkedVehicle> Vehicles { get; set; }

        public System.Data.Entity.DbSet<MVC_GarageApp.Models.Member> Members { get; set; }

        public System.Data.Entity.DbSet<MVC_GarageApp.Models.VehicleType> Types { get; set; }
    }
}