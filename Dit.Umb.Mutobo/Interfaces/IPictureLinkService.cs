using System.Collections.Generic;
using Sss.Mutobo.Core.PoCo;
using Umbraco.Core.Models.PublishedContent;

namespace Sss.Mutobo.Core.Interfaces
{
    public interface IPictureLinkService
    {
        IEnumerable<PictureLink> GetPictureLinks(IEnumerable<IPublishedElement> elements);
    }
}