using AutoMapper;
using SOM.Core.DBModel;
using SOM.Core.Dto;
using SOM.Core.Model;
using SOM.Core.ViewModel;

namespace SOM.Core.Mapping
{
    public class WindowMapping : Profile
    {
        public WindowMapping()
        {
            CreateMap<WindowDto, Window>().ReverseMap();
            CreateMap<WindowModel, Window>().ReverseMap();
            CreateMap<WindowViewModel, WindowModel>().ReverseMap();
            CreateMap<WindowViewModel, Window>().ReverseMap()
                .ForMember(a => a.SubElement, b => b.MapFrom(b => b.WindowElement.Count()));
        }
    }
}
