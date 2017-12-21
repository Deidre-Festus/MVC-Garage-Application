using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using MVC_GarageApp.Models;

namespace MVC_GarageApp.DataAccessLayer
{
    public class VehicleContext : DbContext
    {
        public VehicleContext() : base ("MVC-Garage") {}
                                                                              
        public DbSet<ParkedVehicle> Vehicles { get; set; }

        public DbSet<Member> Members { get; set; }
        public DbSet<VehicleType> Types { get; set; }
    }
}