using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using ProyectoBD;

namespace ProyectoBD.Controllers
{
    public class MédicoController : Controller
    {
        private PBDEntities db = new PBDEntities();

        // GET: Médico
        public ActionResult Index(string message= "")
        {
            ViewBag.Message = message;
            return View(db.Select_General_Médico().ToList());
        }

        // GET: Médico/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Médico médico = db.Médico.Find(id);
            if (médico == null)
            {
                return HttpNotFound();
            }
            return View(db.Select_Individual_Médico(id).ToList());
        }

        // GET: Médico/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Médico/Create
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Cédula,Nombre,Apellido1,Apellido2,Especialidad,Estado")] Médico médico)
        {
            if(médico.Estado != "Activo" && médico.Estado != "Inactivo")
            {
                return Index("Estado no valido");
            }
            if (ModelState.IsValid)
            {
                db.Insertar_Médico(médico.ID,médico.Cédula,médico.Nombre,médico.Apellido1,médico.Apellido2,médico.Especialidad,médico.Estado);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(médico);
        }

        // GET: Médico/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Médico médico = db.Médico.Find(id);
            if (médico == null)
            {
                return HttpNotFound();
            }
            return View(médico);
        }

        // POST: Médico/Edit/5                              
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(string id,[Bind(Include = "ID,Cédula,Nombre,Apellido1,Apellido2,Especialidad,Estado")] Médico médico)
        {
            if (ModelState.IsValid)
            {
                db.Editar_Médico(id, médico.ID, médico.Cédula, médico.Nombre, médico.Apellido1, médico.Apellido2, médico.Especialidad, médico.Estado);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(médico);
        }

        // GET: Médico/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Médico médico = db.Médico.Find(id);
            if (médico == null)
            {
                return HttpNotFound();
            }
            return View(médico);
        }

        // POST: Médico/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            
            db.Borrar_Médico(id);
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
