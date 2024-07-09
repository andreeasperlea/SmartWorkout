using Microsoft.EntityFrameworkCore;
using SmartWorkout.DataAccess.Configurations;
using SmartWorkout.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartWorkout.DataAccess
{
	public class SmartWorkoutContext : DbContext
	{
		public SmartWorkoutContext()
		{
		}

		protected SmartWorkoutContext(DbContextOptions<SmartWorkoutContext> options) :base(options)
		{


		}

		public DbSet<Client> Users { get; set; }
		public DbSet<AdminUser> AdminUsers { get; set; }
		public DbSet<Workout > Workouts { get; set; }
		public DbSet<Exercise> Exercises {  get; set; } 
		
		public DbSet<ExerciseLog> ExerciseLogs { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			base.OnConfiguring(optionsBuilder);

			if (!optionsBuilder.IsConfigured)
			{
				var connectionString =
					"Data Source=localhost;Initial Catalog=SmartWorkout;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
				optionsBuilder.UseSqlServer(connectionString);
			}
	}



		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

			new ClientConfiguration().Configure(modelBuilder.Entity<Client>());
			new WorkoutConfiguration().Configure(modelBuilder.Entity<Workout>());
			new ExerciseConfiguration().Configure(modelBuilder.Entity<Exercise>());
			new ExerciseLogConfiguration().Configure(modelBuilder.Entity<ExerciseLog>());
		}
	}
}
