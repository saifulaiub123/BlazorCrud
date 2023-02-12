

using SOM.Core.Model;
using SOM.Core.ViewModel;

namespace SOM.Bll.IService
{
    public interface IWindowElementService
    {
        Task<List<WindowElementViewModel>> GetByWindowId(int windowId);
        Task<List<WindowElementViewModel>> AddBulk(List<WindowElementModel> windowElementModel);
        Task Delete(int id);
    }
}
