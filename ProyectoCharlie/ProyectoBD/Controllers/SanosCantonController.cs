using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyectoBD.Controllers
{
    public class SanosCantonController : Controller
    {
        private PBDEntities db = new PBDEntities();
        // GET: SanosCanton
        public ActionResult Index()
        {
            return View(db.SanosCanton().ToList());
        }

    }
}
