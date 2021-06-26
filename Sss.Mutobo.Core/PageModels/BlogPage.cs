using System.Collections.Generic;
using System.Linq;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;

namespace Sss.Mutobo.Core.PageModels
{
    public class BlogPage : ArticlePage
    {
        public IEnumerable<ContentPage> BlogEntries => Content.Children<IPublishedContent>()
            .Select(c => new ContentPage(c));

        public BlogPage(IPublishedContent content) : base(content)
        {
        }
    }
}
