using Microsoft.EntityFrameworkCore;
using PetShower.Domain.Models;
using PetShower.Infrastructure.Repositories.Interfaces;

namespace PetShower.Infrastructure.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : EntityBase
    {
        private readonly DbContext _context;

        public Repository(DbContext context)
        {
            _context = context;
        }

        public async Task<List<TEntity>> GetAllAsync()
        {
            return await _context.Set<TEntity>().ToListAsync();
        }

        public async Task<TEntity?> GetByIdAsync(long id)
        {
            return await _context.Set<TEntity>().FindAsync(id);
        }

        public async Task<TEntity> CreateAsync(TEntity entity)
        {
            _context.Set<TEntity>().Add(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<TEntity> UpdateAsync(TEntity entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task DeleteAsync(long id)
        {
            var entity = await GetByIdAsync(id);
            if (entity != null)
            {
                entity.IsDeleted = true;
                await _context.SaveChangesAsync();
            }
        }
    }

}
