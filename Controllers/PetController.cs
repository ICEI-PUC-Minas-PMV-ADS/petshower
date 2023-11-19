using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PetShower.Application.Services.Interfaces;
using PetShower.Domain.Models;
using PetShower.Helpers;

namespace PetShower.Controllers;

public class PetController : Controller
{
    private readonly IPetService _petService;

    public PetController(IPetService petService)
    {
        _petService = petService;
    }

    public async Task<IActionResult> Index()
    {
        var pets = await _petService.GetAllPets();
        return View(pets);
    }

    public async Task<IActionResult> Details(long id)
    {
        var pet = await _petService.GetPetById(id);
        if (pet == null)
        {
            return NotFound();
        }
        return View(pet);
    }

    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("Id,Name,SpecieId,BreedId,OwnerId,GenderId")] Pet pet)
    {
        if (ModelState.IsValid)
        {
            await _petService.CreatePet(pet);
            return RedirectToAction(nameof(Index));
        }
        return View(pet);
    }

    public async Task<IActionResult> Edit(long id)
    {
        var pet = await _petService.GetPetById(id);
        if (pet == null)
        {
            return NotFound();
        }
        return View(pet);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(long id, [Bind("Id,Name,SpecieId,BreedId,OwnerId,GenderId")] Pet pet)
    {
        if (id != pet.Id)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            await _petService.UpdatePet(pet);
            return RedirectToAction(nameof(Index));
        }
        return View(pet);
    }

    public async Task<IActionResult> Delete(long id)
    {
        var pet = await _petService.GetPetById(id);
        if (pet == null)
        {
            return NotFound();
        }
        return View(pet);
    }

    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(long id)
    {
        await _petService.SoftDeletePet(id);
        return RedirectToAction(nameof(Index));
    }

    [HttpGet("user/{userId}")]
    public async Task<IActionResult> GetPetsByUserId(string userId)
    {
        var pets = await _petService.GetPetsByUserIdAsync(userId);

        if (pets == null)
        {
            return NotFound();
        }

        return Ok(pets);
    }
}
