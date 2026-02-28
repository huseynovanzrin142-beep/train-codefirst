using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Train.Entities;

public class Wagon
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    public int SeatCount { get; set; } = 50;
    
    public int? WagonNo { get; set; }
    [ForeignKey("TrainId")]
    public int TrainId { get; set; }
    [Required]
    public virtual Train? Train { get; set; }
     public virtual ICollection<Seat>? Seats { get; set; }
}
