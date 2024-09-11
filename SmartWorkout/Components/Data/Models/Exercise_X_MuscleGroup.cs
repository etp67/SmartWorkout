using System.ComponentModel.DataAnnotations;

namespace SmartWorkout.Components.Data.Models;

public class Exercise_X_MuscleGroup
{
    [Key]
    public int Id { get; set; }
    public Exercise Exercise { get; set; }
    public MuscleGroup MuscleGroup { get; set; }
}