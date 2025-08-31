using Assignment01.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01.Configuration
{
    internal class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasKey(s => s.Id);

            builder.Property(s => s.FName)
                .HasColumnName("St_Fname")
                .IsRequired();

            builder.Property(s => s.LName)
                .HasColumnName("St_Lname");

            builder.Property(s => s.Address)
                .HasColumnName("St_Address");

            builder.Property(s => s.Dept_Id)
                .IsRequired();
        }
    }
}
