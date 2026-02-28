using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
namespace Train.Entities;

public class Company
{
    [Key]
    public int Id { get; set; }
    public int FoundationYear { get; set; }
    [Required]
    [MaxLength(100)]
    public string? Name{ get; set; }

    [Required]
    [MaxLength(30)]
    public string? Email{ get; set; }

    [Required]
    [MaxLength(30)]
    public string? Phone{ get; set; }

    [Required]
    [MaxLength(100)]
    public string? WebsiteUrl { get; set; }

    [StringLength(10, MinimumLength = 10)]
    [Required]
    public string? VOEN { get; set; }

    public virtual ICollection<Ticket>? Tickets { get; set; }

    public virtual ICollection<Driver>? Drivers { get; set; }

    public virtual ICollection<Train>? Trains { get; set; }
}
