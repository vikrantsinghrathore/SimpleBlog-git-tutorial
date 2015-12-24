using SimpleBlog.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SimpleBlog.Controllers
{
    public class AuthController : Controller
    {
        public ActionResult Login()
        {
            return View(new AuthLogin { });
        }

        [HttpPost]
        public ActionResult Login(AuthLogin form)
        {
            if(!ModelState.IsValid)
            return View(form);

            if(form.Username != "vikrant")
            {
                ModelState.AddModelError("Username", "Invalid Username or Password");
                return View(form);
            }
            return Content("The form is valid");
        }
    }
}