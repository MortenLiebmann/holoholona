using Holoholona.Models;
using System.Web.Mvc;
using Holoholona.Repositories.AnimalRepository;
using System.Collections.Generic;

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
        public ActionResult GetDog(int id)
        {
            Animal dog = AnimalRepository.GetAnimal(id);

            return Json(dog, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public ActionResult GetMammals()
        {
            List<Animal> Mammals = AnimalRepository.GetAnimals();

            return Json(Mammals, JsonRequestBehavior.AllowGet);
        }
    }
}