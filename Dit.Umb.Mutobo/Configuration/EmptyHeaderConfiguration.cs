using System.Collections.Generic;
using Sss.Mutobo.Core.Interfaces;
using Sss.Mutobo.Core.PoCo;
using Link = Umbraco.Web.Models.Link;


namespace Sss.Mutobo.Core.Configuration
{
    public class EmptyHeaderConfiguration : IHeaderConfiguration
    {
        public Slogan GlobalSlogan { get; set; }
        public IEnumerable<NavItem> NavigationItems { get; set; }
        public Image Logo { get; set; }
        public Link LogoUrl { get; set; }
        public IEnumerable<Language> Languages { get; set; }
        public Image StageImage { get; set; }
    }
}
