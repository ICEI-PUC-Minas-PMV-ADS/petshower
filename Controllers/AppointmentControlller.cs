using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PetShower.Application.Services.Interfaces;
using PetShower.Domain.Models;
using PetShower.Helpers;

namespace PetShower.Controllers;

public class AppointmentController : Controller
{
    private readonly IAppointmentService _appointmentService;

    public AppointmentController(IAppointmentService appointmentService)
    {
        _appointmentService = appointmentService;
    }

    public async Task<IActionResult> Index()
    {
        var appointments = await _appointmentService.GetAllAppointments();
        return View(appointments);
    }

    public async Task<IActionResult> Details(long id)
    {
        var appointment = await _appointmentService.GetAppointmentById(id);
        if (appointment == null)
        {
            return NotFound();
        }
        return View(appointment);
    }

    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("Id,PatientId,VeterinarianId,Service,Date,StatusId")] Appointment appointment)
    {
        if (ModelState.IsValid)
        {
            await _appointmentService.CreateAppointment(appointment);
            return RedirectToAction(nameof(Index));
        }
        return View(appointment);
    }

    public async Task<IActionResult> Edit(long id)
    {
        var appointment = await _appointmentService.GetAppointmentById(id);
        if (appointment == null)
        {
            return NotFound();
        }
        return View(appointment);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(long id, [Bind("Id,PatientId,VeterinarianId,Service,Date,StatusId")] Appointment appointment)
    {
        if (id != appointment.Id)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            await _appointmentService.UpdateAppointment(appointment);
            return RedirectToAction(nameof(Index));
        }
        return View(appointment);
    }

    public async Task<IActionResult> Delete(long id)
    {
        var appointment = await _appointmentService.GetAppointmentById(id);
        if (appointment == null)
        {
            return NotFound();
        }
        return View(appointment);
    }

    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(long id)
    {
        await _appointmentService.SoftDeleteAppointment(id);
        return RedirectToAction(nameof(Index));
    }

    [HttpGet("user/{userId}")]
    public async Task<IActionResult> GetAppointmentsByPetId(long petId)
    {
        var appointments = await _appointmentService.GetAppointmentsByPetIdAsync(petId);

        if (appointments == null)
        {
            return NotFound();
        }

        return Ok(appointments);
    }
}