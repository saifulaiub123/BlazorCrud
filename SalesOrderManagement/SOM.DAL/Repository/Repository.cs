﻿using Microsoft.EntityFrameworkCore;
using SOM.Core.DBModel;
using SOM.DAL.DBContext;
using System.Linq.Expressions;

namespace SOM.DAL.Repository
{
    public class Repository<TModel, TId> : IRepository<TModel, TId> where TModel : BaseEntity<TId>
    {
        protected DbSet<TModel> DbSet;
        protected readonly ApplicationDbContext _context;

        public Repository(ApplicationDbContext context)
        {
            _context = context;
            DbSet = _context.Set<TModel>();
        }

        public async Task<IEnumerable<TModel>> GetAll()
        {
            return await DbSet.AsNoTracking().ToListAsync();
        }

        public async Task<IReadOnlyList<TModel>> GetAll(params Expression<Func<TModel, object>>[] includes)
        {
            return await GetAllIncluding(includes).ToListAsync();
        }

        public async Task<IReadOnlyList<TModel>> GetAll(
            Expression<Func<TModel, bool>> filter,
            params Expression<Func<TModel, object>>[] includes)
        {
            return await GetAllIncluding(includes).Where(filter).ToListAsync();
        }

        private IQueryable<TModel> GetAllIncluding
            (params Expression<Func<TModel, object>>[] includeProperties)
        {
            IQueryable<TModel> queryable = DbSet.AsNoTracking();

            return includeProperties.Aggregate
                (queryable, (current, includeProperty) => current.Include(includeProperty));
        }

        public async Task<TModel> GetById(TId id)
        {
            return await DbSet.AsNoTracking().FirstOrDefaultAsync(t => t.Id.Equals(id));
        }

        public async Task<TModel> FindBy(Expression<Func<TModel, bool>> filter, params Expression<Func<TModel, object>>[] includes)
        {
            return await GetAllIncluding(includes)
                .FirstOrDefaultAsync(filter);
        }

        public async Task Insert(TModel entity)
        {
            await DbSet.AddAsync(entity);
        }

        public async Task InsertRange(IEnumerable<TModel> entity)
        {
            await DbSet.AddRangeAsync(entity);
        }
        public async Task<IEnumerable<TModel>> InsertRangeReturn(IEnumerable<TModel> entity)
        {
            await DbSet.AddRangeAsync(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task Update(TModel entity)
        {
            DbSet.Update(entity);
        }
        public async Task UpdateRange(IEnumerable<TModel> entity)
        {
            DbSet.UpdateRange(entity);
        }
        public async Task Delete(TId id)
        {
            var entity = await GetById(id);
            await Delete(entity);
        }

        public async Task Delete(TModel entity)
        {
            DbSet.Remove(entity);
        }

        public async Task DeleteRange(IEnumerable<TModel> entities)
        {
            DbSet.RemoveRange(entities);
        }

        public async Task<int> Count(Expression<Func<TModel, bool>> filter)
        {
            return await DbSet.Where(filter).CountAsync();
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
