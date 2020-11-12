using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MiSeguridadMVC.Controllers
{
    [Authorize(Users ="mario@correo.com")]//usuario administrador
    public class AccesoController : Controller
    {
        // GET: Acceso
       
        public ContentResult Privada()
        {
            return Privada();
        }
        [AllowAnonymous]
        public ActionResult Publico()
        {
            return View();
        }

        [AllowAnonymous]
        public ActionResult Publico2()
        {
            return View();
        }

        [AllowAnonymous]
        public ActionResult Publico3()
        {
            return View();
        }

        [AllowAnonymous]
        public ActionResult Publico4()
        {
            return View();
        }



    }
}


