using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplicationClip.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Cuenta()
        {
            ViewBag.Message = "Detalles de cuenta del usuario";

            return View();
        }

        public ActionResult Operaciones()
        {
            ViewBag.Message = "Sector donde se realizan operaciones";

            return View();
        }
    }
}