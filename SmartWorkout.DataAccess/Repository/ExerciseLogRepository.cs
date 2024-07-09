using SmartWorkout.DataAccess.Entities;
using SmartWorkout.DataAccess.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartWorkout.DataAccess.Repository
{
	public class ExerciseLogRepository : IGenericRepository<ExerciseLog>
	{
		private readonly SmartWorkoutContext _context;

		public ExerciseLogRepository(SmartWorkoutContext context)
		{
			_context = context;
		}

		public void Add(ExerciseLog exerciseLog)
		{
			_context.Add(exerciseLog);
			_context.SaveChanges();
		}

		public IEnumerable<ExerciseLog> GetAll()
		{
			return _context.ExerciseLogs.ToList();
		}

		public ExerciseLog? GetById(int Id)
		{
			return _context.ExerciseLogs.Find(Id);
		}

		public bool Remove(int Id)
		{
			var exerciseLog = _context.ExerciseLogs.Find(Id);
			if (exerciseLog != null)
			{
				_context.ExerciseLogs.Remove(exerciseLog);
				_context.SaveChanges();
				return true;
			}
			return false;
		}


		public void Update(ExerciseLog exerciseLog)
		{
			_context.Update(exerciseLog);
			_context.SaveChanges();
		}
	}
}
