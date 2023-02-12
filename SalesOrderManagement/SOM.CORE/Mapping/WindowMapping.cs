using AutoMapper;
using SOM.Core.DBModel;
using SOM.Core.Model;
using SOM.Core.ViewModel;

namespace SOM.Core.Mapping
{
    public class WindowMapping : Profile
    {
        public WindowMapping()
        {
            CreateMap<WindowModel, Window>().ReverseMap();
            CreateMap<WindowViewModel, WindowModel>().ReverseMap();
            CreateMap<WindowViewModel, Window>().ReverseMap()
                .ForMember(a => a.SubElement, b => b.MapFrom(b => b.WindowElement.Count()));
            CreateMap<OrderWindow,WindowViewModel>()
                .ForMember(a => a.Id, b => b.MapFrom(b => b.WindowId))
                .ForMember(a => a.Name, b => b.MapFrom(b => b.Window.Name))
                .ForMember(a => a.Quantity, b => b.MapFrom(b => b.Window.Quantity))
                .ReverseMap();
            CreateMap<OrderWindow,OrderWindowViewModel>()
                .ForMember(a => a.Id, b => b.MapFrom(b => b.Id))                            
                .ForMember(a => a.WindowId, b => b.MapFrom(b => b.WindowId))
                .ForMember(a => a.WindowName, b => b.MapFrom(b => b.Window.Name))
                .ForMember(a => a.WindowQuantity, b => b.MapFrom(b => b.Window.Quantity))
                .ReverseMap();

            //CreateMap<OrderWindow, OrderWindowViewModel>()
            //    .ForMember(a => a.Id, b => b.MapFrom(b => b.Id))
            //    .ForMember(a => a.WindowId, b => b.MapFrom(b => b.WindowId))
            //    .ForMember(a => a.WindowName, b => b.MapFrom(b => b.Window.Name))
            //    .ForMember(a => a.WindowQuantity, b => b.MapFrom(b => b.Window.Quantity))
            //    .ReverseMap();

        }
    }
}
