using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Train.Entities;

public class DriverSchedule
{
    [Key]
    public int Id { get; set; }
    [ForeignKey("WorkingHourId")]
    [Required]
    public int? WorkingHourId { get; set; }
    public virtual WorkingHour? WorkingHour { get; set; }
    [ForeignKey("WorkingDayId")]
    [Required]
    public int WorkingDayId { get; set; }
    public virtual WorkingDay? WorkingDay { get; set; }
    [ForeignKey("DriverId")]
    [Required]
    public int DriverId { get; set; }
    public virtual Driver? Driver { get; set; }
}
