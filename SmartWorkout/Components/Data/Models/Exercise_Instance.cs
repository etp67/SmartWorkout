using System.ComponentModel.DataAnnotations;

namespace SmartWorkout.Components.Data.Models;

public class Exercise_Instance
{
    [Key]
    public int Id { get; set; }
    public int NumSets { get; set; }
    public int NumRepsPerSet { get; set; }
    public decimal WeightLbs { get; set; }
    public Exercise? Exercise { get; set; }
    public Workout? Workout { get; set; }
}