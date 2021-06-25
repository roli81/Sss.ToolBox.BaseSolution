using System.Collections.Generic;
using Sss.Mutobo.Core.PageModels;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web.Models;

namespace Sss.Mutobo.Core.Interfaces
{
    public interface ITeaserService
    {
        IEnumerable<ArticlePage> GetTeaser(IEnumerable<IPublishedContent> content, int? width = null, int? height = null, ImageCropMode cropMode = ImageCropMode.Crop);
    }
}