using System.Collections.Generic;
using Sss.Mutobo.Core.Modules;
using Umbraco.Core.Models.PublishedContent;

namespace Sss.Mutobo.Core.Interfaces
{
    public interface IMutoboContentService
    {
        IEnumerable<MutoboContentModule> GetContent(IPublishedContent content, string fieldName);
    }
}