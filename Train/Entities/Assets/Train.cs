using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
namespace Train.Entities;

public class Train
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Required]
    [StringLength(100)]
    public string? ModelName { get; set; }

    public TrainStatus Status { get; set; } = TrainStatus.Scheduled;

    public int TrainSpecificationId { get; set; }
    [Required]
    [ForeignKey("TrainSpecificationId")]
    public TrainSpecification? TrainSpecification { get; set; }


    public int CompanyId { get; set; }
    [Required]
    [ForeignKey("CompanyId")]
    public Company? Company { get; set; }

    public virtual ICollection<Wagon>? Wagons { get; set; } = new HashSet<Wagon>();

    public virtual ICollection<Trip>? Trips { get; set; } = new HashSet<Trip>();

    public virtual ICollection<Driver>? Drivers { get; set; } = new HashSet<Driver>();
}
public enum TrainStatus
{
    Scheduled,
    OnTime,
    Delayed,
    Departed,
    Arrived,
    Cancelled,
    Maintenance
}
