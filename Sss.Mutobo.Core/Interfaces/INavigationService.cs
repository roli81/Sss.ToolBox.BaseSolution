using System.Collections.Generic;
using Sss.Mutobo.Core.PoCo;

namespace Sss.Mutobo.Core.Interfaces
{
    public interface INavigationService
    {

        /// <summary>
        /// Return all pages bases on the  documentType "basePage" mapped
        /// on an IEnumerable of NavItem objects. All pages with a HideONNavigation flag
        /// will be filtered out of the result set.
        /// </summary>
        /// <returns>IEnumarable of NavItem</returns>
        IEnumerable<NavItem> GetNavigation();
    }
}