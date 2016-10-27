using AutomatedTellerMaching.Models;
using Microsoft.AspNet.Identity;
using System.Linq;
using System.Web.Mvc;

namespace AutomatedTellerMaching.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        // [MyLoggingFilter] // this filter may need touch up in  my side
        [Authorize]
        public ActionResult Index()
        {
            var user = User.Identity.GetUserId();
            var checkingAccountId = db.CheckingAccounts.Where(c => c.ApplicationUserId == user).First().Id;
            ViewBag.CheckingAccountId = checkingAccountId;
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