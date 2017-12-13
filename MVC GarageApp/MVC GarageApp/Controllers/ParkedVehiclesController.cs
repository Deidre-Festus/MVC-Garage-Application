using System;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using MVC_GarageApp.DataAccessLayer;
using MVC_GarageApp.Models;
using PagedList;

namespace MVC_GarageApp.Controllers
{
    public class ParkedVehiclesController : Controller
    {
        private VehicleContext db = new VehicleContext();

        // GET: ParkedVehicles
        //[OutputCache(Duration = 10)]
        public ActionResult Index(int? page, string searchBy, string search, string sortBy)     
        {
            //System.Threading.Thread.Sleep(1000);
            ViewBag.SortTypeParameter = string.IsNullOrEmpty(sortBy) ? "Type desc" : "";
            ViewBag.SortRegistrationNumber = sortBy == "RegistrationNumber" ? "RegistrationNumber desc" : "RegistrationNumber";

            var parkeraVehicles = db.Vehicles.AsQueryable();
            if (searchBy == "RegistrationNumber")
            {
                parkeraVehicles = parkeraVehicles.Where(x => x.RegistrationNumber.Contains(search) || search == null);
            }
            else if (searchBy == "CheckIn")
            {
                parkeraVehicles = parkeraVehicles.Where(x => x.CheckIn.ToString().Contains(search) || search == null);
            }
            else if (searchBy == "Type")
            {
                parkeraVehicles = parkeraVehicles.Where(x => x.Type.ToString().Contains(search)  || search == null);
            }
            //else if (searchBy == "Brand")
            //{
            //    parkeraVehicles = parkeraVehicles.Where(x => x.Brand == search || search == null);
            //}
            else if (searchBy == "Color")
            {
                parkeraVehicles = parkeraVehicles.Where(x => x.Color.Contains(search) || search == null);
            }
            //else if (searchBy == "NumberOfWheels")
            //{
            //    parkeraVehicles = parkeraVehicles.Where(x => x.Type.ToString() == search || search == null);        
            //}
            else
            {
                parkeraVehicles = parkeraVehicles.Where(x => x.RegistrationNumber.StartsWith(search) || search == null);
            }

            switch (sortBy)
            {
                case "Type desc":
                    parkeraVehicles = parkeraVehicles.OrderByDescending(x => x.Type);
                    break;
                case "RegistrationNumber":
                    parkeraVehicles = parkeraVehicles.OrderBy(x => x.RegistrationNumber);
                    break;
                case "RegistrationNumber desc":
                    parkeraVehicles = parkeraVehicles.OrderByDescending(x => x.RegistrationNumber);
                    break;
                default:
                    parkeraVehicles = parkeraVehicles.OrderBy(x => x.Type);
                    //parkeraVehicles = parkeraVehicles.OrderByDescending(x => x.Id);
                    break;
            }

            return View(parkeraVehicles.ToPagedList(page ?? 1, 7));
        }
        //New ActionResult to add a new view
        //public ActionResult Car(int? page)
        //{
        //    var model = db.Vehicles.Where(i => i.Type == Models.Type.Car).ToList().ToPagedList(page ?? 1, 3);
        //    return View(model);
        //}
        //public ActionResult Motorcycle(int? page)
        //{
        //    var model = db.Vehicles.Where(i => i.Type == Models.Type.Motorcycle).ToList().ToPagedList(page ?? 1, 3);
        //    return View(model);
        //}
        //public ActionResult Boat(int? page)
        //{
        //    var model = db.Vehicles.Where(i => i.Type == Models.Type.Boat).ToList().ToPagedList(page ?? 1, 3);
        //    return View(model);
        //}
        //public ActionResult Airplane(int? page)
        //{
        //    var model = db.Vehicles.Where(i => i.Type == Models.Type.Airplane).ToList().ToPagedList(page ?? 1, 3);
        //    return View(model);
        //}

            public ActionResult Information()
        {

            return View();
        }

        // GET: ParkedVehicles/Details/5
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

        // GET: ParkedVehicles/Create
        public ActionResult Create()
        {           
            return View();
        }

        // POST: ParkedVehicles/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Type,RegistrationNumber,Color,Brand,Model,NumberOfWheels")] ParkedVehicle parkedVehicle)
        {
            if (ModelState.IsValid)
            {
                db.Vehicles.Add(parkedVehicle);
                parkedVehicle.CheckIn = DateTime.Now;
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(parkedVehicle);
            //return View(parkedVehicle);
        }

        // GET: ParkedVehicles/Edit/5       
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

        // POST: ParkedVehicles/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Type,RegistrationNumber,Color,Brand,Model,NumberOfWheels")] ParkedVehicle parkedVehicle)
        {
            if (ModelState.IsValid)
            {
                db.Entry(parkedVehicle).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(parkedVehicle);
        }

        // GET: ParkedVehicles/Delete/5
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
            //ReceiptVM receipt = new ReceiptVM(parkedVehicle);
            //receipt.Checkout = DateTime.Now;

            parkedVehicle.CheckOut = DateTime.Now;
            return View(parkedVehicle);
        }

        // POST: ParkedVehicles/Delete/5"Receipt",receipt
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
