using System.Collections.Generic;
using Sss.Mutobo.Core.Interfaces;
using Sss.Mutobo.Core.PoCo;
using Link = Umbraco.Web.Models.Link;

namespace Sss.Mutobo.Core.Configuration
{
    public class EmptyFooterConfiguration : IFooterConfiguration
    {
        public IEnumerable<FooterNavBlock> FooterNavBlocks{ get;  set;}
        public IEnumerable<Link> FooterLinks{ get;  set;}
        public IEnumerable<FooterContactArea> FooterContactBlock{ get;  set;}
        public IEnumerable<Language> Languages{ get;  set;}
        public IEnumerable<PictureLink> PictureLinks{ get;  set;}
        public Image HomePageLogo { get; set; }
        public string Copyright{ get;  set;}
        public IEnumerable<Link> BlockLinks{ get;  set;}
        public string Theme{ get;  set;}
    }
}