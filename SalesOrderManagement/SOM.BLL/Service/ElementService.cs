using AutoMapper;
using SOM.Bll.IService;
using SOM.Core.DBModel;
using SOM.Core.Dto;
using SOM.Core.Model;
using SOM.Core.ViewModel;
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

        public async Task<List<ElementViewModel>> GetAll()
        {
            var data = await _unitOfWork.ElementRepository.GetAll(x=> !x.IsDeleted, y => y.ElementType);
            return _mapper.Map<List<ElementViewModel>>(data);
        }
        public async Task<List<ElementViewModel>> GetByWindowId(int id)
        {
            var data = await _unitOfWork.WindowElementRepository.GetAll(x=> x.WindowId == id && !x.Element.IsDeleted, y => y.Element, y => y.Element.ElementType);
            return _mapper.Map<List<ElementViewModel>>(data);
        }
        public async Task<ElementDto> GetById(int id)
        {
            var data = await _unitOfWork.ElementRepository.FindBy(x => !x.IsDeleted && x.Id == id);
            return _mapper.Map<ElementDto>(data);
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
            var windowElements = await _unitOfWork.WindowElementRepository.GetAll(x => x.ElementId == id);
            if(element != null) 
            {
                await _unitOfWork.ElementRepository.Delete(element);
                await _unitOfWork.WindowElementRepository.DeleteRange(windowElements);
                await _unitOfWork.CommitAsync();
            }
        } 
    }
}
