using System.ComponentModel.DataAnnotations;

namespace Carepulse_Backend.Entities;

public class Doctor
{
    [Key]
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string ImageUrl { get; set; }
}
