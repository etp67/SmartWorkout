namespace SmartWorkout.Components.Data;
using Microsoft.EntityFrameworkCore;
using SmartWorkout.Components.Data.Models;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {

    }

    public DbSet<Workout> Workout { get; set; }
    public DbSet<MuscleGroup> MuscleGroup { get; set; }
    public DbSet<Exercise> Exercise { get; set; }
    public DbSet<Exercise_Category> Exercise_Category { get; set; }
    public DbSet<Exercise_Instance> Exercise_Instance { get; set; }
    public DbSet<Exercise_X_MuscleGroup> Exercise_X_MuscleGroup { get; set; }
}
