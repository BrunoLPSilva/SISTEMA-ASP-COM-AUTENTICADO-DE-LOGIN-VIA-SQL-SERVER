using System.Web.Mvc;
using System.Web.Security;
using SistemaPIM.Models;


namespace SistemaPIM.Controllers
{
    public class ContaController : Controller
    {
        [AllowAnonymous]
        public ActionResult Login(string returnUrl)
        {
            ViewBag.ReturnUrl = returnUrl;
            return View();
        }
        [HttpPost]
        public ActionResult Login(LoginViewModel login, string returnUrl)
            {
            if (!ModelState.IsValid)
            {
                return View(login);
            }

           

            // var achou = (UsuarioModel.ValidarUsuario(login.Usuario, login.Senha));
            var achou = (login.Usuario == "Bruno" && login.Senha == "123");

            

            if (achou)
            {
                FormsAuthentication.SetAuthCookie(login.Usuario, login.LembrarMe);

                if (Url.IsLocalUrl(returnUrl))
                {
                    return Redirect(returnUrl);
                }
               else
                {
                    RedirectToAction("Index", "Home");
                }
              
            }
            else
            {
                ModelState.AddModelError("", "Login inválido");
            }
            return View(login);

        }
        [HttpPost]
        public ActionResult LogOff()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home");
        }
            

         public ActionResult Recuperar()
        {
            return View();
        }

        public ActionResult Cadastrar()
        {
            return View();
        }
    }
}