using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.IO;
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
        [Required(ErrorMessage ="You should choose on of the list")]
        [ScaffoldColumn(false)]
        public Type Type { get; set; }
        [Required(ErrorMessage ="Registration Number should include three letters and three numbers")]
        [StringLength(6)]
        public string RegistrationNumber { get; set; }
        [Required(ErrorMessage = "Please insert a valid color")]
        [StringLength(20)]
        public string Color { get; set; }
        [Required(ErrorMessage ="Pleas insert a valid name")]
        [StringLength(40)]
        public string  Brand { get; set; }
        [Required(ErrorMessage ="Please insert a valid model")]
        [StringLength(20)]
        public string Model { get; set; }
        [Required(ErrorMessage ="Please insert a valid number of wheels")]
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