using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace SmartWorkout.DataAccess.Entities
{
	public class Workout
	{
		public int Id { get; set; }

		public int ClientId{ get; set; }

		public int? Duration{ get; set; }

		public DateTime Date { get; set; }

		public Client Client { get; set; } = null!;
		public ICollection<ExerciseLog> ExerciseLogs { get; set; } = new HashSet<ExerciseLog>();
	}
}
