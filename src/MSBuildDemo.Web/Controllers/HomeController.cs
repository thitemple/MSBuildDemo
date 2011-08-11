using System.Web.Mvc;
using MSBuildDemo.Common;

namespace MSBuildDemo.Web.Controllers
{
    [HandleError]
    [CoverageExclude]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewData["Message"] = "Welcome to ASP.NET MVC!";

            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
