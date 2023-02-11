using SOM.Core.Model;
using SOM.Core.ViewModel;

namespace SOM.Bll.IService
{
    public interface IWindowService
    {
        Task Add(WindowModel element);
        Task<List<WindowViewModel>> GetAll();
        Task<WindowViewModel> GetById(int id);
        Task Update(WindowModel element);
        Task Delete(int id);
        Task<List<WindowElementViewModel>> GetWindowElementByWindowId(int id);
    }
}
