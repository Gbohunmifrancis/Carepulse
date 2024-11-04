using Carepulse_Backend.Entities;
using Carepulse_Backend.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Carepulse_Backend.Services
{
    public class PatientService : IPatientService
    {
        private readonly AppDbContext _context;

        public PatientService(AppDbContext context)
        {
            _context = context;
        }

        // Get all patients
        public async Task<IEnumerable<Patient>> GetPatientsAsync()
        {
            return await _context.Patients.ToListAsync();
        }

        // Get patient by ID
        public async Task<Patient> GetPatientByIdAsync(Guid id)  // Changed int to Guid
        {
            return await _context.Patients.FindAsync(id);
        }

        // Create a new patient
        public async Task<Patient> CreatePatientAsync(Patient patient)
        {
            patient.Id = Guid.NewGuid();  // Ensure new Guid is generated for the patient
            _context.Patients.Add(patient);
            await _context.SaveChangesAsync();
            return patient;
        }

        // Update an existing patient
        public async Task UpdatePatientAsync(Patient patient)
        {
            _context.Entry(patient).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        // Delete a patient by ID
        public async Task DeletePatientAsync(Guid id)  // Changed int to Guid
        {
            var patient = await _context.Patients.FindAsync(id);
            if (patient != null)
            {
                _context.Patients.Remove(patient);
                await _context.SaveChangesAsync();
            }
        }
    }
}