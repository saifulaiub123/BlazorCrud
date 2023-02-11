using AutoMapper;
using SOM.Core.DBModel;
using SOM.Core.Dto;
using SOM.Core.Model;

namespace SOM.Core.Mapping
{
    public class OrderMapping : Profile
    {
        public OrderMapping()
        {
            CreateMap<OrderDto, Order>().ReverseMap();
            CreateMap<OrderModel, Order>().ReverseMap();
            CreateMap<OrderWindowModel, OrderWindow>().ReverseMap();
        }
    }
}
