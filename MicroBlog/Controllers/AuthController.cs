using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MicroBlog.ViewModels;

namespace MicroBlog.Controllers
{
    public class AuthController : Controller
    {
        // GET: Auth
        public ActionResult Register()
        {
            if (TempData["Mensagem"] != null)
            {
                ViewBag.Mensagem = TempData["Mensagem"];
            }
            return View();
        }

        [HttpPost]
        public ActionResult Register(UserViewModel user)
        {
            if (!ModelState.IsValid)
            {
                return View(user);
            }
            var teste = user;
            Session["Usuario"] = user;
            TempData["Mensagem"] = "Usuário cadastrado com sucesso!";
            return RedirectToAction("Index","Home");
        }

        public ActionResult Login()
        {
            return View();
        }
    }
}