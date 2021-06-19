using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyectoBD.Controllers
{
    public class TopProvinciasController : Controller
    {
        private PBDEntities db = new PBDEntities();
        // GET: TopProvincias
        public ActionResult Index()
        {
            return View(db.TopProvincias().ToList());
        }
    }
}
