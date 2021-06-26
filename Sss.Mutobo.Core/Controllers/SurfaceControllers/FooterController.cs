using System.Web.Mvc;
using Sss.Mutobo.Core.Interfaces;
using Umbraco.Web.Mvc;

namespace Sss.Mutobo.Core.Controllers.SurfaceControllers
{
    public class FooterController : SurfaceController
    {
        private readonly IPageLayoutService _pageLayoutService;

        public FooterController(IPageLayoutService pageLayoutService)
        {
            _pageLayoutService = pageLayoutService;
        }

        // GET: Footer
        public ActionResult Index()
        {
            return View("~/Views/Partials/Footer.cshtml", _pageLayoutService.GetFooterConfiguration());
        }
    }
}