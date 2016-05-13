using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using StHumberHospital.Models;

namespace StHumberHospital.Controllers
{
    public class WaitTimesController : Controller

    {
        //this controller handles input when it comes to the emergency room wait time calculator 

        [ChildActionOnly]
        public void WaitTimesCalculator()
        {

            tblWaitTime tblwaittime = db.tblWaitTimes.OrderByDescending(w => w.user_id).First();
            int waittime = (int)(tblwaittime.no_of_patients / tblwaittime.no_of_doctors * tblwaittime.avg_appointment_time);
           TempData["WaitTime"] = waittime ;
        }

        private WaitContext db = new WaitContext();

        // GET: WaitTimes
        public ActionResult Index()
        {
            return View(db.tblWaitTimes.ToList());
        }

        // GET: WaitTimes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblWaitTime tblWaitTime = db.tblWaitTimes.Find(id);
            if (tblWaitTime == null)
            {
                return HttpNotFound();
            }
            return View(tblWaitTime);
        }

        // GET: WaitTimes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: WaitTimes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "user_id,date,no_of_patients,no_of_doctors,avg_appointment_time")] tblWaitTime tblWaitTime)
        {
            if (ModelState.IsValid)
            {
                db.tblWaitTimes.Add(tblWaitTime);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tblWaitTime);
        }

        // GET: WaitTimes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblWaitTime tblWaitTime = db.tblWaitTimes.Find(id);
            if (tblWaitTime == null)
            {
                return HttpNotFound();
            }
            return View(tblWaitTime);
        }

        // POST: WaitTimes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "user_id,date,no_of_patients,no_of_doctors,avg_appointment_time")] tblWaitTime tblWaitTime)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tblWaitTime).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tblWaitTime);
        }

        // GET: WaitTimes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblWaitTime tblWaitTime = db.tblWaitTimes.Find(id);
            if (tblWaitTime == null)
            {
                return HttpNotFound();
            }
            return View(tblWaitTime);
        }

        // POST: WaitTimes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tblWaitTime tblWaitTime = db.tblWaitTimes.Find(id);
            db.tblWaitTimes.Remove(tblWaitTime);
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
