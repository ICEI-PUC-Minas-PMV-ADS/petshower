using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PetShower.Domain.Models;

namespace PetShower.Infrastructure.Mappings
{
    public class PetMapping : IEntityTypeConfiguration<Pet>
    {
        public void Configure(EntityTypeBuilder<Pet> builder)
        {
            builder.ToTable("Pets");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name)
                .IsRequired();

            builder.Property(x => x.Specie)
                .IsRequired();

            builder.Property(x => x.Breed);

            builder.Property(x => x.Owner)
                .IsRequired();

            builder.Property(x => x.Gender);

            builder.Property(x => x.CreatedAt)
                .IsRequired();

            builder.Property(x => x.UpdatedAt)
                .IsRequired();

            builder.Property(x => x.IsDeleted)
                .IsRequired()
                .HasDefaultValue(false);
        }
    }
}
