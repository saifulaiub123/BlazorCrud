using AutoMapper;
using SOM.Bll.IService;
using SOM.Core.DBModel;
using SOM.Core.Dto;
using SOM.Core.Model;
using SOM.Core.ViewModel;
using SOM.DAL.UOF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOM.Bll.Service
{
    public class WindowService : IWindowService
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        public WindowService(IMapper mapper, IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        public async Task<List<WindowViewModel>> GetAll()
        {
            var data = await _unitOfWork.WindowRepository.GetAll(x=> !x.IsDeleted, y=> y.WindowElement);
            var data2 =  _mapper.Map<List<WindowViewModel>>(data);
            return data2;
        }
        public async Task<WindowDto> GetById(int id)
        {
            var data = await _unitOfWork.WindowRepository.GetById(id);
            return _mapper.Map<WindowDto>(data);
        }
        public async Task Add(WindowModel window)
        {
            window.SubElement = window.WindowElement?.Count();
            var mappedResult = _mapper.Map<Window>(window);
            await _unitOfWork.WindowRepository.Insert(mappedResult);
            await _unitOfWork.CommitAsync();
        }
        public async Task Update(WindowModel window)
        {
            var existingWindow = await _unitOfWork.WindowRepository.GetById((int)window.Id);
            if (existingWindow != null)
            {
                existingWindow.Name = window.Name;
                existingWindow.Quantity = window.Quantity;
                //existingWindow.SubElement = window.ElementTypeId;
                await _unitOfWork.WindowRepository.Update(existingWindow);
                await _unitOfWork.CommitAsync();
            }
        }

        public async Task Delete(int id)
        {
            var window = await _unitOfWork.WindowRepository.GetById(id);
            var subElements = await _unitOfWork.WindowElementRepository.GetAll(x => x.WindowId == id);
            if (window != null)
            {
                window.IsDeleted = true;
                await _unitOfWork.WindowRepository.Update(window);
                if(subElements.Count() > 0)
                {
                    await _unitOfWork.WindowElementRepository.DeleteRange(subElements);
                }
                await _unitOfWork.CommitAsync();
            }
        }
    }
}
