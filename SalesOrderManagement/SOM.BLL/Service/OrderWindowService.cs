using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SOM.Bll.IService;
using SOM.Core.DBModel;
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
    public class OrderWindowService : IOrderWindowService
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        public OrderWindowService(IMapper mapper, IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        public async Task<List<OrderWindowViewModel>> AddBulk(List<OrderWindowModel> orderWindowModel)
        {
            var data = _mapper.Map<List<OrderWindow>>(orderWindowModel);
            var returnData = await _unitOfWork.OrderWindowRepository.InsertRangeReturn(data);
            var ids = returnData.Select(x => x.Id).ToList();
            var returnIncludedData = await _unitOfWork.OrderWindowRepository.GetAll(x => ids.Contains(x.Id), y=> y.Window);
            var mappedResult = _mapper.Map<List<OrderWindowViewModel>>(returnIncludedData);
           
            return mappedResult;
        }

        public async Task Delete(int id)
        {
            await _unitOfWork.OrderWindowRepository.Delete(id);
            await _unitOfWork.CommitAsync();
        }

        public async Task<List<OrderWindowViewModel>> GetByOrderId(int orderId)
        {
            var result = await _unitOfWork.OrderWindowRepository.GetAll(x => x.OrderId == orderId, y => y.Window);
            var data = _mapper.Map<List<OrderWindowViewModel>>(result);
            return data;
        }
    }
}
