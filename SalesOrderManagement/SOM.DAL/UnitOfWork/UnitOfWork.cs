using SOM.Core.DBModel;
using SOM.DAL.DBContext;
using SOM.DAL.Repository;

namespace SOM.DAL.UOF
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _dbContext;

        public IRepository<Element, int> _elementRepository;
        public UnitOfWork(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IRepository<Element, int> ElementRepository
        {
            get { return _elementRepository = _elementRepository ?? new Repository<Element, int>(_dbContext); }
        }

        public void Commit()
            => _dbContext.SaveChanges();


        public async Task CommitAsync()
            => await _dbContext.SaveChangesAsync();


        public void Rollback()
            => _dbContext.Dispose();


        public async Task RollbackAsync()
            => await _dbContext.DisposeAsync();
    }
}
