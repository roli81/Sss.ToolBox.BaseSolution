using System.Collections.Generic;
using Sss.Mutobo.Core.PoCo;
using Link = Umbraco.Web.Models.Link;


namespace Sss.Mutobo.Core.Interfaces
{
    public interface IHeaderConfiguration
    {
        Slogan GlobalSlogan { get;  }
        IEnumerable<NavItem> NavigationItems { get;  }

        Image Logo { get;  }

        Link LogoUrl { get;  }


        IEnumerable<Language> Languages { get;  }

        Image StageImage { get;  }
    }
}