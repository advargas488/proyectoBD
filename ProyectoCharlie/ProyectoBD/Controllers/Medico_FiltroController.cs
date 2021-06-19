using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyectoBD.Controllers
{
    public class Medico_FiltroController : Controller
    {
        private PBDEntities db = new PBDEntities();
        // GET: Medico_Filtro
        public ActionResult Index(string especialidad, string estado)
        {
            return View(db.Medico_Filtro(especialidad, estado));
        }
    }  
}
