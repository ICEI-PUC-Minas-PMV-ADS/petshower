using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PetShower.Domain.Models;

namespace PetShower.Infrastructure.Mappings
{
    public class SpecieMapping : IEntityTypeConfiguration<Specie>
    {
        public void Configure(EntityTypeBuilder<Specie> builder)
        {
            throw new NotImplementedException();
        }
    }
}
