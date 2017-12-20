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

namespace MVC_GarageApp.Controllers
{
    public class MembersController : Controller
    {
        private VehicleContext db = new VehicleContext();

        // GET: Members
        public ActionResult Index()
        {
            return View(db.Members.ToList());
        }

        public ActionResult Search(string searchBy, string search)
        {            
            var mem = db.Members.AsQueryable();
            if (searchBy == "MembershipNumber")
            {
                mem = mem.Where(x => x.MemberNr.ToString().Contains(search) || search == null);
            }
            else if (searchBy == "LastName")
            {
                mem = mem.Where(x => x.LName.ToString().Contains(search) || search == null);
            }
            else
            {
                mem = mem.Where(x => x.MemberNr.Equals(search) || search == null);
            }
            return View();
        }

        // GET: Members/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Member member = db.Members.Find(id);
            if (member == null)
            {
                return HttpNotFound();
            }
            return View(member);
        }

        // GET: Members/Create
        public ActionResult Create()
        {
            
            return View();
        }

        // POST: Members/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FName,LName,DateOfBirth,Adress,City,PostCode,TelNr,MemberNr")] Member member)
        {
            if (ModelState.IsValid)
            {
                db.Members.Add(member);
                
                //member.MemberNr= Convert.ToString(random.Next(10,1000));
                db.SaveChanges();
                member.MemberNr = member.Id;
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(member);
        }

        // GET: Members/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Member member = db.Members.Find(id);
            if (member == null)
            {
                return HttpNotFound();
            }
            return View(member);
        }

        // POST: Members/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FName,LName,DateOfBirth,Adress,City,PostCode,TelNr,MemberNr")] Member member)
        {
            if (ModelState.IsValid)
            {
                db.Entry(member).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(member);
        }

        // GET: Members/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Member member = db.Members.Find(id);
            if (member == null)
            {
                return HttpNotFound();
            }
            return View(member);
        }

        // POST: Members/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Member member = db.Members.Find(id);
            db.Members.Remove(member);
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
