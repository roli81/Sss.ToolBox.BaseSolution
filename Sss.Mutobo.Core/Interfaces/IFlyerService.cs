using System.Collections.Generic;
using Sss.Mutobo.Core.Modules;
using Umbraco.Core.Models.PublishedContent;

namespace Sss.Mutobo.Core.Interfaces
{
    public interface IFlyerService
    {
        IEnumerable<Flyer> GetFlyer(IPublishedContent node, bool firstPic = false);
    }
}
