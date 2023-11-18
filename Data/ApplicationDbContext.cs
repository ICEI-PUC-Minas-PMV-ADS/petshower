using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PetShower.Domain.Models;
using PetShower.Infrastructure.Mappings;
using System.Reflection.Emit;

namespace PetShower.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<Pet> Pets { get; set; }
    public DbSet<Appointment> Appointments { get; set; }
    public DbSet<Breed> Breeds { get; set; }
    public DbSet<Status> Statuss { get; set; }
    public DbSet<Gender> Genders { get; set; }
    public DbSet<Specie> Species { get; set; }
    public DbSet<Veterinarian> Veterinarians { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.ApplyConfiguration(new PetMapping());
        builder.ApplyConfiguration(new AppointmentMapping());
        builder.ApplyConfiguration(new BreedMapping());
        builder.ApplyConfiguration(new StatusMapping());
        builder.ApplyConfiguration(new GenderMapping());
        builder.ApplyConfiguration(new SpecieMapping());
        builder.ApplyConfiguration(new VeterinarianMapping());

        base.OnModelCreating(builder);
        Seed(builder);
    }

    private static void Seed(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Gender>().HasData(
            new Gender { Id = 1, Name = "Masculino", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now, IsDeleted = false },
            new Gender { Id = 2, Name = "Feminino", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now, IsDeleted = false },
            new Gender { Id = 3, Name = "Outro", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now, IsDeleted = false }
        );

        modelBuilder.Entity<Breed>().HasData(
        new Breed { Id = 1, Name = "Labrador Retriever", Description = "Amigável e extrovertido", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now, IsDeleted = false },
        new Breed { Id = 2, Name = "Pastor Alemão", Description = "Leal e protetor", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now, IsDeleted = false },
        new Breed { Id = 3, Name = "Golden Retriever", Description = "Inteligente e devoto", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now, IsDeleted = false },
        new Breed { Id = 4, Name = "Bulldog Francês", Description = "Adorável e sociável", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now, IsDeleted = false },
        new Breed { Id = 5, Name = "Poodle", Description = "Inteligente e ativo", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now, IsDeleted = false }
         );

        modelBuilder.Entity<Specie>().HasData(
            new Specie { Id = 1, Name = "Cachorro", Description = "Mamífero doméstico conhecido pela lealdade", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now, IsDeleted = false },
            new Specie { Id = 2, Name = "Gato", Description = "Animal de estimação doméstico conhecido pela independência", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now, IsDeleted = false },
            new Specie { Id = 3, Name = "Coelho", Description = "Pequeno mamífero herbívoro", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now, IsDeleted = false },
            new Specie { Id = 4, Name = "Pássaro", Description = "Ave de estimação com variadas espécies", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now, IsDeleted = false }
        );
    }
}
