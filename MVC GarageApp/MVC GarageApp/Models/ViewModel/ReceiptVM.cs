using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVC_GarageApp.Models.ViewModel
{
    public class ReceiptVM
    {
        private int pricePerHour = 50;


        public int Id { get; set; }

        public Type Type { get; set; }

        public string RegistrationNumber { get; set; }

        [Column(TypeName ="datetime2")]
        public DateTime CheckIn { get; set; }

        [Column(TypeName = "Checkout")]
        public DateTime Checkout { get; set; }

        [DataType(DataType.Currency)]
        [DisplayFormat(DataFormatString ="{0:C}")]
        [DisplayName("Price Per Hour")]
        public int PricePerHour { get { return 50; } }

        [DisplayFormat(DataFormatString ="{0:hh\\:mm\\:ss}")]
        [DisplayName("Total parking time")]
        public TimeSpan TotalTime { get { return (Checkout - CheckIn); } }

        [DataType(DataType.Currency)]
        [DisplayFormat(DataFormatString = "{0:C}")]
        [DisplayName("Total")]
        public double Sum { get { return TotalTime.TotalHours * PricePerHour; } }


        public ReceiptVM () { }
        public ReceiptVM (ParkedVehicleVM x)
        {
            Id = x.Id;
            Type = x.Type;
            RegistrationNumber = x.RegistrationNumber;
            CheckIn = x.CheckIn;
            Checkout = x.Checkout;
        }
    }
}