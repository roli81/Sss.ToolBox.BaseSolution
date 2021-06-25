using System.Collections.Generic;
using Sss.Mutobo.Core.PoCo;

namespace Sss.Mutobo.Core.Interfaces
{
    public interface ISearchResultsModel
    {
        string Term { get; set; }
        string Page { get; set; }
        IEnumerable<SearchResult> Results { get; set; }
    }
}