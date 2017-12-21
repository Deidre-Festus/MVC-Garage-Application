using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVC_GarageApp.Models.ViewModel
{
    public class MemberVehType
    {
        public int Id { get; set; }
        [DisplayName("Member Id")]
        public int MemberId { get; set; }

        [DisplayName("Vehicle Type")]
        public int VehicleTypeId { get; set; }
        public string VehTypeName { get; set; }

        [StringLength(6)]
        public string RegistrationNumber { get; set; }
        public string Color { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int NumberOfWheels { get; set; }

        [Column(TypeName = "datetime2")]
        [DisplayName("Time Checked In")]
        public DateTime CheckIn { get; set; }

        [Column(TypeName = "datetime2")]
        [DisplayName("Time Checked Out")]
        public DateTime CheckOut { get; set; }

        public string FName { get; set; }
        public string LName { get; set; }
        public string Owner
        {
            get
            {
                return FName + " " + LName;
            }
        }

    }
}