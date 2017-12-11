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
    }
}