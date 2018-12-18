namespace EasyPTC.Controllers
{
    using EasyPTC.Models;
    using System.Web.Mvc;

    public abstract class BaseController : Controller
    {
        protected User CurrentUser { get; set; }

        [NonAction]
        public void SystemSetthings()
        {

        }
    }
}