using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ResystWebsite.Controllers {
	public class HomeController : Controller {
		public ActionResult Index() {
			ViewBag.WindowTitle = "Resyst Softwares' Official Website";
			ViewBag.Title = "Resyst Softwares Inc.™";
			return View();
		}

		public ActionResult About() {
			ViewBag.WindowTitle = "Acerca de";
			ViewBag.Title = "Acerca de nosotros";
			return View();
		}

		public ActionResult Contact() {
			ViewBag.WindowTitle = "Contacto";
			ViewBag.Title = "Contáctenos";
			return View();
		}

		public ActionResult Products() {
			ViewBag.WindowTitle = "Productos";
			ViewBag.Title = "Productos destacados";
			return View();
		}
	}
}