namespace Carepulse_Backend.Entities
{
    public class Appointment
    {
        public Guid Id { get; set; }                      // Changed from int to Guid
        public DateTime AppointmentDate { get; set; }
        public Guid PatientId { get; set; }               // Changed from int to Guid
        public Patient Patient { get; set; }              // Navigation property
        public Guid DoctorId { get; set; }                // Changed from int to Guid
        public Doctor Doctor { get; set; }                // Navigation property
        public AppointmentStatus Status { get; set; }
    }

    public enum AppointmentStatus
    {
        Scheduled,
        Pending,
        Cancelled
    }
}