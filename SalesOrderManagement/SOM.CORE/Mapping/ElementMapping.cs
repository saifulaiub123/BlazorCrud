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
        }
    }
}
