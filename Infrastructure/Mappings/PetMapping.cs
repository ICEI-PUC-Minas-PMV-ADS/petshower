using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PetShower.Domain.Models;

namespace PetShower.Infrastructure.Mappings
{
    public class PetMapping : IEntityTypeConfiguration<Pet>
    {
        public void Configure(EntityTypeBuilder<Pet> builder)
        {
            throw new NotImplementedException();
        }
    }
}
