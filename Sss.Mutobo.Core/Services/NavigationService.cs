using System.Collections.Generic;
using System.Linq;
using Sss.Mutobo.Core.Common;
using Sss.Mutobo.Core.Common.Exceptions;
using Sss.Mutobo.Core.Constants;
using Sss.Mutobo.Core.Interfaces;
using Sss.Mutobo.Core.PageModels;
using Sss.Mutobo.Core.PoCo;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;

namespace Sss.Mutobo.Core.Services
{
    public class NavigationService : BaseService, INavigationService
    {

        private readonly IMutoboContentService _mutoboContentService;


        public NavigationService(IMutoboContentService mutoboContentService)
        {
            _mutoboContentService = mutoboContentService;
        }



        /// <summary>
        /// Return all pages bases on the  documentType "basePage" mapped
        /// on an IEnumerable of NavItem objects. All pages with a HideONNavigation flag
        /// will be filtered out of the result set.
        /// </summary>
        /// <returns>IEnumarable of NavItem</returns>
        public IEnumerable<NavItem> GetNavigation()
        {
            var result = new List<NavItem>();
            var homePage = DetermineHomeNode();

            if (homePage == null)
                throw new NavigationException("No Node found");

            if (homePage.Children != null && homePage.Children.Any())
            {
                foreach (var childNode in homePage.Children.Where(n => n.IsDocumentType(DocumentTypes.BasePage.Alias, true)))
                {
                    if (!childNode.Value<bool>(DocumentTypes.BasePage.Fields.HideFromNavigation))
                    {
                        result.Add(MapNode(childNode));
                    }
                }
            }

            return result;
        }

        private NavItem MapNode(IPublishedContent parentNode)
        {
            var result  = new NavItem() 
            {
                Title = parentNode.Name,
                Url = parentNode.Value<bool>(DocumentTypes.BasePage.Fields.NotClickable) ? "#" : parentNode.GetDitUrl(),
                NewWindow = parentNode.GetOpenInNewWindowFlag(),
                IsSearchPage = parentNode.ContentType.Alias == DocumentTypes.SearchResults.Alias



            };

            var childNavItems = new List<NavItem>();


  
                foreach (var childNode in parentNode.Children.Where(c => !(new BasePage(c)).HideFromNavigation))
                {
                    if (childNode.IsDocumentType(DocumentTypes.BasePage.Alias, true))
                    {


                        childNavItems.Add(new NavItem()
                        {
                            Title = childNode.Name,
                            Url = childNode.Value<bool>(DocumentTypes.BasePage.Fields.NotClickable) ? "#" : childNode.GetDitUrl(),
                            NewWindow = childNode.GetOpenInNewWindowFlag(),
                            IsSearchPage = childNode.ContentType.Alias == DocumentTypes.SearchResults.Alias

                        });

                    }
                }
            

            result.Children = childNavItems;
            return result;
        }



        private IPublishedContent DetermineHomeNode()
        {
            var node = Helper.AssignedContentItem;

            while (node.Parent != null)
            {
                node = node.Parent;

            } 

            return node;
        }
    }
}
