using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Train.Entities;

public class MedicalRecord
{
    [Key]
    public int Id { get; set; }

    public BloodType BloodType { get; set; } = BloodType.NotDefined;

    public double VisionTestResult { get; set; }

    public PsychologicalFitness PsychologicalFitness { get; set; } = PsychologicalFitness.NotDefined;
}
public enum BloodType
{
    NotDefined,
    A_Positive,
    A_Negative,
    B_Positive,
    B_Negative,
    AB_Positive,
    AB_Negative,
    O_Positive,
    O_Negative
}

public enum PsychologicalFitness
{     
    NotDefined,
    Poor,
    Good,
    Well
}