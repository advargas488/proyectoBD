using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyectoBD.Controllers
{
    public class BusquedaController : Controller
    {
        private PBDEntities db = new PBDEntities();
        // GET: Busqueda
        public ActionResult Index(string name)
        {
            if(name == "")
            {
                return View();
            }
            else if (db.Select_Medico_Paciente(name) == null)
            {
                ViewBag.Message = "Nombre no encontrado";
                return View();
            }
            return View(db.Select_Medico_Paciente(name).ToList());
        }

        public ActionResult Busqueda2(string name)
        {
            if (name == "")
            {
                return View();
            }
            else if (db.Select_General_Paciente_2(name) == null)
            {
                ViewBag.Message = "Nombre no encontrado";
                return View();
            }
            return View(db.Select_General_Paciente_2(name).ToList());
        }

        public ActionResult Estadisticas()
        {
            return View();
        }

    }
}