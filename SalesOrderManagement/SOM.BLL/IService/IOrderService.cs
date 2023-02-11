using SOM.Core.Model;
using SOM.Core.ViewModel;

namespace SOM.Bll.IService
{
    public interface IOrderService
    {
        Task Add(OrderModel element);
        Task<List<OrderViewModel>> GetAll();
        Task<OrderViewModel> GetById(int id);
        Task Update(OrderModel element);
        Task Delete(int id);
    }
}
