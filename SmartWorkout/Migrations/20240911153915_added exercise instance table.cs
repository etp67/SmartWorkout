using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartWorkout.Migrations
{
    /// <inheritdoc />
    public partial class addedexerciseinstancetable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Exercise_Instance",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumSets = table.Column<int>(type: "int", nullable: false),
                    NumRepsPerSet = table.Column<int>(type: "int", nullable: false),
                    WeightLbs = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ExerciseId = table.Column<int>(type: "int", nullable: true),
                    WorkoutId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exercise_Instance", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Exercise_Instance_Exercise_ExerciseId",
                        column: x => x.ExerciseId,
                        principalTable: "Exercise",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Exercise_Instance_Workout_WorkoutId",
                        column: x => x.WorkoutId,
                        principalTable: "Workout",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Exercise_Instance_ExerciseId",
                table: "Exercise_Instance",
                column: "ExerciseId");

            migrationBuilder.CreateIndex(
                name: "IX_Exercise_Instance_WorkoutId",
                table: "Exercise_Instance",
                column: "WorkoutId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Exercise_Instance");
        }
    }
}
