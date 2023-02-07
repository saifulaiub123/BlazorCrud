

using SOM.Core.DBModel;

namespace SOM.DAL.UOF
{
    public interface IUnitOfWork
    {
        IRepository<Element, int> ElementRepository { get; }
        void Commit();
        void Rollback();
        Task CommitAsync();
        Task RollbackAsync();
    }
}
