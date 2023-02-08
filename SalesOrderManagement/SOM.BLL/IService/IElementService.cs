using SOM.Core.Dto;
using SOM.Core.Model;
using SOM.Core.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOM.Bll.IService
{
    public interface IElementService
    {
        Task Add(ElementModel element);
        Task<List<ElementViewModel>> GetAll();
        Task<ElementDto> GetById(int id);
        Task Update(ElementModel element);
        Task Delete(int id);
    }
}
