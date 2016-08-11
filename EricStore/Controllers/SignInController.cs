
using EricStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using WebMatrix.WebData;

namespace EricStore.Controllers
{
    public class SignInController : Controller
    {
        

        // GET: SignIn
        public ActionResult Index()
        {
            LoginModel model = new LoginModel();
            return View(model);
        }
        public ActionResult Logout()
        {
            if (User.Identity.IsAuthenticated)
            {
                FormsAuthentication.SignOut();
            }
            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        public ActionResult Index(LoginModel model, string returnUrl = "/")
        {
            if (ModelState.IsValid)
            {
                if ( WebSecurity.Login(model.Email, model.Password, true))
                {
                    FormsAuthentication.SetAuthCookie(model.Email, true);
                    return Redirect(returnUrl);
                }
                else
                {
                    ModelState.AddModelError("Email", "Username and/or Password are Incorrect");
                }
            }
            return View(model);
        }
    }
}