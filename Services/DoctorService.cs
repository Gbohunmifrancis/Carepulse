using Carepulse_Backend.Entities;
using Carepulse_Backend.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Carepulse_Backend.Services
{
    public class DoctorService : IDoctorService
    {
        private readonly AppDbContext _context;

        public DoctorService(AppDbContext context)
        {
            _context = context;
        }

        // Get all doctors
        public async Task<IEnumerable<Doctor>> GetDoctorsAsync()
        {
            return await _context.Doctors.ToListAsync();
        }

        // Get a doctor by Guid
        public async Task<Doctor> GetDoctorByIdAsync(Guid id)
        {
            return await _context.Doctors.FindAsync(id);
        }

        // Create a new doctor
        public async Task<Doctor> CreateDoctorAsync(Doctor doctor)
        {
            doctor.Id = Guid.NewGuid();  // Ensure a new GUID is generated for the doctor
            _context.Doctors.Add(doctor);
            await _context.SaveChangesAsync();
            return doctor;
        }

        // Update a doctor
        public async Task UpdateDoctorAsync(Doctor doctor)
        {
            _context.Entry(doctor).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        // Delete a doctor by Guid
        public async Task DeleteDoctorAsync(Guid id)
        {
            var doctor = await _context.Doctors.FindAsync(id);
            if (doctor != null)
            {
                _context.Doctors.Remove(doctor);
                await _context.SaveChangesAsync();
            }
        }
    }
}