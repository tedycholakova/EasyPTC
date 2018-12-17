namespace EasyPTC.Controllers
{
    using System.Web.Mvc;
    public class TestController : Controller
    {
      
        public ActionResult Details(int id)
        {
            return View(id);
        }
    }
}