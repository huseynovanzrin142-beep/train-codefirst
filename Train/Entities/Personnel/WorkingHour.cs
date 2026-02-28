using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
namespace Train.Entities;

public class WorkingHour
{
    [Key]
    public int Id { get; set; }

    [Required]
    public DateTime StartTime { get; set; }
    [Required]
    public DateTime EndTime { get; set; }

    public virtual ICollection<DriverSchedule>? DriverSchedules { get; set; }
}
