using Sss.Mutobo.Core.Configuration;
using Umbraco.Core.Models.PublishedContent;

namespace Sss.Mutobo.Core.Interfaces
{
    public interface ISeoService
    {
        SeoConfiguration GetSeoConfiguration(IPublishedContent content);
    }
}