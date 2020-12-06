using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplicationMVC.Service;

namespace WebApplicationMVC.Controllers
{
    public class cadastroController : Controller
    {
    
        public CadastroSrvice CadastroService { get; set; }

      public cadastroController()
        {
            CadastroService = new CadastroService();
        }

        // GET: cadastro
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CadastroUsuario(string nome, string email,string senha, DateTime nascimnto)
        {
            try
            {

                CadastroService.SalvarUsuario(nome, email, senha, nascimnto);

                return Redirect(Url.Action("Index", "Login"));
            }
            catch (Exception)
            {

                throw;
            }
             
        }

    }

    internal class CadastroService : CadastroSrvice
    {
    }
}