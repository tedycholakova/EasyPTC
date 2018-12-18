﻿namespace EasyPTC.Controllers
{
    using System.Web.Mvc;

    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();

        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult OurVision()
        {
            return View(); 
        }

        public ActionResult Test()
        {
            return Content("Pesho");
        }
    }
}