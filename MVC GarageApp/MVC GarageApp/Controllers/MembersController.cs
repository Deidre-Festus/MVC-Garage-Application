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
    public class MembersController : Controller
    {
        private VehicleContext db = new VehicleContext();

        // GET: Members
        public ActionResult Index(int? page,string searchBy, string search, string sortBy)
        {
            ViewBag.SortOwner = string.IsNullOrEmpty(sortBy) ? "Owner desc" : "";
            ViewBag.SortMemberShipParameter = sortBy == "MemberShip" ? "MemberShip desc" : "MemberShip";

            var members = db.Members.AsQueryable();
            if (searchBy == "Owner")
            {
                members = members.Where(x => x.FName.Contains(search) || x.LName.Contains(search) || search == null);
            }
            else if (searchBy == "MemberShip")
            {
                members = members.Where(x => x.MemberShip.ToString().Contains(search) || search == null);
            }
            else if (searchBy == "TelephoneNumber")
            {
                members = members.Where(x => x.TelNumber.Contains(search) || search == null);
            }
            else if (searchBy == "Address")
            {
                members = members.Where(x => x.Address.Contains(search) || search == null);
            }
            else if (searchBy == "City")
            {
                members = members.Where(x => x.City.Contains(search) || search == null);
            }
            else
            {
                members = members.Where(x => x.MemberShip.ToString().StartsWith(search) || search == null);
            }
            switch (sortBy)
            {
                case "Owner desc":
                    members = members.OrderByDescending(x => x.FName);
                    break;
                case "MemberShip":
                    members = members.OrderBy(x => x.MemberShip);
                    break;
                case "MemberShip desc":
                    members = members.OrderByDescending(x => x.MemberShip);
                    break;
                default:
                    members = members.OrderBy(x => x.FName);
                    break;
            }
            return View(members.OrderByDescending(x => x.StartDate).ToPagedList(page ?? 1, 5));
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
        public ActionResult Create([Bind(Include = "Id,FName,LName,MemberShip,TelNumber,Address,City,Pcode")] Member member)
        {
            if (ModelState.IsValid)
            {
                db.Members.Add(member);
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
        public ActionResult Edit([Bind(Include = "Id,FName,LName,MemberShip,TelNumber,Address,City,Pcode")] Member member)
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
