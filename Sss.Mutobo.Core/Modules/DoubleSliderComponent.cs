using System.Collections.Generic;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using Sss.Mutobo.Core.Constants;
using Sss.Mutobo.Core.Enum;
using Sss.Mutobo.Core.Interfaces;
using Sss.Mutobo.Core.PoCo;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;

namespace Sss.Mutobo.Core.Modules
{
    public class DoubleSliderComponent : MutoboContentModule, IModule
    {
        public IEnumerable<TextImageSlide> Slides { get; set; }


        public int? Height => this.HasValue(DocumentTypes.DoubleSliderComponent.Fields.Height)
            ? this.Value<int?>(DocumentTypes.DoubleSliderComponent.Fields.Height)
            : null;

        public int? Interval => this.HasValue(DocumentTypes.DoubleSliderComponent.Fields.Interval)
            ? this.Value<int?>(DocumentTypes.DoubleSliderComponent.Fields.Interval) : null;



        public int? Width => this.HasValue(DocumentTypes.DoubleSliderComponent.Fields.Width)
            ? this.Value<int?>(DocumentTypes.DoubleSliderComponent.Fields.Width)
            : null;



        public string GetPictureNameSpace()
        {
            var result = "carousel-picture-";
            EGalleryType galleryType = EGalleryType.FullWidth;

            if (this.HasValue(DocumentTypes.DoubleSliderComponent.Fields.DisplayType))
            {
                galleryType = (EGalleryType)System.Enum.Parse(typeof(EGalleryType),
                    this.Value<string>(DocumentTypes.DoubleSliderComponent.Fields.DisplayType));

                if (galleryType == EGalleryType.Boxed)
                    result = "picture-";
            }

            return result;
        }



        public DoubleSliderComponent(IPublishedElement content) : base(content)
        {


        }

        public override IHtmlString RenderModule(HtmlHelper helper)
        {
            var bld = new StringBuilder();
            bld.Append(helper.Partial("~/Views/Partials/DoubleSlider.cshtml", this));

            if (SpacerAfterModule)
            {
                bld.Append("<div class=\"spacer\"></div>");
            }

            return new HtmlString(bld.ToString());
        }
    }
}
