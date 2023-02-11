using SOM.Core.DBModel;
using System.Linq.Expressions;

namespace SOM.DAL
{
    public interface IRepository<TModel, TId> where TModel : BaseEntity<TId>
    {
        Task<IEnumerable<TModel>> GetAll();
        Task<IReadOnlyList<TModel>> GetAll(params Expression<Func<TModel, object>>[] includes);

        Task<IReadOnlyList<TModel>> GetAll(
            Expression<Func<TModel, bool>> filter,
            params Expression<Func<TModel, object>>[] includes);
        Task<TModel> GetById(TId id);
        Task<TModel> FindBy(Expression<Func<TModel, bool>> filter, params Expression<Func<TModel, object>>[] includes);
        Task Insert(TModel entity);
        Task InsertRange(IEnumerable<TModel> entity);
        Task Update(TModel entity);
        Task UpdateRange(IEnumerable<TModel> entity);
        Task Delete(TId id);
        Task Delete(TModel id);
        Task DeleteRange(IEnumerable<TModel> entities);
        Task<int> Count(Expression<Func<TModel, bool>> filter);
        Task SaveAsync();
    }
}
