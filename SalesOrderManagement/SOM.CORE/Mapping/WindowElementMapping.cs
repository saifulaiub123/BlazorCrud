using AutoMapper;
using SOM.Core.DBModel;
using SOM.Core.Dto;
using SOM.Core.Model;
using SOM.Core.ViewModel;
namespace SOM.Core.Mapping
{
    public class WindowElementMapping : Profile
    {
        public WindowElementMapping()
        {
            CreateMap<WindowElementDto, WindowElement>().ReverseMap();
            CreateMap<WindowElementModel, WindowElement>().ReverseMap();
            CreateMap<WindowElementModel, WindowElementViewModel>().ReverseMap();
            CreateMap<WindowElement,WindowElementViewModel>()
                .ForMember(a => a.Width, b => b.MapFrom(b => b.Element.Width))
                .ForMember(a => a.Height, b => b.MapFrom(b => b.Element.Height))
                .ForMember(a => a.WindowName, b => b.MapFrom(b => b.Window.Name))
                .ForMember(a => a.ElementTypeName, b => b.MapFrom(b => b.Element.ElementType.Name))
                .ReverseMap();
        }
    }
}
