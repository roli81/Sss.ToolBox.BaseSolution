using System.Collections.Generic;
using Sss.Mutobo.Core.Enum;
using Sss.Mutobo.Core.Interfaces;

namespace Sss.Mutobo.Core.Modules
{
    public class EmptySliderComponent : ISliderComponent
    {
        public IEnumerable<ISliderItem> Slides { get; set; }
        public int? Height { get; set; }
        public int? Interval { get; set; }
        public int? Width { get; set; }
        public EGalleryType GalleryType { get; set; }


        public string GetPictureNameSpace()
        {
            var result = "carousel-picture-";


            if (GalleryType == EGalleryType.Boxed)
                result = "picture-";
   

            return result;
        }


        public EmptySliderComponent()
        {
            
        }
    }
}
