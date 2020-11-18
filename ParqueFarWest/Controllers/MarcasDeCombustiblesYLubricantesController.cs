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
    public class MarcasDeCombustiblesYLubricantesController : Controller
    {
        private FarwestDbContext db = new FarwestDbContext();

        // GET: MarcasDeCombustiblesYLubricantes
        public ActionResult Index()
        {
            return View(db.MarcaDeCombustibleYLubricantes.ToList());
        }

        // GET: MarcasDeCombustiblesYLubricantes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MarcaDeCombustibleYLubricante marcaDeCombustibleYLubricante = db.MarcaDeCombustibleYLubricantes.Find(id);
            if (marcaDeCombustibleYLubricante == null)
            {
                return HttpNotFound();
            }
            return View(marcaDeCombustibleYLubricante);
        }

        // GET: MarcasDeCombustiblesYLubricantes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MarcasDeCombustiblesYLubricantes/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MarcaId,NombreMarca")] MarcaDeCombustibleYLubricante marcaDeCombustibleYLubricante)
        {
            if (ModelState.IsValid)
            {
                db.MarcaDeCombustibleYLubricantes.Add(marcaDeCombustibleYLubricante);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(marcaDeCombustibleYLubricante);
        }

        // GET: MarcasDeCombustiblesYLubricantes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MarcaDeCombustibleYLubricante marcaDeCombustibleYLubricante = db.MarcaDeCombustibleYLubricantes.Find(id);
            if (marcaDeCombustibleYLubricante == null)
            {
                return HttpNotFound();
            }
            return View(marcaDeCombustibleYLubricante);
        }

        // POST: MarcasDeCombustiblesYLubricantes/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MarcaId,NombreMarca")] MarcaDeCombustibleYLubricante marcaDeCombustibleYLubricante)
        {
            if (ModelState.IsValid)
            {
                db.Entry(marcaDeCombustibleYLubricante).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(marcaDeCombustibleYLubricante);
        }

        // GET: MarcasDeCombustiblesYLubricantes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MarcaDeCombustibleYLubricante marcaDeCombustibleYLubricante = db.MarcaDeCombustibleYLubricantes.Find(id);
            if (marcaDeCombustibleYLubricante == null)
            {
                return HttpNotFound();
            }
            return View(marcaDeCombustibleYLubricante);
        }

        // POST: MarcasDeCombustiblesYLubricantes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            MarcaDeCombustibleYLubricante marcaDeCombustibleYLubricante = db.MarcaDeCombustibleYLubricantes.Find(id);
            db.MarcaDeCombustibleYLubricantes.Remove(marcaDeCombustibleYLubricante);
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
