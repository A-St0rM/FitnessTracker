using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FitnessTracker.Server.Migrations
{
    /// <inheritdoc />
    public partial class newJunctionTabel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "exerciseWorkoutPrograms",
                columns: table => new
                {
                    ExerciseWorkoutProgram_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Exercise_Id = table.Column<int>(type: "int", nullable: false),
                    WorkoutProgram_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_exerciseWorkoutPrograms", x => x.ExerciseWorkoutProgram_Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "exerciseWorkoutPrograms");
        }
    }
}
