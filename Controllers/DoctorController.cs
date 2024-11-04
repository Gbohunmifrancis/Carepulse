using Carepulse_Backend.Entities;
using Carepulse_Backend.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Carepulse_Backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DoctorController : ControllerBase
    {
        private readonly IDoctorService _doctorService;

        public DoctorController(IDoctorService doctorService)
        {
            _doctorService = doctorService;
        }

        // Get all doctors
        [HttpGet]
        public async Task<IActionResult> GetDoctors()
        {
            var doctors = await _doctorService.GetDoctorsAsync();
            return Ok(doctors);
        }

        // Get a doctor by Guid
        [HttpGet("{id:guid}")]
        public async Task<IActionResult> GetDoctor(Guid id)
        {
            var doctor = await _doctorService.GetDoctorByIdAsync(id);
            if (doctor == null) return NotFound();
            return Ok(doctor);
        }

        // Create a new doctor
        [HttpPost]
        public async Task<IActionResult> CreateDoctor([FromBody] Doctor doctor)
        {
            var newDoctor = await _doctorService.CreateDoctorAsync(doctor);
            return CreatedAtAction(nameof(GetDoctor), new { id = newDoctor.Id }, newDoctor);
        }

        // Update a doctor by Guid
        [HttpPut("{id:guid}")]
        public async Task<IActionResult> UpdateDoctor(Guid id, [FromBody] Doctor doctor)
        {
            if (id != doctor.Id) return BadRequest();
            await _doctorService.UpdateDoctorAsync(doctor);
            return NoContent();
        }

        // Delete a doctor by Guid
        [HttpDelete("{id:guid}")]
        public async Task<IActionResult> DeleteDoctor(Guid id)
        {
            await _doctorService.DeleteDoctorAsync(id);
            return NoContent();
        }
    }
}