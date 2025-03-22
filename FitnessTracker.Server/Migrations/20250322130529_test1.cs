using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FitnessTracker.Server.Migrations
{
    /// <inheritdoc />
    public partial class test1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "exercises",
                columns: table => new
                {
                    Exercise_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExerciseName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Set = table.Column<int>(type: "int", nullable: false),
                    Repetitions = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_exercises", x => x.Exercise_Id);
                });

            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "workoutPrograms",
                columns: table => new
                {
                    WorkoutProgram_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProgramName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_workoutPrograms", x => x.WorkoutProgram_Id);
                });

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
                    table.ForeignKey(
                        name: "FK_exerciseWorkoutPrograms_exercises_Exercise_Id",
                        column: x => x.Exercise_Id,
                        principalTable: "exercises",
                        principalColumn: "Exercise_Id");
                    table.ForeignKey(
                        name: "FK_exerciseWorkoutPrograms_workoutPrograms_WorkoutProgram_Id",
                        column: x => x.WorkoutProgram_Id,
                        principalTable: "workoutPrograms",
                        principalColumn: "WorkoutProgram_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "workoutDays",
                columns: table => new
                {
                    WorkoutDay_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WorkoutProgram_Id = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateOnly>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_workoutDays", x => x.WorkoutDay_Id);
                    table.ForeignKey(
                        name: "FK_workoutDays_workoutPrograms_WorkoutProgram_Id",
                        column: x => x.WorkoutProgram_Id,
                        principalTable: "workoutPrograms",
                        principalColumn: "WorkoutProgram_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_exerciseWorkoutPrograms_Exercise_Id",
                table: "exerciseWorkoutPrograms",
                column: "Exercise_Id");

            migrationBuilder.CreateIndex(
                name: "IX_exerciseWorkoutPrograms_WorkoutProgram_Id",
                table: "exerciseWorkoutPrograms",
                column: "WorkoutProgram_Id");

            migrationBuilder.CreateIndex(
                name: "IX_workoutDays_WorkoutProgram_Id",
                table: "workoutDays",
                column: "WorkoutProgram_Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "exerciseWorkoutPrograms");

            migrationBuilder.DropTable(
                name: "users");

            migrationBuilder.DropTable(
                name: "workoutDays");

            migrationBuilder.DropTable(
                name: "exercises");

            migrationBuilder.DropTable(
                name: "workoutPrograms");
        }
    }
}
