using AutoMapper;
using SOM.Bll.IService;
using SOM.Core.DBModel;
using SOM.Core.Dto;
using SOM.DAL;

namespace SOM.Bll.Service
{
    public class ElementService : IElementService
    {
        private readonly IRepository<Element, int> _elementRepository;
        private readonly IMapper _mapper;
        public ElementService(IRepository<Element, int> elementRepository, IMapper mapper)
        {
            _elementRepository = elementRepository;
            _mapper = mapper;
        }

        public async Task<List<ElementDto>> GetAll()
        {
            var data = await _elementRepository.GetAll();
            return _mapper.Map<List<ElementDto>>(data);
        }
        public async Task Add(ElementDto element)
        {
            var mappedResult = _mapper.Map<Element>(element);
            await _elementRepository.Insert(mappedResult);
        }
        public async Task Update(ElementDto element)
        {
            var mappeedResult = _mapper.Map<Element>(element);
            await _elementRepository.Update(mappeedResult);
        }

        public async Task Delete(int id)
        {
            await _elementRepository.Delete(id);
        } 
    }
}
