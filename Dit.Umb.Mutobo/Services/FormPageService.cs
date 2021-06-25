using Sss.Mutobo.Core.Interfaces;
using Sss.Mutobo.Core.PageModels;
using Sss.Mutobo.Core.PoCo;
using Umbraco.Core.Models.PublishedContent;

namespace Sss.Mutobo.Core.Services
{
    public class FormPageService : BaseService, IFormPageService
    {
        private readonly IImageService _imageService;

        public FormPageService(IImageService imageService)
        {
            _imageService = imageService;
        }

        public FormPage GetFormPageModel(IPublishedContent content)
        {
            var result = new FormPage(content);

            result.ContactFormModel = new ContactFormModel()
            {
                LabelName = result.LabelName,
                LabelFirstName = result.LabelFirstName,
                LabelAddress = result.LabelAddress,
                LabelZipCity = result.LabelZipCity,
                LabelPhone = result.LabelPhone,
                LabelMail = result.LabelMail,
                LabelMessage = result.LabelMessage,
                Receiver = result.ReceiverConfiguration,
                Customer = result.CustomerConfiguration
            };

            return result;
        }
    }
}
