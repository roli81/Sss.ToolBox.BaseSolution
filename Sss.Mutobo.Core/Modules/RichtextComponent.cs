using System.Text;
using System.Web;
using System.Web.Mvc;
using Sss.Mutobo.Core.Constants;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;

namespace Sss.Mutobo.Core.Modules
{
    public class RichtextComponent : MutoboContentModule
    {
        public string RichText => this.HasValue(DocumentTypes.RichTextComponent.Fields.RichText)
            ? this.Value<string>(DocumentTypes.RichTextComponent.Fields.RichText)
            : string.Empty;

        public RichtextComponent(IPublishedElement content) : base(content)
        {
        }

        public override IHtmlString RenderModule(HtmlHelper helper)
        {
            var bld = new StringBuilder();

            bld.Append($"<article>{helper.Raw(RichText)}</article>");
            if (SpacerAfterModule)
            {
                bld.Append("<div class=\"spacer\"></div>");
            }

            return new MvcHtmlString(bld.ToString());
        }
    }
}
