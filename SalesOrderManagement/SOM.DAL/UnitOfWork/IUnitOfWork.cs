

using SOM.Core.DBModel;
using SOM.DAL.DBContext;

namespace SOM.DAL.UOF
{
    public interface IUnitOfWork
    {
        public ApplicationDbContext DbContext { get; }
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
