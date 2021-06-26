using System.Web.Mvc;
using Sss.Mutobo.Core.Common.Classes;

namespace Sss.Mutobo.Core.Common.ActionFilters
{
    public class CompressionCleaner : ActionFilterAttribute
    {
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {

            var response = filterContext.HttpContext.Response;

            if (response.ContentType == "text/html")
            {
                response.Filter = new MyCustomStream(filterContext.HttpContext.Response.Filter);
            }

            base.OnActionExecuted(filterContext);
        }


    }
}
