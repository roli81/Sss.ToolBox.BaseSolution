using System.Collections.Generic;
using Sss.Mutobo.Core.Modules;
using Umbraco.Core.Models.PublishedContent;

namespace Sss.Mutobo.Core.PageModels
{
    public class HomePage : BasePage
    {

        public IEnumerable<MutoboContentModule> Modules { get; set; }




        public HomePage(IPublishedContent content) : base(content)
        {



        }
    }
}
