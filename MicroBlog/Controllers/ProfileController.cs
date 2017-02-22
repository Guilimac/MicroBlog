using MicroBlog.DAL;
using MicroBlog.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MicroBlog.Controllers
{
    public class ProfileController : Controller
    {
        // GET: Profile
        public ActionResult Index()
        {
            if (Session["Usuario"] != null)
            {
                UserViewModel user = (UserViewModel)Session["Usuario"];
                return View(user);
            }
            return RedirectToAction("Index","Home");
        }

        public ActionResult Edit(Guid id)
        {
            UserViewModel user = UserDAO.GetById(id);
            if(user != null)
            {
                return View(user);
            }
            return RedirectToAction("Index", "Home");
        }
    }
}