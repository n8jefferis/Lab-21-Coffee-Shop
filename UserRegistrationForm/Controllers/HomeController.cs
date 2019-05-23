using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UserRegistrationForm.Models;


namespace UserRegistrationForm.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Registration()
        {
            ViewBag.Message = "Your registration page.";
            return View();
        }

        public ActionResult Result(User inputUser)
        {
            ViewBag.userName = inputUser.userName;
            return View();
        }

        public ActionResult Order(User inputUser)
        {
            ViewBag.Order = inputUser.order;
            return View();
        }
    }
}