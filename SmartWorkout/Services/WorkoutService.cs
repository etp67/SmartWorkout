using Microsoft.EntityFrameworkCore;
using SmartWorkout.Components.Data;
using SmartWorkout.Components.Data.Models;

namespace SmartWorkout.Services;

public class WorkoutService
{
    private IDbContextFactory<DataContext> _dbContextFactory;
    
    public WorkoutService(IDbContextFactory<DataContext> dbContextFactory)
    {
        _dbContextFactory = dbContextFactory;
    }

    public void AddWorkout(Workout workout)
    {
        using var context = _dbContextFactory.CreateDbContext();
        context.Workout.Add(workout);
        context.SaveChanges();
    }
}
