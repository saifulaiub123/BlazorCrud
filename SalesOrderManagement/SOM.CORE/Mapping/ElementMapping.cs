using AutoMapper;
using SOM.Core.DBModel;
using SOM.Core.Dto;
using SOM.Core.Model;
using SOM.Core.ViewModel;

namespace SOM.Core.Mapping
{
    public class ElementMapping : Profile
    {
        public ElementMapping()
        {
            CreateMap<ElementDto, Element>().ReverseMap();
            CreateMap<ElementTypeDto, ElementType>().ReverseMap();
            CreateMap<ElementModel, Element>().ReverseMap();
            CreateMap<ElementViewModel, Element>().ReverseMap()
                .ForMember(a => a.ElementTypeName, b => b.MapFrom(b => b.ElementType.Name));
            CreateMap<ElementViewModel, WindowElement>().ReverseMap()
                .ForMember(a => a.Id, b => b.MapFrom(b => b.Element.Id))
                .ForMember(a => a.Width, b => b.MapFrom(b => b.Element.Width))
                .ForMember(a => a.Height, b => b.MapFrom(b => b.Element.Height))
                .ForMember(a => a.ElementTypeId, b => b.MapFrom(b => b.Element.ElementTypeId))
                .ForMember(a => a.ElementTypeName, b => b.MapFrom(b => b.Element.ElementType.Name));

            CreateMap<ElementViewModel,WindowElementViewModel>()
                .ForMember(a => a.ElementId, b => b.MapFrom(b => b.Id))
                .ForMember(a => a.Height, b => b.MapFrom(b => b.Height))
                .ForMember(a => a.Width, b => b.MapFrom(b => b.Width))
                .ReverseMap();
        }
    }
}
