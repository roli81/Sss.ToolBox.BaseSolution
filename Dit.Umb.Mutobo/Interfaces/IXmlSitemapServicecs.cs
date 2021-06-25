using System.Collections.Generic;
using Sss.Mutobo.Core.PageModels;
using Umbraco.Core.Models.PublishedContent;

namespace Sss.Mutobo.Core.Interfaces
{
    public interface IXmlSitemapServicecs
    {
        IEnumerable<BasePage> GetXmlSitemap(IPublishedContent model);
    }
}
