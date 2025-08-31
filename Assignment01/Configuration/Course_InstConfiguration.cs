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
    internal class Course_InstConfiguration : IEntityTypeConfiguration<Course_Inst>
    {
        public void Configure(EntityTypeBuilder<Course_Inst> builder)
        {
            builder.HasKey(ci => new { ci.Course_Id, ci.Inst_Id });

            builder.Property(ci => ci.Elevation)
                .HasColumnType("varchar")
                .HasMaxLength(30);
        }
    }
}
