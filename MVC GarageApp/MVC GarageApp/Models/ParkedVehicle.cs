using MVC_GarageApp.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
        [Required(ErrorMessage ="You should choose one of the list")]
        [ScaffoldColumn(false)]
        [DisplayFormat(NullDisplayText = "Undefined")]
        [DisplayName("Vehicle Type")]
        public Type Type { get; set; }
        [Required(ErrorMessage ="Registration Number should include three letters and three numbers")]
        [StringLength(6)]
        [DisplayFormat(NullDisplayText = "Undefined")]
        [DisplayName("Registration Number")]
        public string RegistrationNumber { get; set; }
        [Required(ErrorMessage = "Please insert a valid color")]
        [StringLength(20)]
        [DisplayFormat(NullDisplayText = "Undefined")]
        [MaxWords(1)]
        public string Color { get; set; }
        [Required(ErrorMessage ="Please insert a valid name")]
        [StringLength(40)]
        [DisplayFormat(NullDisplayText = "Undefined")]
        public string  Brand { get; set; }
        [Required(ErrorMessage ="Please insert a valid model")]
        [StringLength(20)]
        [DisplayFormat(NullDisplayText = "Undefined")]
        public string Model { get; set; }
        [Required(ErrorMessage ="Please insert a valid number of wheels")]
        [DisplayFormat(NullDisplayText = "Undefined")]
        [MaxWords(1)]
        [DisplayName("Number of Wheels")]
        public int NumberOfWheels { get; set; }
        [Column(TypeName ="datetime2")]
        [DisplayName("Time Checked In")]
        public DateTime CheckIn { get; set; }
        [Column(TypeName = "datetime2")]
        [DisplayName("Time Checked Out")]
        public DateTime CheckOut { get; set; }

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