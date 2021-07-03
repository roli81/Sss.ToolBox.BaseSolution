using System.Collections.Generic;
using Sss.Mutotobo.Web.Interfaces;

namespace Sss.Mutobo.Core.Interfaces
{
    public interface ISliderComponent
    {
        IEnumerable<ISliderItem> Slides { get; }
        int? Height { get; }
        int? Interval { get; }
        int? Width { get; }
        string GetPictureNameSpace();
    }
}