using Microsoft.EntityFrameworkCore;
using SmartWorkout.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartWorkout.DataAccess.Configurations
{
    public class AdminUserConfiguration : IEntityTypeConfiguration<AdminUser>
    {

        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AdminUser> builder)
        {
            builder.ToTable("AdminUser").HasKey(au => au.Id);
            builder.Property(au => au.Email).IsRequired();
            builder.Property(au => au.Password).IsRequired();

        }
    }
}
