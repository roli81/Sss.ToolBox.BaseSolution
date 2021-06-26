using System.Web.Mvc;
using Sss.Mutobo.Core.Interfaces;
using Sss.Mutobo.Core.PoCo;

namespace Sss.Mutobo.Core.Common.Helpers
{
    public static class LayoutHelper
    {
        public static ImageSize GetImageSize(int factor = 1)
        {
            var configService =
                (IConfigurationService) DependencyResolver.Current.GetService(typeof(IConfigurationService));

            return new ImageSize()
            {
                Width = configService.GetAppSettingIntValue("ImageDefaultWidth") ?? 0,
                Height = configService.GetAppSettingIntValue("ImageDefaultHeight") ?? 0
            };
        }
    }
}
