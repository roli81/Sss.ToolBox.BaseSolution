using Sss.Mutobo.Core.PoCo;
using Umbraco.Core.Models.PublishedContent;

namespace Sss.Mutobo.Core.Interfaces
{
    public interface IMailService
    {
        void SendConfirmationMailService(ContactFormModel model, IPublishedContent customer);
        void SendContactMailService(ContactFormModel model, IPublishedContent receiver);
    }
}
