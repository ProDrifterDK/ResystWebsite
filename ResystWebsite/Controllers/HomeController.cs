using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ResystWebsite.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Resyst Softwares' Official Website";
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Title = "Acerca de ";
            ViewBag.Message = "Resyst Softwares' Website.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Title = "Contacto";
            ViewBag.Message = "contacto@resyst.com";

            return View();
        }

        public ActionResult Products()
        {
            ViewBag.Title = "Productos";
            ViewBag.Message = "Productos";
            return View();
        }
    }
}