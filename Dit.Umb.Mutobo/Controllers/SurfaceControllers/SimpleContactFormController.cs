using System.Web.Mvc;
using Sss.Mutobo.Core.Constants;
using Sss.Mutobo.Core.Interfaces;
using Sss.Mutobo.Core.PoCo;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;
using Umbraco.Web.Mvc;

namespace Sss.Mutobo.Core.Controllers.SurfaceControllers
{
    public class SimpleContactFormController : SurfaceController
    {
        private readonly IMailService _mailservice;

        public SimpleContactFormController(IMailService mailservice)
        {
            _mailservice = mailservice;
        }

        public ActionResult Index(ContactFormModel model)
        {
            return View(model);
        }


        [HttpPost]
        public ActionResult SendContactForm(ContactFormModel model)
        {
            if (!ModelState.IsValid)
                return CurrentUmbracoPage();

            IPublishedContent configReceiver = Umbraco.Content(Request.Form["formReceiver"]);
            IPublishedContent configCustomer = Umbraco.Content(Request.Form["formCustomer"]);


            _mailservice.SendConfirmationMailService(model, configCustomer);
            _mailservice.SendContactMailService(model, configReceiver);

            var successPageId = CurrentPage.Value<IPublishedContent>(DocumentTypes.FormPage.Fields.SuccessPage);

            return RedirectToUmbracoPage(successPageId.Id);
        }
    }
}



