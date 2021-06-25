using System.Collections.Generic;
using Umbraco.Core.Models.PublishedContent;

namespace Sss.Mutobo.Core.PageModels
{
    public class TeaserPage : ArticlePage
    {

        public IEnumerable<ArticlePage> Teasers { get; set; }

        public TeaserPage(IPublishedContent content) : base(content)
        {


        }
    }
}
