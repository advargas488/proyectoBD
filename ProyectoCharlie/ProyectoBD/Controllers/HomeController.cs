using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace ProyectoBD.Controllers
{
    public class HomeController : Controller
    {
        private PBDEntities db = new PBDEntities();
        public ActionResult Index2(string message = "")
        {
            ViewBag.Message = message;
            return View();
        }

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index2(string user, string password)
        {
            if(user!="" && password != "")
            {
                if (db.Administradors.Find(user) == null)
                {
                    return Index2("Usuario no encontrado");
                }
                else if(db.Administradors.Find(user).Contraseña != password)
                {
                    return Index2("Contraseña incorrecta");
                }
                else
                {
                    return RedirectToAction("Index");
                }
            }
            return Index2("Ingrese todos los datos");
        }
    }
}