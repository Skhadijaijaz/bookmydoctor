using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using bookyourdoctor.Models;

namespace bookyourdoctor.Controllers
{
    public class AspNetUserLogins1Controller : Controller
    {
        private bookEntities db = new bookEntities();

        // GET: AspNetUserLogins1
        public ActionResult Index()
        {
            return View(db.AspNetUserLogins.ToList());
        }
        // GET: Admin/Details/5
        public ActionResult Dashboard()
        {
            return View();
        }
        public ActionResult DoctorInformation()
        {

            return View();
        }
        public ActionResult PatientInformation()
        {

            return View();
        }
        public ActionResult AddDoctor()
        {
            return View();
        }
        public ActionResult AdminLogin()
        {
            return View();
        }
        public ActionResult Reset()
        {
            return View();
        }
        public ActionResult UpdateDoctor()
        {
            return View();
        }
        public ActionResult DeleteDoctor()
        {
            return View();
        }
        public ActionResult RegisterDoctor()
        {
            return View();
        }

        // GET: AspNetUserLogins1/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AspNetUserLogin aspNetUserLogin = db.AspNetUserLogins.Find(id);
            if (aspNetUserLogin == null)
            {
                return HttpNotFound();
            }
            return View(aspNetUserLogin);
        }

        // GET: AspNetUserLogins1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AspNetUserLogins1/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "password,Email")] AspNetUserLogin aspNetUserLogin)
        {
            if (ModelState.IsValid)
            {
                db.AspNetUserLogins.Add(aspNetUserLogin);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(aspNetUserLogin);
        }

        // GET: AspNetUserLogins1/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AspNetUserLogin aspNetUserLogin = db.AspNetUserLogins.Find(id);
            if (aspNetUserLogin == null)
            {
                return HttpNotFound();
            }
            return View(aspNetUserLogin);
        }

        // POST: AspNetUserLogins1/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "password,Email")] AspNetUserLogin aspNetUserLogin)
        {
            if (ModelState.IsValid)
            {
                db.Entry(aspNetUserLogin).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(aspNetUserLogin);
        }

        // GET: AspNetUserLogins1/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AspNetUserLogin aspNetUserLogin = db.AspNetUserLogins.Find(id);
            if (aspNetUserLogin == null)
            {
                return HttpNotFound();
            }
            return View(aspNetUserLogin);
        }

        // POST: AspNetUserLogins1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            AspNetUserLogin aspNetUserLogin = db.AspNetUserLogins.Find(id);
            db.AspNetUserLogins.Remove(aspNetUserLogin);
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
