using SOM.Core.Dto;
using SOM.Core.Model;
using SOM.Core.ViewModel;

namespace SOM.Bll.IService
{
    public interface IElementService
    {
        Task Add(ElementModel element);
        Task<List<ElementViewModel>> GetAll();
        Task<List<ElementViewModel>> GetByWindowId(int id);
        Task<ElementDto> GetById(int id);
        Task Update(ElementModel element);
        Task Delete(int id);
    }
}
