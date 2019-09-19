using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace SpeedDemo.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : SpeedDemoControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}