using Sss.Mutobo.Core.PageModels;
using Umbraco.Core.Models.PublishedContent;

namespace Sss.Mutobo.Core.Interfaces
{
    public interface IFormPageService
    {
        FormPage GetFormPageModel(IPublishedContent content);
    }
}
