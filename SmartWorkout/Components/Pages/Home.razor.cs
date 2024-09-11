using Microsoft.AspNetCore.Components.Forms;
using SmartWorkout.Components.Data.Models;

namespace SmartWorkout.Components.Pages;

public partial class Home
{
    Workout workout { get; set; } = new Workout();

    public void HandleSubmit(EditContext editContext)
    {
        var newWorkout = (Workout)editContext.Model;
        newWorkout.DateCreated = DateTime.Now;
        workoutService.AddWorkout(newWorkout);
    }
}
