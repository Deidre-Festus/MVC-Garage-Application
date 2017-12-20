using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVC_GarageApp.Models
{
    public class Member
    {
        public int Id { get; set; }
        [Required]
        [DisplayName("First Name")]
        public string FName { get; set; }
        [Required]
        [DisplayName("Last Name")]
        public string LName { get; set; }
        [Required]
        [Column(TypeName = "datetime2")]
        [DisplayName("Date of Birth YYYY-MM-DD")]
        public DateTime DateOfBirth { get; set; }
        public string Adress { get; set; }
        public string City { get; set; }
        [StringLength(6)]
        [DisplayName("Post Code")]
        public string PostCode { get; set; }
        [Required]
        [DisplayName("Telephone Nr")]
        public string TelNr { get; set; }
        [DisplayName("Member Nr")]
        public int MemberNr { get; set; }




        public virtual ICollection<ParkedVehicle> ParkedVehicles { get; set; }
    }
}