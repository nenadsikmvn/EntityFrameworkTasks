using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using EntityFrameworkTasks.Models;

namespace EntityFrameworkTasks.Controllers
{
    public class StudyProgrammeController : Controller
    {
        private EntityFrameworkTasks_DE db = new EntityFrameworkTasks_DE();

        // GET: StudyProgramme
        public ActionResult Index()
        {
          
            return View(db.StudyProgrammes.ToList());
        }

        // GET: StudyProgramme/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StudyProgramme studyProgramme = db.StudyProgrammes.Find(id);
            if (studyProgramme == null)
            {
                return HttpNotFound();
            }
            return View(studyProgramme);
        }

        // GET: StudyProgramme/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: StudyProgramme/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ProgrammeId,ProgrammeName")] StudyProgramme studyProgramme)
        {
            if (ModelState.IsValid)
            {
                db.StudyProgrammes.Add(studyProgramme);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(studyProgramme);
        }

        // GET: StudyProgramme/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StudyProgramme studyProgramme = db.StudyProgrammes.Find(id);
            if (studyProgramme == null)
            {
                return HttpNotFound();
            }
            return View(studyProgramme);
        }

        // POST: StudyProgramme/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ProgrammeId,ProgrammeName")] StudyProgramme studyProgramme)
        {
            if (ModelState.IsValid)
            {
                db.Entry(studyProgramme).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(studyProgramme);
        }

        // GET: StudyProgramme/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StudyProgramme studyProgramme = db.StudyProgrammes.Find(id);
            if (studyProgramme == null)
            {
                return HttpNotFound();
            }
            return View(studyProgramme);
        }

        // POST: StudyProgramme/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            StudyProgramme studyProgramme = db.StudyProgrammes.Find(id);
            db.StudyProgrammes.Remove(studyProgramme);
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
