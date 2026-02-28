using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
namespace Train.Entities;

public class Passanger
{
    [Key]
    public int Id { get; set; }
    [Required]
    [MaxLength(50)]
    public string? Name { get; set; }
    [Required]
    [MaxLength(50)]
    public string? Surname { get; set; }

    [Required(ErrorMessage ="Please Enter your FIN") ]
    [MaxLength(50)]
    public string? FIN { get; set; }
}
