using System.Collections.Generic;
using Sss.Mutobo.Core.Constants;
using Sss.Mutobo.Core.Interfaces;
using Sss.Mutobo.Core.PoCo;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;
using Language = Sss.Mutobo.Core.PoCo.Language;
using Link = Umbraco.Web.Models.Link;


namespace Sss.Mutobo.Core.Configuration
{
    public class HeaderConfiguration : PublishedElementModel, IHeaderConfiguration
    {

        public Slogan GlobalSlogan { get; set; }
        public IEnumerable<NavItem> NavigationItems { get; set; }

        public Image Logo { get; set; }

        public Link LogoUrl => this.Value<Umbraco.Web.Models.Link>(DocumentTypes.Configuration.Link);

        public IEnumerable<Language> Languages { get; set; }

        public Image StageImage { get; set; }

        public HeaderConfiguration(IPublishedElement content) : base(content)
        {



        }
    }
}
