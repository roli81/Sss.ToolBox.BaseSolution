using System.Web.Mvc;
using Sss.Mutobo.Core.Constants;
using Sss.Mutobo.Core.Interfaces;
using Sss.Mutobo.Core.PageModels;
using Umbraco.Core.Logging;
using Umbraco.Web.Models;

namespace Sss.Mutobo.Core.Controllers.PageControllers
{
    public class HomePageController : BasePageController
    {
        protected readonly IMutoboContentService _contentService;


        public HomePageController(IMutoboContentService contentService)
        {
            Logger.Info<HomePageController>("HomePageController initialized");
            _contentService = contentService;
        }


        public override ActionResult Index(ContentModel model)
        {

            var basepage = new BasePage(model.Content);



            return base.Index<HomePage>(new HomePage(model.Content)
            {
                Modules = _contentService.GetContent(model.Content, DocumentTypes.HomePage.Fields.Modules)
            });
        }
    }
}