using System.ComponentModel.DataAnnotations;

namespace SmartWorkout.Components.Data.Models;

public class Exercise
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    public string? SetRepRange { get; set; }
    public Exercise_Category? Category { get; set; }
}