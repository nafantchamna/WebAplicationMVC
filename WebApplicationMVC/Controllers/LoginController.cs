using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplicationMVC.Models;
using System.Web.Mvc;

namespace WebApplicationMVC.Controllers
{
    public class LoginController:Controller
    {
        public ActionResult Index()
        {
           

            return View();
        }

    }
}