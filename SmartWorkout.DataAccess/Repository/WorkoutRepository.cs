using Microsoft.EntityFrameworkCore;
using SmartWorkout.DataAccess.Entities;
using SmartWorkout.DataAccess.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace SmartWorkout.DataAccess.Repository
{
	public class WorkoutRepository : IGenericRepository<Workout>
	{
		private readonly SmartWorkoutContext _context;

		public WorkoutRepository(SmartWorkoutContext context)
		{
			_context = context;
		}

		public void Add(Workout workout)
		{
			_context.Add(workout);
			_context.SaveChanges();
		}

		public IEnumerable<Workout> GetAll()
		{
			return _context.Workouts
				.Include(w => w.Client)
				.Include(w => w.ExerciseLogs)
				.ThenInclude(el => el.Exercise).ToList();
		}

		public Workout? GetById(int Id)
		{
			return _context.Workouts.Find(Id);
		}

		public bool Remove(int Id)
		{
			var workout = _context.Workouts.Find(Id);
			if (workout != null)
			{
				_context.Workouts.Remove(workout);
				_context.SaveChanges();
				return true;
			}
			return false;
		}

		public void Update(Workout workout)
		{
			_context.Update(workout);
			_context.SaveChanges();
		}
	}
}
