using System.Collections.Generic;
using System.Web.Mvc;
using Sss.Mutobo.Core.Constants;
using Sss.Mutobo.Core.Interfaces;
using Sss.Mutobo.Core.PageModels;
using Sss.Mutobo.Core.PoCo;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;
using Umbraco.Web.Models;

namespace Sss.Mutobo.Core.Controllers.PageControllers
{
    public class ContentPageController : ArticlePageController
    {

        protected readonly IMutoboContentService _mutoboContentService;


        public ContentPageController(IMutoboContentService mutoboContentService, IImageService imageService) : base(imageService)
        {
         
            _mutoboContentService = mutoboContentService;
        }

        // GET: HighlightsPage
        public override ActionResult Index(ContentModel model)
        {
            return base.Index<ContentPage>(new ContentPage(model.Content)
            {
                EmotionImages = model.Content.HasValue(DocumentTypes.ArticlePage.Fields.EmotionImages)
                    ? _imageService.GetImages(model.Content.Value<IEnumerable<IPublishedContent>>(DocumentTypes.ArticlePage.Fields.EmotionImages))
                    : new List<Image>(),
                Modules = _mutoboContentService.GetContent(model.Content, DocumentTypes.ContentPage.Fields.Modules)
            });
        }


    }
}