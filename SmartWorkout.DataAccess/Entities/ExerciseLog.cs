using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartWorkout.DataAccess.Entities
{
	public class ExerciseLog
	{
		public int WorkoutId { get; set; }
		public int ExerciseId { get; set; }
		public double Weight { get; set; }
		public int Sets { get; set; }
		public int Reps { get; set; }
		public double Duration { get; set; }
		public double Distance { get; set; }
		public Exercise Exercise { get; set; } = null!;
		public Workout Workout { get; set; } = null!;
	}
}
