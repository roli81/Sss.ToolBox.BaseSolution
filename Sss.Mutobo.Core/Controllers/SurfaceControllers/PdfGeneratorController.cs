using System.Web.Mvc;
using Sss.Mutobo.Core.Interfaces;
using Umbraco.Web.Composing;
using Umbraco.Web.Mvc;

namespace Sss.Mutobo.Core.Controllers.SurfaceControllers
{
    public class PdfGeneratorController : SurfaceController
    {
        private readonly IPdfService _pdfService;



        public PdfGeneratorController(IPdfService pdfService)
        {
            _pdfService = pdfService;
        }


        // GET: PdfGenerator
        [System.Web.Mvc.HttpGet]
        public ActionResult GetPdf()
        {
            return new EmptyResult();
        }
    }
}