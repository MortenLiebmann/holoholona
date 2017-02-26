using Holoholona.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Holoholona.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
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