using PetShower.Domain.Models;

namespace PetShower.Infrastructure.Repositories.Interfaces
{
    public interface IRepository<TEntity> where TEntity : EntityBase
    {
        Task<List<TEntity>> GetAllAsync();
        Task<TEntity?> GetByIdAsync(long id);
        Task<TEntity> CreateAsync(TEntity entity);
        Task<TEntity> UpdateAsync(TEntity entity);
        Task DeleteAsync(long id);
    }
}
