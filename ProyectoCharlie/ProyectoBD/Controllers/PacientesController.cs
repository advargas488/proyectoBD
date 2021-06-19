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
    public class PacientesController : Controller
    {
        private PBDEntities db = new PBDEntities();

        // GET: Pacientes
        public ActionResult Index(string message = "")
        {
            ViewBag.Message = message;
            return View(db.Select_General_Paciente().ToList());
        }

        // GET: Pacientes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            if (db.Select_Individual_Paciente(id) == null)
            {
                return HttpNotFound();
            }
            return View(db.Select_Individual_Paciente(id).ToList());
        }

        // GET: Pacientes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Pacientes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Cédula,Nombre,Apellido1,Apellido2,Teléfono,Provincia,Cantón,Distrito,Correo,Fecha_Nac,Tipo_Sangre,Estado")] Paciente paciente)
        {
            if(paciente.Estado != "Sano" && paciente.Estado != "Contagiado" && paciente.Estado != "Recuperado")
            {
                Index("Estado incorrecto");
                return View(paciente);
            }
            if (ModelState.IsValid)
            {
                db.Insertar_Paciente(paciente.Cédula,paciente.Nombre,paciente.Apellido1,paciente.Apellido2,paciente.Teléfono,paciente.Provincia,paciente.Cantón,paciente.Distrito,paciente.Correo,paciente.Fecha_Nac,paciente.Tipo_Sangre,paciente.Estado);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(paciente);
        }

        // GET: Pacientes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Paciente paciente = db.Pacientes.Find(id);
            if (paciente == null)
            {
                return HttpNotFound();
            }
            return View(paciente);
        }

        // POST: Pacientes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int? id,[Bind(Include = "Cédula,Nombre,Apellido1,Apellido2,Teléfono,Provincia,Cantón,Distrito,Correo,Fecha_Nac,Tipo_Sangre,Estado")] Paciente paciente)
        {
            if (ModelState.IsValid)
            {
                db.Editar_Paciente(id, paciente.Cédula, paciente.Nombre, paciente.Apellido1, paciente.Apellido2, paciente.Teléfono, paciente.Provincia, paciente.Cantón, paciente.Distrito, paciente.Correo, paciente.Fecha_Nac, paciente.Tipo_Sangre, paciente.Estado);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(paciente);
        }

        // GET: Pacientes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Paciente paciente = db.Pacientes.Find(id);
            if (paciente == null)
            {
                return HttpNotFound();
            }
            return View(paciente);
        }

        // POST: Pacientes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            db.Borrar_Paciente(id);
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
