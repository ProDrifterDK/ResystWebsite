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
			ViewBag.Text1 = "Productos destacados";
			return View();
		}

		public ActionResult About() {
			ViewBag.WindowTitle = "Acerca de";
			ViewBag.Title = "Acerca de nosotros";
			ViewBag.About = "Resyst softwares Inc.™ está conformada principalmente por un grupo de profesionales entusiastas y tesoneros. Como eruditos en las ciencias de la computación y la informática, nuestro objetivo primordial es la satisfacción del cliente y el usuario final de nuestros productos, desarrollando todo tipo de sistemas informáticos concisos, eficaces y fiables para el uso determinado por el cliente.";
			ViewBag.Header1 = "Empresas que han confiado en nosotros";
			ViewBag.Header2 = "Tecnologías que utilizamos";
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
			ViewBag.Product1_Title = "LoteríaGG";
			ViewBag.Product2_Title = "Man on the Moon Studio";
			return View();
		}
	}
}