using SOM.Core.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOM.Bll.IService
{
    public interface IElementService
    {
        Task Add(ElementDto element);
        Task<List<ElementDto>> GetAll();
        Task Update(ElementDto element);
        Task Delete(int id);
    }
}
