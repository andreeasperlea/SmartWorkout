using Microsoft.EntityFrameworkCore;
using SmartWorkout.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartWorkout.DataAccess.Configurations
{
	public class ClientConfiguration : IEntityTypeConfiguration<Client>
	{

		public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Client> builder)
		{
			builder.ToTable("Client").HasKey(u=> u.Id);
			builder.Property(u=>u.Name).IsRequired();
			builder.Property(u => u.Surname).IsRequired();

		}
	}
}
