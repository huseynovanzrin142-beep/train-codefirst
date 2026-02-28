using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Train.Entities;

public class Contact
{
    [Key]
    public int Id { get; set; }
    [Required]
    [MaxLength(50)]
    public string? Phone { get; set; }
    [Required]
    [MaxLength(50)]
    public string? Email { get; set; }

    [ForeignKey("DriverId")]
    [Required]
    public int DriverId { get; set; }
    public virtual Driver? Driver { get; set; }
}
