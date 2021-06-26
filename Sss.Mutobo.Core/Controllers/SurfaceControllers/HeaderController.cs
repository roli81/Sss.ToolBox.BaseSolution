using System.Web.Mvc;
using Sss.Mutobo.Core.Interfaces;
using Umbraco.Web.Mvc;

namespace Sss.Mutobo.Core.Controllers.SurfaceControllers
{
    public class HeaderController : SurfaceController
    {
        private readonly IPageLayoutService _pageLayoutService;


        public HeaderController(IPageLayoutService pageLayoutService)
        {
            _pageLayoutService = pageLayoutService;
        }

        public ActionResult Index()
        {
            return View("~/Views/Partials/Header.cshtml", _pageLayoutService.GetHeaderConfiguration());
        }
    }
}