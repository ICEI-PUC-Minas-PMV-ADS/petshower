using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Authen.Data.Domain;
using Authen.Data;
using Microsoft.EntityFrameworkCore;
namespace Authen.Application.Services
{
   public interface ITosadorBanhistaService
{
    Task CriarTosadorBanhistaAsync(TosadorBanhista tosadorBanhista);
    Task<List<TosadorBanhista>> ObterTodosTosadorBanhistaAsync();
}
public class TosadorBanhistaService : ITosadorBanhistaService
{
    private readonly ApplicationDbContext _context;

    public TosadorBanhistaService(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task CriarTosadorBanhistaAsync(TosadorBanhista tosadorBanhista)
    {
        _context.TosadorBanhista.Add(tosadorBanhista);
        await _context.SaveChangesAsync();
    }

     public async Task<List<TosadorBanhista>> ObterTodosTosadorBanhistaAsync()
{
  
    var tosadoresBanhistas = await _context.TosadorBanhista.ToListAsync();


    return tosadoresBanhistas;
}
}
}
