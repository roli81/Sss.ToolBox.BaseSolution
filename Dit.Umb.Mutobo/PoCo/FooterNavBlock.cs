using System.Collections.Generic;

namespace Sss.Mutobo.Core.PoCo
{
    public class FooterNavBlock
    {
        public Link Title { get; set; }
        public IEnumerable<Link> Children { get; set; }
    }
}
