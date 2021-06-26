using System.Collections.Generic;
using Sss.Mutobo.Core.Modules;
using Umbraco.Core.Models.PublishedContent;

namespace Sss.Mutobo.Core.PageModels
{
    public class ContentPage : ArticlePage
    {
        public IEnumerable<MutoboContentModule> Modules { get; set; }

        public ContentPage(IPublishedContent content) : base(content)
        {
        }
    }
}
