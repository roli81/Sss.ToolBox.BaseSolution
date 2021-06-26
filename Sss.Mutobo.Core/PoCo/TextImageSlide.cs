﻿using Sss.Mutobo.Core.Constants;
using Sss.Mutobo.Core.Interfaces;
using Sss.Mutobo.Core.Modules;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;

namespace Sss.Mutobo.Core.PoCo
{
    public class TextImageSlide : MutoboContentModule, ISliderItem
    {
        public Image Image { get; set; }

        public string Text => this.HasValue(DocumentTypes.TextImageSlide.Fields.Text)
            ? this.Value<string>(DocumentTypes.TextImageSlide.Fields.Text)
            : null;

        public Umbraco.Web.Models.Link Link => this.HasValue(DocumentTypes.TextImageSlide.Fields.Link)
            ? this.Value<Umbraco.Web.Models.Link>(DocumentTypes.TextImageSlide.Fields.Link)
            : null;
        public string Title => this.HasValue(DocumentTypes.TextImageSlide.Fields.Title)
            ? this.Value<string>(DocumentTypes.TextImageSlide.Fields.Title)
            : null;

        public TextImageSlide(IPublishedElement content) : base(content)
        {
        }
    }
}
