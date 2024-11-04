using Carepulse_Backend.Entities;

namespace Carepulse_Backend.Services.Interfaces
{
    public interface IAppointmentService
    {
        Task<IEnumerable<Appointment>> GetAppointmentsAsync();                  // Fetch all appointments
        Task<Appointment> GetAppointmentByIdAsync(Guid id);                   // Fetch an appointment by ID (changed from int to Guid)
        Task<Appointment> CreateAppointmentAsync(Appointment appointment);     // Create a new appointment
        Task UpdateAppointmentAsync(Appointment appointment);                  // Update an existing appointment
        Task DeleteAppointmentAsync(Guid id);                                  // Delete an appointment by ID (changed from int to Guid)
    }
}