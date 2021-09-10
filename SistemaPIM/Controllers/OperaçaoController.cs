using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SistemaPIM.Controllers
{
    public class OperaçaoController : Controller
    {
        [Authorize]
        public ActionResult Saldo()
        {
            return View();
        }
    }
}