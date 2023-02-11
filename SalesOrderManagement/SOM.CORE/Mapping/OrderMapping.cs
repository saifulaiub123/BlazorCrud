using AutoMapper;
using SOM.Core.DBModel;
using SOM.Core.Model;
using SOM.Core.ViewModel;

namespace SOM.Core.Mapping
{
    public class OrderMapping : Profile
    {
        public OrderMapping()
        {
            CreateMap<OrderViewModel, Order>().ReverseMap();
            CreateMap<OrderModel, Order>().ReverseMap();
            CreateMap<OrderWindowModel, OrderWindow>().ReverseMap();
        }
    }
}
