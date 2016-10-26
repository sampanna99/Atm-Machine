using System.Web.Mvc;

namespace AutomatedTellerMaching.Controllers
{
    public class HomeController : Controller
    {
        // [MyLoggingFilter] // this filter may need touch up in  my side
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.TheMessage = "Having trouble? Send us a message";

            return View();
        }

        [HttpPost]
        public ActionResult Contact(string message)
        {
            //TODO : send message to HQ
            ViewBag.TheMessage = "We got your message!";

            return View();
        }

        public ActionResult Foo()
        {
            return View("About");
        }
        public ActionResult Serial(string letterCase)
        {
            var serial = "hahaHmLa";
            if (letterCase == "lower")
            {
                return Content(serial.ToLower());
            }
            return Content(serial);
        }
    }
}