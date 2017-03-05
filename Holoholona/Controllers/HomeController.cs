using System.Web.Mvc;
using System.Linq;
using Holoholona.Web.Models;
using Holoholona.Services;

namespace Holoholona.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult GetAnimal(int id)
        {
            var AnimalService = ServiceFactory.AnimalService;

            var Animal = AnimalService.GetAnimal(id);

            return Json(Animal, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public ActionResult GetAnimals()
        {
            var AnimalService = ServiceFactory.AnimalService;

            var Animals = ServiceFactory.AnimalService.GetAnimals().AsEnumerable()
                .OrderBy(x => x.Id)
                .Select(x => new Animal {
                    Id = x.Id,
                    Name = x.Name,
                    Type = x.Type
            });

            return Json(Animals, JsonRequestBehavior.AllowGet);
        }
    }
}