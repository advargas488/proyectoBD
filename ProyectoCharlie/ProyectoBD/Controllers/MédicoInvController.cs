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
    public class MédicoInvController : Controller
    {
        private PBDEntities db = new PBDEntities();

        // GET: MédicoInv
        public ActionResult Index()
        {
            return View(db.Médico.ToList());
        }
    }
}
