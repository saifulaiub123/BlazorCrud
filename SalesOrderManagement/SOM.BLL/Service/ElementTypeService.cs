using AutoMapper;
using SOM.Bll.IService;
using SOM.Core.Dto;
using SOM.DAL.UOF;

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
