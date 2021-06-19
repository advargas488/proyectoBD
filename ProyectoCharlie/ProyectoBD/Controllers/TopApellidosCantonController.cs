using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyectoBD.Controllers
{
    public class TopApellidosCantonController : Controller
    {
        private PBDEntities db = new PBDEntities();
        // GET: TopApellidosCanton
        public ActionResult Index(string canton)
        {
            return View(db.TopApellidosCanton(canton).ToList());
        }

       
    }
}
