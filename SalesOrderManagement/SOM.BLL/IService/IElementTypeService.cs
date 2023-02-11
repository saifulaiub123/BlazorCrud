using SOM.Core.Dto;

namespace SOM.Bll.IService
{
    public interface IElementTypeService
    {
        Task<List<ElementTypeDto>> GetAll();
    }
}
