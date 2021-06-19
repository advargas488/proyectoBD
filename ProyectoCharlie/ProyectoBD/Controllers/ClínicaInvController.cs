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
    public class ClínicaInvController : Controller
    {
        private PBDEntities db = new PBDEntities();

        // GET: ClínicaInv
        public ActionResult Index()
        {
            return View(db.Clínica.ToList());
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
