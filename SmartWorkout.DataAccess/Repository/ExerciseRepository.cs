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

		public void Add(in Exercise sender)
		{
			_context.Add(sender).State = EntityState.Added;
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
				return true;
			}
			return false;
		}

		public int Save(in Exercise sender)
		{
			return _context.SaveChanges();
		}

		public void Update(in Exercise sender)
		{
			_context.Entry(sender).State = EntityState.Modified;
		}
	}
}
