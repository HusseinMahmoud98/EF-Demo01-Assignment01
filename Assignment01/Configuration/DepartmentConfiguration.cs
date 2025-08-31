using Assignment01.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01.Configuration
{
    internal class DepartmentConfiguration : IEntityTypeConfiguration<Department>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Department> builder)
        {
            builder.HasKey(d => d.Id);

            builder.Property(d => d.Name)
                    .HasColumnName("Dept_Name")
                    .HasColumnType("varchar")
                    .HasMaxLength(50)
                    .IsRequired(true);

            builder.Property(d => d.HirigDate)
                .HasDefaultValueSql("GETDATE()");
        }
    }
}
