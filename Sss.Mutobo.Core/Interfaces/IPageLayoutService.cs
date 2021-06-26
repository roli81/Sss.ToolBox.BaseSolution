using Umbraco.Core.Models.PublishedContent;

namespace Sss.Mutobo.Core.Interfaces
{
    public interface IPageLayoutService
    {
        IHeaderConfiguration GetHeaderConfiguration(IPublishedContent content = null);
        IFooterConfiguration GetFooterConfiguration(IPublishedContent content = null);

    }
}
