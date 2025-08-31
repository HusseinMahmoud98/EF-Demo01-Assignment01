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
    internal class InstructorConfiguration : IEntityTypeConfiguration<Instructor>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Instructor> builder)
        {
            builder.HasKey(i => i.Id);

            builder.Property(i => i.Name)
                .HasColumnName("Inst_Name")
                .HasColumnType("varchar")
                .HasMaxLength(50);

            builder.Property(i => i.Bonus)
                .HasColumnType("money");

            builder.Property(i => i.Salary)
                .HasColumnType("money")
                .IsRequired();
        }
    }
}
