using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Train.Entities;

[Index(nameof(SerialNo), IsUnique = true)]
[Index(nameof(Fin), IsUnique = true)]
public class Driver
{
    [Key]
    public int Id { get; set; }
    [Required]
    [MaxLength(100)]
    public string? Name { get; set; }

    [Required]
    [MaxLength(100)]
    public string? Surname { get; set; }

    [Required]
    [MaxLength(100)]
    public string? DadName { get; set; }

    [Required]
    [MaxLength(100)]
    public string? SerialNo { get; set; }

    [Required]
    [MaxLength(100)]
    public string? Fin { get; set; }

    [MaxLength(200)]
    public string? ProfilePicUrl { get; set; }

    public int Age { get; set; }
    public int MedicalCertificateId { get; set; }
    [ForeignKey("MedicalCertificateId")]
    [Required]
    public virtual MedicalCertificate? MedicalCertificate { get; set; }

    public int CompanyId { get; set; }
    [ForeignKey("CompanyId")]
    [Required]
    public virtual Company? Company { get; set; }

    public virtual ICollection<Trip>? Trips { get; set; }

    public virtual ICollection<DriverSchedule>? DriverSchedules { get; set; }

}
