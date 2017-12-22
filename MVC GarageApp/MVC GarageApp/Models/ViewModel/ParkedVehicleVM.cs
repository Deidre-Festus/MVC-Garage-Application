using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_GarageApp.Models.ViewModel
{
    public class ParkedVehicleVM
    {
        public int Id { get; set; }
        public Type Type { get; set; }
        [DisplayName("Reg Nr")]
        public string RegistrationNumber { get; set; }
        public string Color { get; set; }
        [Column(TypeName = "datetime2")]
        public DateTime CheckIn { get; set; }
        [Column(TypeName = "Checkout")]
        public DateTime Checkout { get; set; }
        public string Brand { get; set; }
        public string  Model { get; set; }
        [DisplayName("Nr Of Wheels")]
        public int NumberOfWheels { get; set; }

        public ParkedVehicleVM() { }
        public ParkedVehicleVM(ParkedVehicle x)
        {
            Id = x.Id;
            //Type = x.VehicleType;
            RegistrationNumber = x.RegistrationNumber;
            Color = x.Color;
            CheckIn = x.CheckIn;
            Brand = x.Brand;
            Model = x.Model;
            NumberOfWheels = x.NumberOfWheels;
            
        }
    }
}