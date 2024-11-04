using Carepulse_Backend.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Carepulse_Backend.Services.Interfaces
{
    public interface IPatientService
    {
        Task<IEnumerable<Patient>> GetPatientsAsync();        // Fetch all patients
        Task<Patient> GetPatientByIdAsync(Guid id);           // Fetch a patient by ID
        Task<Patient> CreatePatientAsync(Patient patient);    // Create a new patient
        Task UpdatePatientAsync(Patient patient);             // Update an existing patient
        Task DeletePatientAsync(Guid id);                     // Delete a patient by ID
    }
}