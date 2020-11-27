using System;
using System.Collections.Generic;
using System.Linq;
using WebApplicationMVC.Models;
using System.Web;
using System.Web.Mvc;

namespace WebApplicationMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var model = new HomeViewData();
            model.Nome = "PAGINA DE HOME CRIAR ...";
            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "CRIAR PAGINA DE CADASTRO AQUI";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "CRIAR ALGUMA COISA AQUI";

            return View();
        }
    }
}