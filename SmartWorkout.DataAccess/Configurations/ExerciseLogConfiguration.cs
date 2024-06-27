using Microsoft.EntityFrameworkCore;
using SmartWorkout.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartWorkout.DataAccess.Configurations
{
	public  class ExerciseLogConfiguration : IEntityTypeConfiguration<ExerciseLog>
	{
		public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<ExerciseLog> builder)
		{
			builder.HasKey(el => new { el.WorkoutId, el.ExerciseId });
			builder
			.HasOne(el => el.Workout)
			.WithMany(w => w.ExerciseLogs)
			.HasForeignKey(el => el.WorkoutId);

			builder
				.HasOne(el => el.Exercise)
				.WithMany(e => e.ExerciseLogs)
				.HasForeignKey(el => el.ExerciseId);

		}
	}
}
