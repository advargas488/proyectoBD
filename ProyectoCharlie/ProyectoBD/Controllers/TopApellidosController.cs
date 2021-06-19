using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyectoBD.Controllers
{
    public class TopApellidosController : Controller
    {
        private PBDEntities db = new PBDEntities();
        // GET: TopApellidos
        public ActionResult Index()
        {
            return View(db.TopApellidos().ToList());
        }
    }
}
