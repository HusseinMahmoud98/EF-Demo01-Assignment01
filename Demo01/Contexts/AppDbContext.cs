using Demo01.Configuration;
using Demo01.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo01.Contexts
{
    internal class AppDbContext : DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region fluentApi
            ////modelBuilder.Entity<Employee03>().HasKey("EmpId");
            ////modelBuilder.Entity<Employee03>().HasKey(nameof(Employee03.EmpId));
            //modelBuilder.Entity<Employee03>().HasKey(e => e.EmpId);

            //modelBuilder.Entity<Employee03>()
            //            .Property(e => e.Name)
            //            .IsRequired()
            //            .HasColumnType("varchar")
            //            .HasMaxLength(50)
            //            .HasColumnName("EmployeeName");

            //modelBuilder.Entity<Employee03>()
            //            .Property(e => e.Age)
            //            .IsRequired(false);

            //modelBuilder.Entity<Employee03>()
            //            .Property(e => e.Salary)
            //            .HasColumnType("money");

            ///*
            // * modelBuilder.Entity<Employee03>()
            // * .Property(e => e.DateOfCreation)
            // * .HasDefaultValue(DateTime.Now);
            // */


            //modelBuilder.Entity<Employee03>()
            //            .Property(e => e.DateOfCreation)
            //            .HasDefaultValueSql("GETDATE()");




            //modelBuilder.Entity<Employee03>(E =>
            //{
            //    //modelBuilder.Entity<Employee03>().HasKey("EmpId");
            //    //modelBuilder.Entity<Employee03>().HasKey(nameof(Employee03.EmpId));
            //    E.HasKey(e => e.EmpId);

            //    E.Property(e => e.Name)
            //     .IsRequired()
            //     .HasColumnType("varchar")
            //     .HasMaxLength(50)
            //     .HasColumnName("EmployeeName");

            //    E.Property(e => e.Age)
            //     .IsRequired(false);

            //    E.Property(e => e.Salary)
            //     .HasColumnType("money");

            //    /*
            //     *  E.Property(e => e.DateOfCreation)
            //     *   .HasDefaultValue(DateTime.Now);
            //     */


            //    E.Property(e => e.DateOfCreation)
            //     .HasDefaultValueSql("GETDATE()");

            //}); 
            #endregion

            modelBuilder.ApplyConfiguration(new EmployeeConfiguration());
            base.OnModelCreating(modelBuilder);
        }


        public AppDbContext()
        {
            
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = .; Database = AppDemo01; Trusted_Connection = True; TrustServerCertificate = True;");
        }

        public DbSet<Employee02> Employees { get;  set; }
    }
}
