using System.ComponentModel.DataAnnotations;

namespace SmartWorkout.Components.Data.Models;

public class Exercise_Category
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    public string? Description { get; set; }
}