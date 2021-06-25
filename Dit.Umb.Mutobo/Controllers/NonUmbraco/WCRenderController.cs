using System.Web.Mvc;
using Sss.Mutobo.Core.Interfaces;
using Sss.Mutobo.Core.PoCo;
using Umbraco.Web.Mvc;

namespace Sss.Mutobo.Core.Controllers.NonUmbraco
{
    public class WcRenderController : SurfaceController
    {
        private readonly IScriptService _scriptService;


        public WcRenderController(IScriptService scriptService)
        {
            _scriptService = scriptService;
        }


        // GET: WCRender
        public ActionResult Index()
        {
            var cached = Session["cachedJS"]?.ToString();

            if (true)
            {
                Session["cachedJS"] = _scriptService.GetWebComponentsBundled();
                cached = Session["cachedJS"].ToString();
            }
            return View("~/Views/NonUmbraco/WCScriptsView.cshtml", new ScriptModel(){ Script = cached });
        }
    }
}