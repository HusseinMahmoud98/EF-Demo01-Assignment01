using Assignment01.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01.Contexts
{
    internal class ITIDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = .; Database = EF_ITI; Trusted_Connection = True; TrustServerCertificate = True;");
        }

        #region By Convention or By Annotation Composite Primary Key
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course_Inst>()
                        .HasKey(ci => new { ci.Course_Id, ci.Inst_Id });

            modelBuilder.Entity<Stud_Course>()
                        .HasKey(sc => new { sc.stud_Id, sc.Course_Id });
        }
        #endregion

        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Stud_Course> St_Crs { get; set; }
        public DbSet<Topic> Topics { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Course_Inst> Crs_Insts { get; set; }

    
    }
}
