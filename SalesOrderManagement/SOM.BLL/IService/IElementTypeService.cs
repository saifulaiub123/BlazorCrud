using SOM.Core.Dto;
using SOM.Core.ViewModel;

namespace SOM.Bll.IService
{
    public interface IElementTypeService
    {
        Task<List<ElementTypeDto>> GetAll();
    }
}
