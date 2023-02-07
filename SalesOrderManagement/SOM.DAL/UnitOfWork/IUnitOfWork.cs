

using SOM.Core.DBModel;

namespace SOM.DAL.UOF
{
    public interface IUnitOfWork
    {
        IRepository<Element, int> ElementRepository { get; }
        IRepository<Window, int> WindowRepository { get; }
        IRepository<WindowElement, int> WindowElementRepository { get; }
        void Commit();
        void Rollback();
        Task CommitAsync();
        Task RollbackAsync();
    }
}
