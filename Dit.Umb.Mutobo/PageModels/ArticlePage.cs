using System.Collections.Generic;
using Sss.Mutobo.Core.Constants;
using Sss.Mutobo.Core.PoCo;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;

namespace Sss.Mutobo.Core.PageModels
{
    public class ArticlePage : BasePage
    {

        public string Abstract => Content.Value<string>(DocumentTypes.ArticlePage.Fields.Abstract);
        public bool HideAbstract => Content.Value<bool>(DocumentTypes.ArticlePage.Fields.HideAbstract);
        public string MainContent => Content.Value<string>(DocumentTypes.ArticlePage.Fields.MainContent);



        public IEnumerable<Image> EmotionImages  { get; set; }


        public ArticlePage(IPublishedContent content) : base(content)
        {

        }


    }
}
