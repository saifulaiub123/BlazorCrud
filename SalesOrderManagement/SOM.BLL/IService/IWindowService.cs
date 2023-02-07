using SOM.Core.Dto;
using SOM.Core.Model;

namespace SOM.Bll.IService
{
    public interface IWindowService
    {
        Task Add(WindowModel element);
        Task<List<WindowDto>> GetAll();
        Task<WindowDto> GetById(int id);
        Task Update(WindowModel element);
        Task Delete(int id);
    }
}
