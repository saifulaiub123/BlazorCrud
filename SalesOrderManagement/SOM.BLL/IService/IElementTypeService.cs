using SOM.Core.ViewModel;

namespace SOM.Bll.IService
{
    public interface IElementTypeService
    {
        Task<List<ElementTypeViewModel>> GetAll();
    }
}
