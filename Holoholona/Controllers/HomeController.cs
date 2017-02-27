using System.Web.Mvc;
using Holoholona.Models;
using Holoholona.Repositories.AnimalRepository;

namespace Holoholona.Controllers
{
    public class HomeController : Controller
    {
        private IAnimalRepository AnimalRepository;
        private bool debug = true;

        HomeController() {
            Debug(debug);
        }

        [NonAction]
        private void Debug(bool debug) {
            if (debug)
                AnimalRepository = new AnimalRepositoryMock();
            else
                AnimalRepository = new AnimalRepositoryProd();
        }

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
            MammalsViewModel Mammals = new MammalsViewModel { Dog = dog, Cat = cat };

            return Json(Mammals, JsonRequestBehavior.AllowGet);
        }
    }
}