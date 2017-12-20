using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace MVC_GarageApp.Models
{
    public class VehicleType
    {
        public int Id { get; set; }

        [DisplayName("Vehicle Type")]
        public Type Type { get; set; }

        public virtual ICollection<ParkedVehicle> parkedVehicles { get; set; }
    }
    public enum Type
    {
        Car,
        Motorcycle,
        Boat,
        Airplane
    }
}