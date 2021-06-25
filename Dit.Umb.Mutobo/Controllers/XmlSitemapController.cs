using System.Web.Mvc;
using Sss.Mutobo.Core.Interfaces;
using Umbraco.Web.Models;
using Umbraco.Web.Mvc;

namespace Sss.Mutobo.Core.Controllers
{
    public class XmlSitemapController : RenderMvcController
    {
        private readonly IXmlSitemapServicecs _xmlSitemapService;

        public XmlSitemapController(IXmlSitemapServicecs xmlSitemapServicecs)
        {
            _xmlSitemapService = xmlSitemapServicecs;
        }

        // GET: XmlSitemap
        public ActionResult Index(ContentModel model)
        {
            return View("~/Views/XmlSiteMap.cshtml", _xmlSitemapService.GetXmlSitemap(model.Content));
        }
    }
}