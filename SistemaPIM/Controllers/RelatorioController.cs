using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SistemaPIM.Models;

namespace SistemaPIM.Controllers
{
    public class RelatorioController : Controller
    {
        [Authorize]
        public ActionResult Extrato()
        {
            return View();
        }
    }
}