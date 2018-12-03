using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace bookyourdoctor.Controllers
{
    public class PatientController : Controller
    {
        // GET: Patient
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        // GET: Patient/Details/5
        

        // GET: Patient/Create
        public ActionResult Create()
        {
            return View();
        }

        public ActionResult SelectDoctor()
        {
            return View();
        }

        public ActionResult ViewDoctorDetails()
        {
            return View();
        }
        public ActionResult TakeAppoitment()
        {
            return View();
        }

        public ActionResult CardiologistsDetails()
        {
            return View();
        }

        public ActionResult ChildSpecialistDetails()
        {
            return View();
        }

        public ActionResult DermatologistDetails()
        {
            return View();
        }
        public ActionResult GynecologistDetails()
        {
            return View();
        }

        public ActionResult DentistDetails()
        {
            return View();
        }
        public ActionResult PsychologistDetails()
        {
            return View();
        }
        // POST: Patient/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Patient/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Patient/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Patient/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Patient/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
