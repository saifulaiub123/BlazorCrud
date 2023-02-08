using SOM.Core.Dto;
using SOM.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOM.Bll.IService
{
    public interface IOrderService
    {
        Task Add(OrderModel element);
        Task<List<OrderDto>> GetAll();
        Task<OrderDto> GetById(int id);
        Task Update(OrderModel element);
        Task Delete(int id);
    }
}
