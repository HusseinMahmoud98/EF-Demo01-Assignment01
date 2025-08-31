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
    internal class TopicConfiguration : IEntityTypeConfiguration<Topic>
    {
        public void Configure(EntityTypeBuilder<Topic> builder)
        {
           builder.HasKey(t => t.Id);

            builder.Property(t => t.Name)
                .HasColumnName("Top_Name")
                .IsRequired()
                .HasMaxLength(50);
        }
    }
}
