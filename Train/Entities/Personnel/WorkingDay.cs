using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Train.Entities;
   public class WorkingDay
    {
    [Key]
    public int Id { get; set; }
    [Required]
    public WeekDay Day { get; set; }

    public virtual ICollection<DriverSchedule>? DriverSchedules { get; set; }
}

public enum WeekDay
{
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday,
    Sunday
}