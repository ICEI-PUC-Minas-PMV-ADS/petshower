using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Authen.Data.Domain;
using Authen.Data;
using Microsoft.EntityFrameworkCore;
namespace Authen.Application.Services
{
   public interface IAgendamentoService
{
    Task CriarAgendamentoAsync(Agendamento Agendamento);
    Task<List<Agendamento>> ObterTodosAgendamentoAsync();
}
public class AgendamentoService : IAgendamentoService
{
    private readonly ApplicationDbContext _context;

    public AgendamentoService(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task CriarAgendamentoAsync(Agendamento Agendamento)
    {
        _context.Agendamento.Add(Agendamento);
        await _context.SaveChangesAsync();
    }

public async Task<List<Agendamento>> ObterTodosAgendamentoAsync()
{
    var agendamentosComPets = await _context.Agendamento
        .Include(a => a.Pet).Include(a=>a.TosadorBanhista)
        .ToListAsync();

    return agendamentosComPets;
}
}
}
