using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;

namespace Sss.Mutobo.Core.PoCo
{
    public class Card : PublishedElementModel
    {
        public Image Image { get; set; }

        public Umbraco.Web.Models.Link DetailPageLink => this.HasValue(Constants.DocumentTypes.Card.Fields.DetailPageLink)
            ? this.Value<Umbraco.Web.Models.Link>(Constants.DocumentTypes.Card.Fields.DetailPageLink)
            : null;

        public int SortOrder { get; set; }

        public Card(IPublishedElement content) : base(content)
        {
        }
    }
}
