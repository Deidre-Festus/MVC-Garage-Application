using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_GarageApp.Models
{
    public class VehicleType
    {
        public int Id { get; set; }
        public string VehTypeName { get; set; }

        public virtual ICollection<ParkedVehicle> ParkedVehicles { get; set; }

    }

    //public enum Type
    //{
    //    Car,
    //    Motorcycle,
    //    Boat,
    //    Airplane
    //}
}