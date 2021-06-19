using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyectoBD.Controllers
{
    public class TopEspecialidadController : Controller
    {
        private PBDEntities db = new PBDEntities();
        // GET: TopEspecialidad
        public ActionResult Index()
        {
            return View(db.TopEspecialidad().ToList());
        }

    }
}
