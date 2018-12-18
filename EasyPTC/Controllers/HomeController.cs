namespace EasyPTC.Controllers
{
    using EasyPTC.Models;
    using System.Web.Mvc;

    public class HomeController : BaseController
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

        [ActionName("Vision")]
        public ActionResult OurVision()
        {
            return View("OurVision");
        }
        [HttpGet]
        public ActionResult Test()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Test(Person person)
        {
            if (ModelState.IsValid)
            {
                return Content($"{person.Name} {person.Age}");
            }
            return View(person);
        }
    }
}