using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ParqueFarWest.Context;
using ParqueFarWest.Models;

namespace ParqueFarWest.Controllers
{
    public class CombustiblesYLubricantesController : Controller
    {
        private FarwestDbContext db = new FarwestDbContext();

        // GET: CombustiblesYLubricantes
        public ActionResult Index()
        {
            return View(db.CombustibleYLubricantes.ToList());
        }

        // GET: CombustiblesYLubricantes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CombustibleYLubricante combustibleYLubricante = db.CombustibleYLubricantes.Find(id);
            if (combustibleYLubricante == null)
            {
                return HttpNotFound();
            }
            return View(combustibleYLubricante);
        }

        // GET: CombustiblesYLubricantes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CombustiblesYLubricantes/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CombustibleId,TipoDeCombustibleId,MarcaId,Descripcion")] CombustibleYLubricante combustibleYLubricante)
        {
            if (ModelState.IsValid)
            {
                db.CombustibleYLubricantes.Add(combustibleYLubricante);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(combustibleYLubricante);
        }

        // GET: CombustiblesYLubricantes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CombustibleYLubricante combustibleYLubricante = db.CombustibleYLubricantes.Find(id);
            if (combustibleYLubricante == null)
            {
                return HttpNotFound();
            }
            return View(combustibleYLubricante);
        }

        // POST: CombustiblesYLubricantes/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CombustibleId,TipoDeCombustibleId,MarcaId,Descripcion")] CombustibleYLubricante combustibleYLubricante)
        {
            if (ModelState.IsValid)
            {
                db.Entry(combustibleYLubricante).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(combustibleYLubricante);
        }

        // GET: CombustiblesYLubricantes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CombustibleYLubricante combustibleYLubricante = db.CombustibleYLubricantes.Find(id);
            if (combustibleYLubricante == null)
            {
                return HttpNotFound();
            }
            return View(combustibleYLubricante);
        }

        // POST: CombustiblesYLubricantes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CombustibleYLubricante combustibleYLubricante = db.CombustibleYLubricantes.Find(id);
            db.CombustibleYLubricantes.Remove(combustibleYLubricante);
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
