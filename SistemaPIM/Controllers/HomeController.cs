using SistemaPIM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace SistemaPIM.Controllers
{
    public class HomeController : Controller
    {
        [Authorize]
        public ActionResult Index()
        {
            return View();
        }
        [Authorize]
        public ActionResult Sobre()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        [Authorize]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        [Authorize]
        public ActionResult Recuperar()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        [Authorize]
        public ActionResult Cadastrar()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        [Authorize]
        public ActionResult Saldo()
        {

            ViewBag.Message = "Your contact page.";

            return View();
        }

       



    }
}