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
    public class EstacionesDeServiciosController : Controller
    {
        private FarwestDbContext db = new FarwestDbContext();

        // GET: EstacionesDeServicios
        public ActionResult Index()
        {
            return View(db.EstacionDeServicios.ToList());
        }

        // GET: EstacionesDeServicios/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EstacionDeServicio estacionDeServicio = db.EstacionDeServicios.Find(id);
            if (estacionDeServicio == null)
            {
                return HttpNotFound();
            }
            return View(estacionDeServicio);
        }

        // GET: EstacionesDeServicios/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EstacionesDeServicios/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "EstacionId,NombreEstacion,ProvinciaId,LocalidadId,TelefonoDeContacto")] EstacionDeServicio estacionDeServicio)
        {
            if (ModelState.IsValid)
            {
                db.EstacionDeServicios.Add(estacionDeServicio);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(estacionDeServicio);
        }

        // GET: EstacionesDeServicios/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EstacionDeServicio estacionDeServicio = db.EstacionDeServicios.Find(id);
            if (estacionDeServicio == null)
            {
                return HttpNotFound();
            }
            return View(estacionDeServicio);
        }

        // POST: EstacionesDeServicios/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "EstacionId,NombreEstacion,ProvinciaId,LocalidadId,TelefonoDeContacto")] EstacionDeServicio estacionDeServicio)
        {
            if (ModelState.IsValid)
            {
                db.Entry(estacionDeServicio).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(estacionDeServicio);
        }

        // GET: EstacionesDeServicios/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EstacionDeServicio estacionDeServicio = db.EstacionDeServicios.Find(id);
            if (estacionDeServicio == null)
            {
                return HttpNotFound();
            }
            return View(estacionDeServicio);
        }

        // POST: EstacionesDeServicios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            EstacionDeServicio estacionDeServicio = db.EstacionDeServicios.Find(id);
            db.EstacionDeServicios.Remove(estacionDeServicio);
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
