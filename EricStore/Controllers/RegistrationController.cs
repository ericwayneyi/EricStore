
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
    public class RegistrationController : Controller
    {
        // GET: Registration
        public ActionResult Index()
        {
            RegistrationModel model = new RegistrationModel();

            return View(model);
        }
        [HttpPost]
        public ActionResult Index(RegistrationModel model)
        {
            if (ModelState.IsValid)
            {
                if (WebSecurity.UserExists(model.Email))
                {
                    ModelState.AddModelError("Email", "This username is already registered");
                }
                else
                {
                    WebSecurity.CreateUserAndAccount(model.Email, model.Password);
                    FormsAuthentication.SetAuthCookie(model.Email, true);
                    return RedirectToAction("Index", "Home");
                }
                
            }
            return View(model);
        }
    }
}