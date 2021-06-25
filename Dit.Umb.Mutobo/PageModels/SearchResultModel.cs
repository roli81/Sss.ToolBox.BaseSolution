using System.Collections.Generic;
using Sss.Mutobo.Core.Interfaces;
using Sss.Mutobo.Core.PoCo;
using Umbraco.Core.Models.PublishedContent;

namespace Sss.Mutobo.Core.PageModels
{
    public class SearchResultModel : BasePage, ISearchResultsModel
    {
        public string Term { get; set; }
        public string Page { get; set; }
        public IEnumerable<SearchResult> Results { get; set; }


        public SearchResultModel(IPublishedContent content) : base(content)
        {
        }
    }
}
