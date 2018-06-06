using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class OcjenasController : Controller
    {
        private CinemaContext db = new CinemaContext();

        // GET: Ocjenas
        public ActionResult Index()
        {
            return View(db.Ocjenas.ToList());
        }

        // GET: Ocjenas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ocjena ocjena = db.Ocjenas.Find(id);
            if (ocjena == null)
            {
                return HttpNotFound();
            }
            return View(ocjena);
        }

        // GET: Ocjenas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Ocjenas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,BrojOcjena,Komentar")] Ocjena ocjena)
        {
            if (ModelState.IsValid)
            {
                db.Ocjenas.Add(ocjena);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(ocjena);
        }

        // GET: Ocjenas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ocjena ocjena = db.Ocjenas.Find(id);
            if (ocjena == null)
            {
                return HttpNotFound();
            }
            return View(ocjena);
        }

        // POST: Ocjenas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,BrojOcjena,Komentar")] Ocjena ocjena)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ocjena).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(ocjena);
        }

        // GET: Ocjenas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ocjena ocjena = db.Ocjenas.Find(id);
            if (ocjena == null)
            {
                return HttpNotFound();
            }
            return View(ocjena);
        }

        // POST: Ocjenas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Ocjena ocjena = db.Ocjenas.Find(id);
            db.Ocjenas.Remove(ocjena);
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
