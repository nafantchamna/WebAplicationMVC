using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplicationMVC.Controllers
{
    public class cadastroController : Controller
    {
        // GET: cadastro
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CadastroUsuario()
        {
            return View("Index");
        }

    }
}