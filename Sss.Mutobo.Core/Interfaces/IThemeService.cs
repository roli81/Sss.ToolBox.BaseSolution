using System.Collections.Generic;
using Sss.Mutobo.Core.PoCo;
using Umbraco.Core.Models.PublishedContent;

namespace Sss.Mutobo.Core.Interfaces
{
    public interface IThemeService
    {
        ITheme GetTheme(IPublishedContent content);
        IEnumerable<Font> GetFonts();
    }
}