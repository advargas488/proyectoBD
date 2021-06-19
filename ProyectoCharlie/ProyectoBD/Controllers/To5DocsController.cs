using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyectoBD.Controllers
{
    public class To5DocsController : Controller
    {
        private PBDEntities db = new PBDEntities();
        // GET: To5Docs
        public ActionResult Index()
        {
            return View(db.Top5Docs().ToList());
        }
    }
}
