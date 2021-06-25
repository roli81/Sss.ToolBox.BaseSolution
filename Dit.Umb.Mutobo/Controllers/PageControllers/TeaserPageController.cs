﻿using System.Collections.Generic;
using System.Web.Mvc;
using Sss.Mutobo.Core.Constants;
using Sss.Mutobo.Core.Interfaces;
using Sss.Mutobo.Core.PageModels;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;
using Umbraco.Web.Models;

namespace Sss.Mutobo.Core.Controllers.PageControllers
{
    public class TeaserPageController : ArticlePageController
    {
        private readonly ITeaserService _teaserService;

        public TeaserPageController(IImageService imageService, ITeaserService teaserService) : base(imageService)
        {
            _teaserService = teaserService;
        }

        public override ActionResult Index(ContentModel model)
        {
            var customModel = new TeaserPage(model.Content);
            customModel.Teasers =
                _teaserService.GetTeaser(
                    model.Content.Value<IEnumerable<IPublishedContent>>(DocumentTypes.TeaserPage.Fields.Teasers));
            return base.Index<TeaserPage>(customModel);
        }
    }
}