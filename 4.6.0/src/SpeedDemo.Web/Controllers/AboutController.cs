using System.Web.Mvc;

namespace SpeedDemo.Web.Controllers
{
    public class AboutController : SpeedDemoControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}