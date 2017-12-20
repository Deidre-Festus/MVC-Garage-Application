using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MVC_GarageApp.DataAccessLayer;
using MVC_GarageApp.Models;
using PagedList;

namespace MVC_GarageApp.Controllers
{
    public class GarageInfoController : Controller
    {
        private VehicleContext db = new VehicleContext();

        // GET: GarageInfo
        public ActionResult Index(int? page, string searchBy, string search, string sortBy)
        {
            ViewBag.SortOwnerParameter = string.IsNullOrEmpty(sortBy) ? "Owner desc" : "";
            ViewBag.SortRegistrationNumber = sortBy == "RegistrationNumber" ? "RegistrationNumber desc" : "registrationNumber";

            var garageInfo = db.Vehicles.AsQueryable();
            if (searchBy == "RegistrationNumber")
            {
                garageInfo = garageInfo.Where(x => x.RegistrationNumber.Contains(search) || search == null);
            }
            else if (searchBy == "CheckIn")
            {
                garageInfo = garageInfo.Where(x => x.CheckIn.ToString().Contains(search) || search == null);  
            }
            else if (searchBy == "Type")
            {
                garageInfo = garageInfo.Where(x => x.Type.ToString().Contains(search) || search == null);
            }
            else if (searchBy == "Owner")
            {
                garageInfo = garageInfo.Where(x => x.Members.Owner.Contains(search) || search == null);
            }
            else
            {
                garageInfo = garageInfo.Where(x => x.RegistrationNumber.StartsWith(search) || search == null);
            }
            switch (sortBy)
            {
                case "Owner desc":
                    garageInfo = garageInfo.OrderByDescending(x => x.Type);
                    break;
                case "RegistrationNumber":
                    garageInfo = garageInfo.OrderBy(x => x.RegistrationNumber);
                    break;
                case "RegistrationNumber desc":
                    garageInfo = garageInfo.OrderByDescending(x => x.RegistrationNumber);
                    break;
                default:
                    garageInfo = garageInfo.OrderBy(x => x.Type);
                    break;
            }
            return View(garageInfo.OrderByDescending(x => x.CheckIn).ToPagedList(page ?? 1, 7));
        }

        // GET: GarageInfo/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ParkedVehicle parkedVehicle = db.Vehicles.Find(id);
            if (parkedVehicle == null)
            {
                return HttpNotFound();
            }
            return View(parkedVehicle);
        }

        // GET: GarageInfo/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: GarageInfo/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Type,RegistrationNumber,Color,Brand,Model,NumberOfWheels,CheckIn,CheckOut")] ParkedVehicle parkedVehicle)
        {
            if (ModelState.IsValid)
            {
                db.Vehicles.Add(parkedVehicle);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(parkedVehicle);
        }

        // GET: GarageInfo/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ParkedVehicle parkedVehicle = db.Vehicles.Find(id);
            if (parkedVehicle == null)
            {
                return HttpNotFound();
            }
            return View(parkedVehicle);
        }

        // POST: GarageInfo/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Type,RegistrationNumber,Color,Brand,Model,NumberOfWheels,CheckIn,CheckOut")] ParkedVehicle parkedVehicle)
        {
            if (ModelState.IsValid)
            {
                db.Entry(parkedVehicle).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(parkedVehicle);
        }

        // GET: GarageInfo/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ParkedVehicle parkedVehicle = db.Vehicles.Find(id);
            if (parkedVehicle == null)
            {
                return HttpNotFound();
            }
            return View(parkedVehicle);
        }

        // POST: GarageInfo/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ParkedVehicle parkedVehicle = db.Vehicles.Find(id);
            db.Vehicles.Remove(parkedVehicle);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
