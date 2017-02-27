using Holoholona.Models;
using System.Web.Mvc;
using Holoholona.Models.Enums;
using Holoholona.Repositories.AnimalRepository;

namespace Holoholona.Controllers
{
    public class HomeController : Controller
    {
        private IAnimalRepository AnimalRepository;
        private bool debug = true;

        public HomeController()
        {
            DebugAble(debug);
        }

        [NonAction]
        private void DebugAble(bool debug)
        {
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
            Animal dog = new Dog { Name = "Chihuahua", Type = AnimalTypeEnum.Mammal};
            
            return Json(dog, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public ActionResult GetMammals()
        {
            Animal dog = new Dog { Name = "Chihuahua", Type = AnimalTypeEnum.Mammal };
            Animal cat = new Cat { Name = "Siameser", Type = AnimalTypeEnum.Mammal };
            MammalsViewModel Mammals = new MammalsViewModel { Dog = dog, Cat = cat };

            return Json(Mammals, JsonRequestBehavior.AllowGet);
        }
    }
}