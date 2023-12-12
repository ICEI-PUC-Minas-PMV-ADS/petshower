using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Authen.Data.Domain;
using Authen.Data;
using Microsoft.EntityFrameworkCore;
namespace Authen.Application.Services
{
   public interface IPetService
{
    Task CriarPetAsync(Pet Pet);
    Task<List<Pet>> ObterTodosPetAsync();
}
public class PetService : IPetService
{
    private readonly ApplicationDbContext _context;

    public PetService(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task CriarPetAsync(Pet Pet)
    {
        _context.Pet.Add(Pet);
        await _context.SaveChangesAsync();
    }

public async Task<List<Pet>> ObterTodosPetAsync()
{
   
    var tosadoresBanhistas = await _context.Pet.ToListAsync();

    return tosadoresBanhistas;
}
}
}
