using System.Web.Mvc;
using Sss.Mutobo.Core.Interfaces;
using Sss.Mutobo.Core.PoCo;
using Umbraco.Web.Mvc;

namespace Sss.Mutobo.Core.Controllers.SurfaceControllers
{
    public class CookieBannerController : SurfaceController
    {
        private readonly IConfigurationService _configurationService;


        public CookieBannerController(IConfigurationService configurationService)
        {
            _configurationService = configurationService;
        }


        public ActionResult Index()
        {
            return View("~/Views/Partials/CookieBanner.cshtml", new CookieBannerModel()
            {
                ApiKey = _configurationService.GetAppSettingValue("Classics.CookieBanner.APIKey"),
                Theme = _configurationService.GetAppSettingValue("Classics.CookieBanner.Theme"),
                Environment = _configurationService.GetAppSettingValue("Classics.CookieBanner.Environment")
            });
        }
    }
}