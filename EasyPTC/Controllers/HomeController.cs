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
        [HttpGet]
        public ActionResult Test()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Test(string name, int age)
        {
            return Content(name + age.ToString());
        }
    }
}