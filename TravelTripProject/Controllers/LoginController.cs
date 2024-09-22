using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using TravelTripProject.Models.Entities;

namespace TravelTripProject.Controllers
{
    public class LoginController : Controller
    {
        Context context = new Context();
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Admin ad)
        {
            var infos = context.Admins.FirstOrDefault(x => x.Username == ad.Username && x.Password == ad.Password);
            if (infos != null)
            {
                FormsAuthentication.SetAuthCookie(infos.Username, false);
                Session["Username"] = infos.Username.ToString();
                return RedirectToAction("Index", "Admin");
            }
            else
            {
                return View();
            }
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login", "Login");
        }
    }
}