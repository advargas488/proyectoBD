using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ProyectoBD;

namespace ProyectoBD.Controllers
{
    public class ClínicaController : Controller
    {
        private readonly PBDEntities db = new PBDEntities();

        // GET: Clínica
        public ActionResult Index()
        {
            return View(db.Select_General_Clínica().ToList());
        }

        // GET: Clínica/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            if (db.Clínica.Find(id) == null)
            {
                return HttpNotFound();
            }
            return View(db.Clínica.Find(id));
        }

        // GET: Clínica/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Clínica/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Nombre,Dirección,Teléfono,Correo,Sitio_Web,Horario,Provincia,Cantón,Distrito")] Clínica clínica)
        {
            if (ModelState.IsValid)
            {
                db.Clínica.Add(clínica);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(clínica);
        }

        // GET: Clínica/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Clínica clínica = db.Clínica.Find(id);
            if (clínica == null)
            {
                return HttpNotFound();
            }
            return View(clínica);
        }

        // POST: Clínica/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(string id,[Bind(Include = "ID,Nombre,Dirección,Teléfono,Correo,Sitio_Web,Horario,Provincia,Cantón,Distrito")] Clínica clínica)
        {
            if (ModelState.IsValid)
            {
                db.Entry(clínica).State = EntityState.Modified;
                db.Editar_Clínica(id,clínica.ID,clínica.Nombre,clínica.Dirección,clínica.Teléfono,clínica.Correo,clínica.Sitio_Web,clínica.Horario,clínica.Provincia,clínica.Cantón,clínica.Distrito);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(clínica);
        }

        // GET: Clínica/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Clínica clínica = db.Clínica.Find(id);
            if (clínica == null)
            {
                return HttpNotFound();
            }
            return View(clínica);
        }

        // POST: Clínica/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            db.Borrar_Clínica(id);
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
