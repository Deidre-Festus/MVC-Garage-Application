using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVC_GarageApp.Models.ViewModel
{
    public class ParkedVehicleVM
    {
        public int Id { get; set; }
        public Type Type { get; set; }
        public string RegistrationNumber { get; set; }
        public string Color { get; set; }
        [Column(TypeName = "datetime2")]
        public DateTime CheckIn { get; set; }
        [Column(TypeName = "Checkout")]
        public DateTime Checkout { get; set; }
        public string Brand { get; set; }
        public string  Model { get; set; }
        public int NumberOfWheels { get; set; }

        public ParkedVehicleVM() { }
        public ParkedVehicleVM(ParkedVehicle x)
        {
            Id = x.Id;
            Type = x.Type;
            RegistrationNumber = x.RegistrationNumber;
            Color = x.Color;
            CheckIn = x.CheckIn;
            Brand = x.Brand;
            Model = x.Model;
            NumberOfWheels = x.NumberOfWheels;
            
        }
    }
}