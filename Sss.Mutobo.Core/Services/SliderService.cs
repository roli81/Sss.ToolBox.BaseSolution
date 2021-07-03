using System.Collections.Generic;
using Sss.Mutobo.Core.Interfaces;
using Sss.Mutobo.Core.Modules;
using Sss.Mutobo.Core.PoCo;
using Sss.Mutobo.Web.Interfaces;
using Sss.Mutotobo.Web.Interfaces;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;
using DocumentTypes = Sss.Mutobo.Core.Constants.DocumentTypes;

namespace Sss.Mutobo.Core.Services
{
    public class SliderService : ISliderService
    {

        private readonly IImageService _imageService;


        public SliderService(IImageService imageService, IConfigurationService configurationService)
        {
            _imageService = imageService;

        }


        public IEnumerable<ISliderItem> GetSlides(IPublishedElement content, string fieldName, int? width = null, int? height = null, bool isGoldenRatio = false)
        {
            var result = new List<ISliderItem>();

            if (content.HasValue(fieldName))
            {
                var slideContent = content.Value<IEnumerable<IPublishedElement>>(fieldName);

                foreach (var slideNode in slideContent)
                {
                    if (slideNode.ContentType.Alias == DocumentTypes.VideoComponent.Alias)
                    {
                        var vc = new VideoComponent(slideNode);

                        result.Add(new EmptyVideoComponent()
                        {
                            Height = height,
                            Width = width,
                            Embedded = vc.Embedded,
                            Text = vc.Text,
                            Video = vc.Video
                        });
                    }
                    else if (slideNode.ContentType.Alias == DocumentTypes.Picture.Alias)
                    {
                        result.Add(new Picture()
                        {
                            Image = slideNode.HasValue(DocumentTypes.Picture.Fields.Image) ? _imageService.GetImage(
                                slideNode.Value<IPublishedContent>(DocumentTypes.Picture.Fields.Image), width, height, isGoldenRatio: isGoldenRatio) : null
                        });
                    }


                }

            }

            return result;
        }

        public IEnumerable<TextImageSlide> GetDoubleSlides(IPublishedElement content, string fieldName, int? width = null, int? height = null,
            bool isGoldenRatio = false)
        {

            var result = new List<ISliderItem>();
            if (content.HasValue(fieldName))
            {
                var slideContent = content.Value<IEnumerable<IPublishedElement>>(fieldName);

                foreach (var slideNode in slideContent)
                {
     
                        var textImageComponent = new TextImageSlide(slideNode);

                        result.Add(new TextImageSlide(slideNode)
                        {
                           Image = slideNode.HasValue(DocumentTypes.Picture.Fields.Image) ? _imageService.GetImage(
                               slideNode.Value<IPublishedContent>(DocumentTypes.DoubleSliderComponent.Fields.Image), width, height, isGoldenRatio: isGoldenRatio) : null
                        });



                }

            }

        }
    }
}
