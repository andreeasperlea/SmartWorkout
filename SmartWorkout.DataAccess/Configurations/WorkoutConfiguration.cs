using Microsoft.EntityFrameworkCore;
using SmartWorkout.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartWorkout.DataAccess.Configurations
{
	internal class WorkoutConfiguration : IEntityTypeConfiguration<Workout>
	{
		public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Workout> builder)
		{
			builder.ToTable("Workout").HasKey(w => w.Id);
			builder.Property(w => w.Date).IsRequired();
			builder.HasOne(w => w.Client).WithMany(u => u.Workouts).HasForeignKey(u => u.ClientId)
				.HasConstraintName("FK_Workout_User");
		}
	}
}
