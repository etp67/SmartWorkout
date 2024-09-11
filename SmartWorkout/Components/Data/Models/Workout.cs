using System.ComponentModel.DataAnnotations;

namespace SmartWorkout.Components.Data.Models;

public class Workout
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    public string? Description { get; set; }
    public DateTime DateCreated { get; set; } = DateTime.Now;
}