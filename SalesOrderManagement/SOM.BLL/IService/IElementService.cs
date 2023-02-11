
using SOM.Core.Model;
using SOM.Core.ViewModel;

namespace SOM.Bll.IService
{
    public interface IElementService
    {
        Task Add(ElementModel element);
        Task<List<ElementViewModel>> GetAll();
        Task<List<ElementViewModel>> GetByWindowId(int id);
        Task<ElementViewModel> GetById(int id);
        Task Update(ElementModel element);
        Task Delete(int id);
    }
}
