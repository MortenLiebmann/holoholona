using Holoholona.Models;
using System.Web.Mvc;

namespace Holoholona.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult GetDog()
        {
            Mammal dog = new Dog { Name = "Chihuahua", Type = "Dog" };
            return Json(dog, JsonRequestBehavior.AllowGet);
        }
    }
}