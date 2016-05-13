using StHumberHospital.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace StHumberHospital.Controllers
{
    public class PatientController : Controller
    {
        //this controller handles input when it comes to the adding information to the patient test results
        // GET: Patient
        public ActionResult Index()
        {
            PatientContext patientContext = new PatientContext();

            List<Patient> patients = patientContext.Patients.ToList();
            return View(patients);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(FormCollection formCollection)
        {
            PatientContext patientContext = new PatientContext();
            Patient patient = new Patient();

            //patient.user_id = formCollection[ToString()]["User Id"];
            patient.document = formCollection["Document"];
            patient.description = formCollection["Description"];
            patient.doctor_message = formCollection["Doctor's Message"];

            patientContext.Patients.Add(patient);
            patientContext.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            PatientContext patientContext = new PatientContext();
            Patient patient = patientContext.Patients.Find(id);

            return View(patient);

        }

        [HttpPost]
        public ActionResult Edit(Patient patient)
        {
            PatientContext patientContext = new PatientContext();
            patientContext.Entry(patient).State = System.Data.Entity.EntityState.Modified;

            patientContext.SaveChanges();

            return RedirectToAction("Index");
        }


        [HttpGet]
        public ActionResult Delete(int id)
        {
            PatientContext patientContext = new PatientContext();
            Patient patient = patientContext.Patients.Find(id);
            return View(patient);
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            PatientContext patientContext = new PatientContext();

            Patient patient = patientContext.Patients.Find(id);
            patientContext.Patients.Remove(patient);
            patientContext.SaveChanges();

            return RedirectToAction("Index");
        }

        public ActionResult Details(int id)
        {
            PatientContext patientContext = new PatientContext();
            Patient patient = patientContext.Patients.Find(id);

            return View(patient);
        }
    }
}