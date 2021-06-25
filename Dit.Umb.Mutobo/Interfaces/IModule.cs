using System.Web;
using System.Web.Mvc;

namespace Sss.Mutobo.Core.Interfaces
{
    public interface IModule
    {
        string ModuleTitle { get; }
        bool SpacerAfterModule { get; }
        IHtmlString RenderModule(HtmlHelper helper);
    }
}
