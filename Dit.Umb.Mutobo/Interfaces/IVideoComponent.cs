using System;
using System.Web;
using Sss.Mutobo.Core.PoCo;

namespace Sss.Mutobo.Core.Interfaces
{
    public interface IVideoComponent
    {
        Video Video { get;  }
        String Embedded { get; }
        String Text { get; }
        int? Width { get; }
        int? Height { get; }
        IHtmlString RenderIFrame(int? width = null, int? height = null);
    }
}