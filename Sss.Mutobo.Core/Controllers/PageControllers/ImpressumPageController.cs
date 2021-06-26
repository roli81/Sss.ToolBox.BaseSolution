using System.Web.Mvc;
using Sss.Mutobo.Core.Interfaces;
using Sss.Mutobo.Core.PageModels;
using Umbraco.Web.Models;

namespace Sss.Mutobo.Core.Controllers.PageControllers
{
    public class ImpressumPageController : BasePageController
    {
        private readonly IPageLayoutService _pageLayoutService;


        public ImpressumPageController(IPageLayoutService pageLayoutService)
        {
            _pageLayoutService = pageLayoutService;
        }


        // GET: ImpressumPage
        public override ActionResult Index(ContentModel model)
        {
            return base.Index<ImpressumPage>(new ImpressumPage(model.Content)
            {
            });
        }
    }
}