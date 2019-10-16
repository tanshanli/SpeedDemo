using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;
using SpeedDemo.Demo;

namespace SpeedDemo.Web.Controllers
{
    //[AbpMvcAuthorize]
    public class HomeController : SpeedDemoControllerBase
    {
        IDemoAppService demoAppService;
        public HomeController(IDemoAppService demoAppService)
        {
            this.demoAppService = demoAppService;
        }

        public void Demo()
        {
            demoAppService.Demo();
        }

        public ActionResult Index()
        {
            return View();
        }
	}
}