using AutoMapper;
using SOM.Bll.IService;
using SOM.Core.DBModel;
using SOM.Core.Model;
using SOM.Core.ViewModel;
using SOM.DAL.UOF;

namespace SOM.Bll.Service
{
    public class WindowElementService : IWindowElementService
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        public WindowElementService(IMapper mapper, IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        public async Task AddBulk(List<WindowElementModel> windowElementModel)
        {
            var data = _mapper.Map<List<WindowElement>>(windowElementModel);
            await _unitOfWork.WindowElementRepository.InsertRange(data);
            await _unitOfWork.CommitAsync();
        }

        public async Task Delete(int id)
        {
            await _unitOfWork.WindowElementRepository.Delete(id);
            await _unitOfWork.CommitAsync();
        }

        public async Task<List<WindowElementViewModel>> GetByWindowId(int windowId)
        {
            var result = await _unitOfWork.WindowElementRepository.GetAll(x => x.WindowId == windowId, y=> y.Window, y=> y.Element, y=> y.Element.ElementType);
            var data = _mapper.Map<List<WindowElementViewModel>>(result);
            return data;
        }
    }
}
