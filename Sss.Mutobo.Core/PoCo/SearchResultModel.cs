using System.Collections.Generic;
using Sss.Mutobo.Core.Interfaces;

namespace Sss.Mutobo.Core.PoCo
{
    public class SearchResultModel : ISearchResultsModel
    {
        public string Term { get; set; }
        public string Page { get; set; }
        public IEnumerable<SearchResult> Results { get; set; }
    }
}
