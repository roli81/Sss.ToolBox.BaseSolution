using System.Web.Mvc;
using Umbraco.Web.Models;
using SearchResultModel = Sss.Mutobo.Core.PageModels.SearchResultModel;

namespace Sss.Mutobo.Core.Controllers.PageControllers
{
    public class SearchResultsController : BasePageController
    {


        // GET: ArticlePage
        public override ActionResult Index(ContentModel model)
        {
            return base.Index<SearchResultModel>(new SearchResultModel(model.Content)
            {

            });
            //return View("~/Views/Partials/SearchForm.cshtml", new SearchFormModel() { });
        }
    }
}