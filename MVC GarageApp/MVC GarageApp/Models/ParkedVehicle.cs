using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_GarageApp.Models
{
    public enum Type
    {
        Aeroplane,
        Boat,
        Car,
        Motorcycle,
    }

    public class ParkedVehicle
    {
        public int Id { get; set; }
        [Required]
        [DisplayName("Vehicle Type")]
        public Type Type { get; set; }
        [Required]
        [DisplayName("Registration Number")]
        public string RegistrationNumber { get; set; }
        [Required]
        [DisplayName("Vehicle Colour")]
        public string Colour { get; set; }
        [Required]
        [DisplayName("Vehicle Brand")]
        public string Brand { get; set; }
        [Required]
        [DisplayName("Vehicle Model")]
        public string Model { get; set; }
        [Required]
        [DisplayName("Number of Wheels")]
        public int NumberOfWheels { get; set; }

       
        [DataType(DataType.DateTime)]
        [DisplayName("Parking Start Time")]
        public DateTime TStamp { get; set; }
            

        }
    }
