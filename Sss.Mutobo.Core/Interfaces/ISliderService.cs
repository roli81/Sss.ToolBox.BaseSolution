using System.Collections.Generic;
using Sss.Mutobo.Core.PoCo;
using Sss.Mutotobo.Web.Interfaces;
using Umbraco.Core.Models.PublishedContent;

namespace Sss.Mutobo.Web.Interfaces
{
    public interface ISliderService
    {
        IEnumerable<ISliderItem> GetSlides(IPublishedElement content, string fieldName, int? width = null,
            int? height = null, bool isGoldenRatio = false);

        IEnumerable<TextImageSlide> GetDoubleSlides(IPublishedElement content, string fieldName, int? width = null,
            int? height = null, bool isGoldenRatio = false);
    }
}