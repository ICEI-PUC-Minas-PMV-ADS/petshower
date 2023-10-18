using PetShower.Data;
using PetShower.Domain.Models;
using PetShower.Infrastructure.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace PetShower.Infrastructure.Repositories
{
    public class PetRepository : IPetRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public PetRepository(ApplicationDbContext applicationDbContext)
        {
            _dbContext = applicationDbContext;
        }

        public async Task<Pet> GetByIdAsync(long id)
        {
            return await _dbContext.Pets
                .Include(x => x.Owner)
                .FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<List<Pet>> GetAllAsync()
        {
            return await _dbContext.Pets
                .Include(x => x.Owner)
                .ToListAsync();
        }

        public async Task<Pet> CreateAsync(Pet pet)
        {
            await _dbContext.Pets.AddAsync(pet);
            await _dbContext.SaveChangesAsync();

            return pet;
        }

        public async Task<Pet> UpdateAsync(Pet pet)
        {
            Pet petById = await GetByIdAsync(pet.Id);
            petById.Name = pet.Name;
            petById.Specie = pet.Specie;
            petById.Breed = pet.Breed;
            petById.Owner = pet.Owner;
            petById.Gender = pet.Gender;
            petById.UpdatedAt = DateTime.Now;

            _dbContext.Pets.Update(petById);
            await _dbContext.SaveChangesAsync();
            return petById;
        }

        public async Task DeleteAsync(long id)
        {
            Pet petById = await GetByIdAsync(id);
            petById.IsDeleted = true;
            petById.UpdatedAt = DateTime.Now;

            await UpdateAsync(petById);
        }
    }
}
