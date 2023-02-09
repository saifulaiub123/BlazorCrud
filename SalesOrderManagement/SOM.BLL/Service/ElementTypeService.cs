using AutoMapper;
using SOM.Bll.IService;
using SOM.Core.Dto;
using SOM.Core.ViewModel;
using SOM.DAL.UOF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOM.Bll.Service
{
    public class ElementTypeService : IElementTypeService
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        public ElementTypeService(IMapper mapper, IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        public async Task<List<ElementTypeDto>> GetAll()
        {
            var data = await _unitOfWork.ElementTypeRepository.GetAll();
            return _mapper.Map<List<ElementTypeDto>>(data);
        }
    }
}
