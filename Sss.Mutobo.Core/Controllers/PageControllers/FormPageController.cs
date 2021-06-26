using System.Web.Mvc;
using Sss.Mutobo.Core.Interfaces;
using Sss.Mutobo.Core.PageModels;
using Umbraco.Web.Models;

namespace Sss.Mutobo.Core.Controllers.PageControllers
{
    public class FormPageController : BasePageController
    {
        private readonly IFormPageService _formPageService;

        public FormPageController(IFormPageService formPageService)
        {
            _formPageService = formPageService;
        }


        // GET: FormPage
        public override ActionResult Index(ContentModel model)
        {            
            return base.Index<FormPage>(new FormPage(model.Content));
        }
    }
}



