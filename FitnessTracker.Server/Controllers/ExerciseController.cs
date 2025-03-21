﻿using FitnessTracker.Server.Database;
using FitnessTracker.Server.DTO;
using FitnessTracker.Server.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Reflection;

namespace FitnessTracker.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ExerciseController : ControllerBase
    {
        private readonly FitnessTrackerDBContext _context;

        public ExerciseController(FitnessTrackerDBContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("getExercises")]
        public IActionResult GetExercises()
        {
            var exercises = _context.exercises.ToList(); //henter alle rækker fra Exercises-tabellen og returnerer dem som en liste.
            return Ok(exercises);
        }

        [HttpGet]
        [Route("getExercise/{id}")]
        public IActionResult GetExercise(int id) 
        {
            var UniqueExercise = _context.exercises.FirstOrDefault(e => e.Exercise_Id == id);
            if(UniqueExercise == null)
            {
                return NotFound();
            }
            return Ok(UniqueExercise);
        }



        [HttpPost]
        [Route("addExercise")]
        public IActionResult AddExercise([FromBody] ExerciseDTO exerciseDTO)
        {
            if(exerciseDTO == null)
            {
                return BadRequest();
            }

            var exercise = new Exercise
            {
                ExerciseName = exerciseDTO.ExerciseName,
                Set = exerciseDTO.Set,
                Repetitions = exerciseDTO.Repetitions
            };

            _context.exercises.Add(exercise);
            _context.SaveChanges();

            return CreatedAtAction(nameof(GetExercise), new { id = exercise.Exercise_Id }, exercise);

            /*nameof(GetExercise): Fortæller, at vi peger på GetExercise-metoden i controlleren.
            new { id = exercise.Exercise_Id }: Angiver route-parametrene(hvilket id den nye ressource har).
            exercise: Sender den oprettede ressource(det nye objekt) tilbage til klienten.*/
        }

        [HttpPut]
        [Route("updateExercise")]
        public IActionResult UpdateExercise([FromBody] Exercise exercise)
        {
            if (exercise == null)
            {
                return BadRequest();
            }

            var existExercise = _context.exercises.FirstOrDefault(e => e.Exercise_Id == exercise.Exercise_Id);
            if (existExercise == null)
            {
                return NotFound();
            }

            existExercise.ExerciseName = exercise.ExerciseName;
            existExercise.Set = exercise.Set;
            existExercise.Repetitions = exercise.Repetitions;

            _context.exercises.Update(existExercise);
            _context.SaveChanges();

            return Ok(existExercise);
        }


        [HttpDelete]
        [Route("deleteExercise")]
        public IActionResult DeleteExercise(int id)
        {

            var exercise = _context.exercises.FirstOrDefault(e => e.Exercise_Id == id);

            if(exercise == null)
            {
                return NotFound();
            }

            _context.exercises.Remove(exercise);
            _context.SaveChanges();

            return NoContent(); //Returnerer NoContent() (HTTP 204), operationen var en succes, men intet data sendes tilbage.
        }


        
    }
}
