using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema; 
namespace Train.Entities;

public class Trip
{
    [Key]
    public int Id { get; set; }
    [ForeignKey("TrainId")]
    public int TrainId { get; set; }
    public virtual Train? Train { get; set; }
    [ForeignKey("DriverId")]
    [Required]
    public int DriverId { get; set; }
    public virtual Driver? Driver { get; set; }
    [ForeignKey("TimeTableId")]

    public int TimeTableId { get; set; }
    [Required]
    public virtual TimeTable? TimeTable { get; set; }
    [ForeignKey("RouteId")]
    public int RouteId { get; set; }
    [Required]
    public virtual Route? Route { get; set; }
    public virtual ICollection<Ticket>? Tickets { get; set; }
}
