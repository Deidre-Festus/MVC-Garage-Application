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

        [Required(ErrorMessage ="Please enter your first name.")]
        [DisplayName("First Name")]
        [DisplayFormat(NullDisplayText ="Undefined")]
        public string FName { get; set; }

        [Required(ErrorMessage ="Please enter your last name.")]
        [DisplayName("Last Name")]
        [DisplayFormat(NullDisplayText ="Undefined")]
        public string LName { get; set; }

        [Required]
        [Column(TypeName = "datetime2")]
        [DisplayName("Date of Birth YYYY-MM-DD")]
        public DateTime DateOfBirth { get; set; }

        [Required(ErrorMessage ="Please enter the membership.")]
        [DisplayName("Member Ship")]
        [DisplayFormat(NullDisplayText ="Undefined")]
        public int MemberShip { get; set; }

        [Required(ErrorMessage ="Please enter your telephone number.")]
        [DisplayName("Telephone Number")]
        [DisplayFormat(NullDisplayText ="Undefined")]
        public string TelNumber { get; set; }

        [Required(ErrorMessage ="Please enter your address.")]
        [DisplayName("Address")]
        [DisplayFormat(NullDisplayText ="Undefined")]
        public string Address { get; set; }

        [Required(ErrorMessage ="Please enter the city.")]
        [DisplayName("City")]
        [DisplayFormat(NullDisplayText ="Undefined")]
        public string City { get; set; }

        [Required(ErrorMessage ="Please enter your post code.")]
        [DisplayName("Post Code")]
        [DisplayFormat(NullDisplayText ="Undefined")]
        public string Pcode { get; set; }

        [Required(ErrorMessage ="Date is not valid")]
        [Column(TypeName="datetime2")]
        public DateTime StartDate { get; set; }

        public string Owner
        {
            get
            {
                return FName + " " + LName;
            }
        }


        public virtual ICollection<ParkedVehicle> parkedVehicles { get; set; }
    }
}