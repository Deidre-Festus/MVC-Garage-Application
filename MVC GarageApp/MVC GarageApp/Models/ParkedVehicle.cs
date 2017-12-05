using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_GarageApp.Models
{
    public class ParkedVehicle
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string RegistrationNumber { get; set; }
        public string Colour { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int NumberOfWheels { get; set; }

    }
}