using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
namespace Train.Entities;

public class Ticket
{
    [Key]
    public int Id { get; set; }
    [Required]
    public double Price { get; set; }

    [Required]
    public TicketStatus TripStatus { get; set; } = TicketStatus.Available;

    public Guid TicketNo { get; set; } = Guid.NewGuid();

    [ForeignKey("CompanyId")]
    public int CompanyId { get; set; }
    public virtual Company? Company { get; set; }
    [ForeignKey("PassangerId")]
    public int PassangerId { get; set; }
    [Required]
    public virtual Passanger? Passanger { get; set; }

    [ForeignKey("TripId")]
    public int TripId { get; set; }
    public virtual Trip? Trip { get; set; }

    [ForeignKey("SeatId")]
    public int SeatId { get; set; }
    public virtual Seat? Seat { get; set; }

}

public enum TicketStatus
{
    Available,
    Sold
}

