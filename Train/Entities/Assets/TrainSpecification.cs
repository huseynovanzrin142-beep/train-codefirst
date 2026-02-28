using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
namespace Train.Entities;

public class TrainSpecification
{
    [Key]
    public int Id { get; set; }
    public int MaxSpeed { get; set; }

    [Required(ErrorMessage = "Please select a fuel type")]
    public FuelType? FuelType { get; set; }

    [Required(ErrorMessage = "Please select a carriage type")]
    public CarriageType? CarriageType{ get; set; }
}
public enum FuelType
{
    Diesel ,
    Electric ,   
    Hybrid , 
    Hydrogen   

}

public enum CarriageType
{
    Sleeper,
    Seater,
    Dining,
    Luggage
}