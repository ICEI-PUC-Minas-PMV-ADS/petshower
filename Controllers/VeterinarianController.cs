using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PetShower.Application.Services.Interfaces;
using PetShower.Domain.Models;
using PetShower.Helpers;

namespace PetShower.Controllers;

public class VeterinarianController : Controller
{
    private readonly IVeterinarianService _veterinarianService;

    public VeterinarianController(IVeterinarianService veterinarianService)
    {
        _veterinarianService = veterinarianService;
    }

    public async Task<IActionResult> Index()
    {
        var veterinarians = await _veterinarianService.GetAllVeterinarians();
        return View(veterinarians);
    }

    public async Task<IActionResult> Details(long id)
    {
        var veterinarian = await _veterinarianService.GetVeterinarianById(id);
        if (veterinarian == null)
        {
            return NotFound();
        }
        return View(veterinarian);
    }

    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("Id,Name,GenderId,Age")] Veterinarian veterinarian)
    {
        if (ModelState.IsValid)
        {
            await _veterinarianService.CreateVeterinarian(veterinarian);
            return RedirectToAction(nameof(Index));
        }
        return View(veterinarian);
    }

    public async Task<IActionResult> Edit(long id)
    {
        var veterinarian = await _veterinarianService.GetVeterinarianById(id);
        if (veterinarian == null)
        {
            return NotFound();
        }
        return View(veterinarian);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(long id, [Bind("Id,Name,GenderId,Age")] Veterinarian veterinarian)
    {
        if (id != veterinarian.Id)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            await _veterinarianService.UpdateVeterinarian(veterinarian);
            return RedirectToAction(nameof(Index));
        }
        return View(veterinarian);
    }

    public async Task<IActionResult> Delete(long id)
    {
        var veterinarian = await _veterinarianService.GetVeterinarianById(id);
        if (veterinarian == null)
        {
            return NotFound();
        }
        return View(veterinarian);
    }

    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(long id)
    {
        await _veterinarianService.SoftDeleteVeterinarian(id);
        return RedirectToAction(nameof(Index));
    }
}
