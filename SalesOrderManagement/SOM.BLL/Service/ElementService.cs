using AutoMapper;
using SOM.Bll.IService;
using SOM.Core.DBModel;
using SOM.Core.Dto;
using SOM.Core.Model;
using SOM.DAL;
using SOM.DAL.UOF;

namespace SOM.Bll.Service
{
    public class ElementService : IElementService
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        public ElementService(IMapper mapper, IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        public async Task<List<ElementDto>> GetAll()
        {
            var data = await _unitOfWork.ElementRepository.GetAll();
            return _mapper.Map<List<ElementDto>>(data);
        }
        public async Task Add(ElementModel element)
        {
            var mappedResult = _mapper.Map<Element>(element);
            await _unitOfWork.ElementRepository.Insert(mappedResult);
            await _unitOfWork.CommitAsync();
        }
        public async Task Update(ElementModel element)
        {
            var existingElement = await _unitOfWork.ElementRepository.GetById((int)element.Id);
            if(existingElement != null)
            {
                existingElement.Width = element.Width;
                existingElement.Height = element.Height;
                existingElement.ElementTypeId = element.ElementTypeId;
                await _unitOfWork.ElementRepository.Update(existingElement);
                await _unitOfWork.CommitAsync();
            }
        }

        public async Task Delete(int id)
        {
            var element = await _unitOfWork.ElementRepository.GetById(id);
            if(element != null) 
            {
                element.IsDeleted = true;
                await _unitOfWork.ElementRepository.Update(element);
                await _unitOfWork.CommitAsync();
            }
        } 
    }
}
