using System.Web.Mvc;

namespace MvcApplication25.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.filePath = "https://getsamplefiles.com/download/pdf/sample-1.pdf";
            return View();
        }
    }
}
