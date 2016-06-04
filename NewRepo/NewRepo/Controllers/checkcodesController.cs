using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using NewRepo.Models;

namespace NewRepo.Controllers
{
    public class checkcodesController : Controller
    {
        private DBModel db = new DBModel();

        // GET: checkcodes
        public ActionResult Index()
        {
            return View(db.checkcode.ToList());
        }

        // GET: checkcodes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            checkcode checkcode = db.checkcode.Find(id);
            if (checkcode == null)
            {
                return HttpNotFound();
            }
            return View(checkcode);
        }

        // GET: checkcodes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: checkcodes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "cid,chkclass,chkclasstitle,chkcode,chkitem,bmodid,bmoddate")] checkcode checkcode)
        {
            if (ModelState.IsValid)
            {
                db.checkcode.Add(checkcode);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(checkcode);
        }

        // GET: checkcodes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            checkcode checkcode = db.checkcode.Find(id);
            if (checkcode == null)
            {
                return HttpNotFound();
            }
            return View(checkcode);
        }

        // POST: checkcodes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "cid,chkclass,chkclasstitle,chkcode,chkitem,bmodid,bmoddate")] checkcode checkcode)
        {
            if (ModelState.IsValid)
            {
                db.Entry(checkcode).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(checkcode);
        }

        // GET: checkcodes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            checkcode checkcode = db.checkcode.Find(id);
            if (checkcode == null)
            {
                return HttpNotFound();
            }
            return View(checkcode);
        }

        // POST: checkcodes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            checkcode checkcode = db.checkcode.Find(id);
            db.checkcode.Remove(checkcode);
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
