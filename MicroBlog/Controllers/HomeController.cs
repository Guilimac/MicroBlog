using MicroBlog.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MicroBlog.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            if(Session["Usuario"]!= null)
            {
                UserViewModel usuario = (UserViewModel)Session["Usuario"];
                ViewBag.NomeUsuario = usuario.UserName;
            }
            if(TempData["Mensagem"] != null)
            {
                ViewBag.Mensagem = TempData["Mensagem"];
                TempData.Keep();
            }
            
            return View();
        }

    }
}