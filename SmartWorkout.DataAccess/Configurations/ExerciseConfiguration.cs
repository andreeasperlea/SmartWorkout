using Microsoft.EntityFrameworkCore;
using SmartWorkout.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartWorkout.DataAccess.Configurations
{
	public class ExerciseConfiguration:IEntityTypeConfiguration<Exercise>
	{

		public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Exercise> builder)
		{
			builder.ToTable("Exercise").HasKey(e => e.Id);
			builder.Property(e => e.Name).IsRequired();
		}
	}
}
