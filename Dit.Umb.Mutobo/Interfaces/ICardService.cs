using System.Collections.Generic;
using Sss.Mutobo.Core.PoCo;
using Umbraco.Core.Models.PublishedContent;

namespace Sss.Mutobo.Core.Interfaces
{
    public interface ICardService
    {
        IEnumerable<Card> GetCards(IPublishedElement element, string fieldName);
    }
}