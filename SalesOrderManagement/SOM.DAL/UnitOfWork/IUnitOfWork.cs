

using SOM.Core.DBModel;

namespace SOM.DAL.UOF
{
    public interface IUnitOfWork
    {
        IRepository<Element, int> ElementRepository { get; }
        IRepository<ElementType, int> ElementTypeRepository { get; }
        IRepository<Window, int> WindowRepository { get; }
        IRepository<WindowElement, int> WindowElementRepository { get; }
        IRepository<Order, int> OrderRepository { get; }
        IRepository<OrderWindow, int> OrderWindowRepository { get; }
        void Commit();
        void Rollback();
        Task CommitAsync();
        Task RollbackAsync();
    }
}
