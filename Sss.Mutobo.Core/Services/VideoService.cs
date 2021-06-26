using Sss.Mutobo.Core.Interfaces;
using Sss.Mutobo.Core.PoCo;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;

namespace Sss.Mutobo.Core.Services
{
    public class VideoService : IVideoService
    {
        public Video GetVideo(IPublishedContent node, int? width = null, int? height = null, bool showControls = true)
        {
            return new Video()
            {
                Width = width,
                Height = height,
                ShowControls = showControls,
                Source = node.MediaUrl()
            };
        }
    }
}
