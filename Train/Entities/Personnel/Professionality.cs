using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Train.Entities;

[Index(nameof(LicenseNo), IsUnique = true)]
public class Professionality
{
    [Key]
    public int Id { get; set; }
    public ProfessionalLevel? ProfessionalLevel { get; set; } = Entities.ProfessionalLevel.Junior;
    public int WorkExperience { get; set; }
    [Required]
    [MaxLength(8)]
    public string? LicenseNo { get; set; }

    [ForeignKey("DriverId")]
    [Required]
    public int DriverId { get; set; }
    public virtual Driver? Driver { get; set; }
}
public enum ProfessionalLevel
{
    Junior,
    Middle,
    Senior,
}