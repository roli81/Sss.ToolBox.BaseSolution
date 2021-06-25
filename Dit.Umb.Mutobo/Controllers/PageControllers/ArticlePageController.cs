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
    public class ArticlePageController : BasePageController
    {

        protected readonly IImageService _imageService;



        public ArticlePageController(IImageService imageService)
        {

            _imageService = imageService;
        }



        // GET: ArticlePage
        public override ActionResult Index(ContentModel model)
        {
            return base.Index<ArticlePage>(new ArticlePage(model.Content)
            {
                EmotionImages = model.Content.HasValue(DocumentTypes.ArticlePage.Fields.EmotionImages) 
                    ? _imageService.GetImages(model.Content.Value<IEnumerable<IPublishedContent>>(DocumentTypes.ArticlePage.Fields.EmotionImages)) 
                    : new List<Image>()
            });
        }



        
    }
}