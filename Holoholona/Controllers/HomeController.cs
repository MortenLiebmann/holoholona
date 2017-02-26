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

        [HttpGet]
        public ActionResult GetMammals()
        {
            Mammal dog = new Dog { Name = "Chihuahua", Type = "Dog" };
            Mammal cat = new Cat { Name = "Siameser", Type = "Cat" };
            GetMammalsViewModel Mammals = new GetMammalsViewModel { Dog = dog, Cat = cat };

            return Json(Mammals, JsonRequestBehavior.AllowGet);
        }
    }
}