using SOM.Core.Model;
using SOM.Core.ViewModel;

namespace SOM.Bll.IService
{
    public interface IOrderWindowService
    {
        //Task<List<WindowElementViewModel>> GetByWindowId(int windowId);
        Task<List<OrderWindowViewModel>> AddBulk(List<OrderWindowModel> orderWindowModel);
        Task Delete(int id);
    }
}
