using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartWorkout.DataAccess.Entities
{
	public class Exercise
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public ICollection<ExerciseLog> ExerciseLogs { get; set; }= new HashSet<ExerciseLog>();
	}
}
