using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using test.Models;

namespace test.Controllers
{
    public class danhmuctintucsController : Controller
    {
        private quantriEntities db = new quantriEntities();

        // GET: danhmuctintucs
        public ActionResult Index()
        {
            return View(db.danhmuctintucs.ToList());
        }

        // GET: danhmuctintucs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            danhmuctintuc danhmuctintuc = db.danhmuctintucs.Find(id);
            if (danhmuctintuc == null)
            {
                return HttpNotFound();
            }
            return View(danhmuctintuc);
        }

        // GET: danhmuctintucs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: danhmuctintucs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "madanhmuctintuc,tendanhmuctintuc")] danhmuctintuc danhmuctintuc)
        {
            if (ModelState.IsValid)
            {
                db.danhmuctintucs.Add(danhmuctintuc);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(danhmuctintuc);
        }

        // GET: danhmuctintucs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            danhmuctintuc danhmuctintuc = db.danhmuctintucs.Find(id);
            if (danhmuctintuc == null)
            {
                return HttpNotFound();
            }
            return View(danhmuctintuc);
        }

        // POST: danhmuctintucs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "madanhmuctintuc,tendanhmuctintuc")] danhmuctintuc danhmuctintuc)
        {
            if (ModelState.IsValid)
            {
                db.Entry(danhmuctintuc).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(danhmuctintuc);
        }

        // GET: danhmuctintucs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            danhmuctintuc danhmuctintuc = db.danhmuctintucs.Find(id);
            if (danhmuctintuc == null)
            {
                return HttpNotFound();
            }
            return View(danhmuctintuc);
        }

        // POST: danhmuctintucs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            danhmuctintuc danhmuctintuc = db.danhmuctintucs.Find(id);
            db.danhmuctintucs.Remove(danhmuctintuc);
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
