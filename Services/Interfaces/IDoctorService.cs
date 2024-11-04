using Carepulse_Backend.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Carepulse_Backend.Services.Interfaces
{
    public interface IDoctorService
    {
        Task<IEnumerable<Doctor>> GetDoctorsAsync();
        Task<Doctor> GetDoctorByIdAsync(Guid id);  // Changed to Guid
        Task<Doctor> CreateDoctorAsync(Doctor doctor);
        Task UpdateDoctorAsync(Doctor doctor);
        Task DeleteDoctorAsync(Guid id);  // Changed to Guid
    }
}