using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
namespace Train.Entities;

public class Seat
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    public int CurrentPassangerId { get; set; }
    [ForeignKey("CurrentPassengerId")]
    public virtual Passanger? Passanger { get; set; }


    public int WagonId { get; set; }
    [ForeignKey("WagonId")]
    [Required]
    public virtual Wagon? Wagon { get; set; }

    [Required]

    public int SeatNo { get; set; }
   
}
