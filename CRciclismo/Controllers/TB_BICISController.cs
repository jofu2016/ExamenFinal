using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CRciclismo.Models;

namespace CRciclismo.Controllers
{
    public class TB_BICISController : Controller
    {
        private DB_CRCICLISMOEntities db = new DB_CRCICLISMOEntities();

        // GET: TB_BICIS
        public ActionResult Index()
        {
            return View(db.TB_BICIS.ToList());
        }

        // GET: TB_BICIS/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TB_BICIS tB_BICIS = db.TB_BICIS.Find(id);
            if (tB_BICIS == null)
            {
                return HttpNotFound();
            }
            return View(tB_BICIS);
        }

        // GET: TB_BICIS/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TB_BICIS/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,MARCA,CANTIDAD,PRECIO")] TB_BICIS tB_BICIS)
        {
            if (ModelState.IsValid)
            {
                db.TB_BICIS.Add(tB_BICIS);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tB_BICIS);
        }

        // GET: TB_BICIS/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TB_BICIS tB_BICIS = db.TB_BICIS.Find(id);
            if (tB_BICIS == null)
            {
                return HttpNotFound();
            }
            return View(tB_BICIS);
        }

        // POST: TB_BICIS/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,MARCA,CANTIDAD,PRECIO")] TB_BICIS tB_BICIS)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tB_BICIS).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tB_BICIS);
        }

        // GET: TB_BICIS/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TB_BICIS tB_BICIS = db.TB_BICIS.Find(id);
            if (tB_BICIS == null)
            {
                return HttpNotFound();
            }
            return View(tB_BICIS);
        }

        // POST: TB_BICIS/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TB_BICIS tB_BICIS = db.TB_BICIS.Find(id);
            db.TB_BICIS.Remove(tB_BICIS);
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
