using Microsoft.EntityFrameworkCore;
using SmartWorkout.DataAccess.Entities;
using SmartWorkout.DataAccess.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartWorkout.DataAccess.Repository
{
	public class ExerciseRepository : IGenericRepository<Exercise>
	{
		private readonly SmartWorkoutContext _context;

		public ExerciseRepository(SmartWorkoutContext context)

		{
			_context = context;
		}

		public void Add(Exercise exercise)
		{
			_context.Add(exercise);
			_context.SaveChanges();
		}

		public IEnumerable<Exercise> GetAll()
		{
			return _context.Exercises.ToList();
		}

		public Exercise? GetById(int Id)
		{
			return _context.Exercises.Find(Id);
		}

		public bool Remove(int Id)
		{
			var exercise = _context.Exercises.Find(Id);
			if (exercise is { })
			{
				_context.Exercises.Remove(exercise);
				_context.SaveChanges();
				return true;
			}
			return false;
		}


		public void Update(Exercise exercise)
		{
			_context.Update(exercise);
			_context.SaveChanges();
		}
	}
}
