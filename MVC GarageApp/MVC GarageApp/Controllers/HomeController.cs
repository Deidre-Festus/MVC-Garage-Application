using System.Web.Mvc;
using MVC_GarageApp.Models.ViewModel;
using System.Net.Mail;
using System;
using MVC_GarageApp.Models;
using System.Web.Helpers;

namespace MVC_GarageApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }


        
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            
            return View();
        }
    }  
}
