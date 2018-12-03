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
    public class doctors1Controller : Controller
    {
        private bookEntities db = new bookEntities();

        // GET: doctors1
        public ActionResult Index()
        {
            return View(db.doctors.ToList());
        }

        // GET: doctors1/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            doctor doctor = db.doctors.Find(id);
            if (doctor == null)
            {
                return HttpNotFound();
            }
            return View(doctor);
        }

        // GET: doctors1/Create
        public ActionResult Create()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(doctor p)
        {
            using (bookEntities db = new bookEntities())
            {
                var usr = db.doctors.SingleOrDefault(u => u.doctor_id == p.doctor_id);
                if (usr != null)
                {
                    if (usr.password.ToString() == p.password.ToString())
                    {
                        Session["doctor_id"] = usr.doctor_id.ToString();
                        return RedirectToAction("DoctorWelcome");

                    }
                }
                else
                {
                    ModelState.AddModelError("", "Email or password is wrong or maybe you are not registered");
                }
            }
            return View(p);

        }
        public ActionResult DoctorWelcome()
        {

            return View();
        }

        // POST: doctors1/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "doctor_id,name,date_of_birth,phone,MBBS_Code,email,password,confirm_password,clinic_name,hospital_address,hospital_name,clinic_address,city,specialization,practising_years,Fee")] doctor doctor)
        {
            if (ModelState.IsValid)
            {
                db.doctors.Add(doctor);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(doctor);
        }

        // GET: doctors1/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            doctor doctor = db.doctors.Find(id);
            if (doctor == null)
            {
                return HttpNotFound();
            }
            return View(doctor);
        }

        // POST: doctors1/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "doctor_id,name,date_of_birth,phone,MBBS_Code,email,password,confirm_password,clinic_name,hospital_address,hospital_name,clinic_address,city,specialization,practising_years,Fee")] doctor doctor)
        {
            if (ModelState.IsValid)
            {
                db.Entry(doctor).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(doctor);
        }

        // GET: doctors1/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            doctor doctor = db.doctors.Find(id);
            if (doctor == null)
            {
                return HttpNotFound();
            }
            return View(doctor);
        }

        // POST: doctors1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            doctor doctor = db.doctors.Find(id);
            db.doctors.Remove(doctor);
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
