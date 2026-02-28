using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Train.Entities;

public class MedicalCertificate
{
    [Key]
    public int Id { get; set; }
    public DateTime IssueDate { get; set; }
    public DateTime ExpiryDate { get; set; }
  
    public int MedicalRecordId { get; set; }

    [Required]
    [ForeignKey("MedicalRecordId")]
    public virtual MedicalRecord? MedicalRecord { get; set; }

}
