using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PetShower.Domain.Models;

namespace PetShower.Infrastructure.Mappings
{
    public class BreedMapping : IEntityTypeConfiguration<Breed>
    {
        public void Configure(EntityTypeBuilder<Breed> builder)
        {
            throw new NotImplementedException();
        }
    }
}
