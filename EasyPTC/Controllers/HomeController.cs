namespace EasyPTC.Controllers
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

        public ActionResult Test(string id, string name, string age)
        {
            return Content($"id: {id}, name: {name}, age: {age}");
        }
    }
}