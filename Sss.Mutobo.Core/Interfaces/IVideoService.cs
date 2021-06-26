using Sss.Mutobo.Core.PoCo;
using Umbraco.Core.Models.PublishedContent;

namespace Sss.Mutobo.Core.Interfaces
{
    public interface IVideoService
    {
        Video GetVideo(IPublishedContent node, int? width = null, int? height = null, bool showControls = true);
    }
}