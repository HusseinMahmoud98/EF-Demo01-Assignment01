using Demo01.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Demo01.Configuration
{
    internal class EmployeeConfiguration : IEntityTypeConfiguration<Employee03>
    {
        public void Configure(EntityTypeBuilder<Employee03> E)
        {
          
                //modelBuilder.Entity<Employee03>().HasKey("EmpId");
                //modelBuilder.Entity<Employee03>().HasKey(nameof(Employee03.EmpId));
                E.HasKey(e => e.EmpId);

                E.Property(e => e.Name)
                 .IsRequired()
                 .HasColumnType("varchar")
                 .HasMaxLength(50)
                 .HasColumnName("EmployeeName");

                E.Property(e => e.Age)
                 .IsRequired(false);

                E.Property(e => e.Salary)
                 .HasColumnType("money");

                /*
                 *  E.Property(e => e.DateOfCreation)
                 *   .HasDefaultValue(DateTime.Now);
                 */

                E.Property(e => e.DateOfCreation)
                 .HasDefaultValueSql("GETDATE()");

        }
    }
}
