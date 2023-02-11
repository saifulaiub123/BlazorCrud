using AutoMapper;
using SOM.Bll.IService;
using SOM.Core.DBModel;
using SOM.Core.Model;
using SOM.Core.ViewModel;
using SOM.DAL.UOF;

namespace SOM.Bll.Service
{
    public class OrderService : IOrderService
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        public OrderService(IMapper mapper, IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        public async Task<List<OrderViewModel>> GetAll()
        {
            var data = await _unitOfWork.OrderRepository.GetAll();
            return _mapper.Map<List<OrderViewModel>>(data);
        }
        public async Task<OrderViewModel> GetById(int id)
        {
            var data = await _unitOfWork.OrderRepository.GetById(id);
            return _mapper.Map<OrderViewModel>(data);
        }
        public async Task Add(OrderModel order)
        {
            var mappedResult = _mapper.Map<Order>(order);
            await _unitOfWork.OrderRepository.Insert(mappedResult);
            await _unitOfWork.CommitAsync();
        }
        public async Task Update(OrderModel order)
        {
            var existingOrder = await _unitOfWork.OrderRepository.GetById((int)order.Id);
            if (existingOrder != null)
            {
                existingOrder.Name = order.Name;
                existingOrder.State = order.State;
                await _unitOfWork.OrderRepository.Update(existingOrder);
                await _unitOfWork.CommitAsync();
            }
        }

        public async Task Delete(int id)
        {
            var order = await _unitOfWork.OrderRepository.GetById(id);
            if (order != null)
            {
                order.IsDeleted = true;
                await _unitOfWork.OrderRepository.Update(order);
                await _unitOfWork.CommitAsync();
            }
        }
    }
}

