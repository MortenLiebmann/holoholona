using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;
using System.Web.Mvc;

namespace Holoholona.Web.Controllers
{
    public class JsonController : Controller
    {
        // GET: Json
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public object GetGameStructure()
        {
            //JObject o1 = JObject.Parse(File.ReadAllText(Server.MapPath("~/scripts/gameStructure.json")));
            //// read JSON directly from a file
            //using (StreamReader file = File.OpenText(Server.MapPath("~/scripts/gameStructure.json")))
            //using (JsonTextReader reader = new JsonTextReader(file))
            //{
            //    JObject o2 = (JObject)JToken.ReadFrom(reader);
            //    return Json(o2, JsonRequestBehavior.AllowGet);
            //}

            string allText = System.IO.File.ReadAllText(Server.MapPath("~/scripts/gameStructure.json"));

            object jsonObject = JsonConvert.DeserializeObject(allText);
            return jsonObject;
        }
    }
}