using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyectoBD.Controllers
{
    public class ClinicasPorCantonController : Controller
    {
        private PBDEntities db = new PBDEntities();
        // GET: ClinicasPorCanton
        public ActionResult Index()
        {
            return View(db.ClinicasPorCanton().ToList());
        }

    }
}
