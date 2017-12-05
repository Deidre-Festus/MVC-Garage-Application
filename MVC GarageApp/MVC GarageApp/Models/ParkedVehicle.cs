using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_GarageApp.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class ParkedVehicle
    {
        public int Id { get; set; }
       
        public Type Type { get; set; }
        [Required]
        public string RegistrationNumber { get; set; }
        [Required]
        public string Color { get; set; }
        [Required]
        public string  Brand { get; set; }
        [Required] 
        public string Model { get; set; }
        [Required] 
        public int NumberOfWheels { get; set; }
    }

    //enum for dropdown list
    public enum Type
    {
        Car,
        Motorcycle,
        Boat,
        Airplane
    }
}