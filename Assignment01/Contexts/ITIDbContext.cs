using Assignment01.Configuration;
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
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Course_Inst>()
        //                .HasKey(ci => new { ci.Course_Id, ci.Inst_Id });

        //    modelBuilder.Entity<Stud_Course>()
        //                .HasKey(sc => new { sc.stud_Id, sc.Course_Id });
        //}
        #endregion

        #region 3. By Fluent Api, 4. By Configuration
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region By Fluent Api
            #region Course
            //modelBuilder.Entity<Course>()
            //    .HasKey(c => c.Id);

            //modelBuilder.Entity<Course>()
            //    .Property(c => c.Name)
            //    .IsRequired()
            //    .HasMaxLength(100)
            //    .HasColumnName("Crs_Name")
            //    .HasColumnType("varchar");
            #endregion

            #region Course_Inst
            //modelBuilder.Entity<Course_Inst>()
            //        .HasKey(ci => new { ci.Course_Id, ci.Inst_Id });

            //modelBuilder.Entity<Course_Inst>()
            //    .Property(ci => ci.Elevation)
            //    .HasColumnType("varchar")
            //    .HasMaxLength(30);
            #endregion

            #region Department
            //modelBuilder.Entity<Department>()
            //        .HasKey(d => d.Id);

            //modelBuilder.Entity<Department>()
            //        .Property(d => d.Name)
            //        .HasColumnName("Dept_Name")
            //        .HasColumnType("varchar")
            //        .HasMaxLength(50)
            //        .IsRequired(true);

            //modelBuilder.Entity<Department>()
            //    .Property(d => d.HirigDate)
            //    .HasDefaultValueSql("GETDATE()");
            #endregion

            #region Instructor
            //modelBuilder.Entity<Instructor>()
            //        .HasKey(i => i.Id);

            //modelBuilder.Entity<Instructor>()
            //    .Property(i => i.Name)
            //    .HasColumnName("Inst_Name")
            //    .HasColumnType("varchar")
            //    .HasMaxLength(50);

            //modelBuilder.Entity<Instructor>()
            //    .Property(i => i.Bonus)
            //    .HasColumnType("money");

            //modelBuilder.Entity<Instructor>()
            //    .Property(i => i.Salary)
            //    .HasColumnType("money")
            //    .IsRequired();

            #endregion

            #region Student
            //modelBuilder.Entity<Student>()
            //        .HasKey(s => s.Id);

            //modelBuilder.Entity<Student>()
            //    .Property(s => s.FName)
            //    .HasColumnName("St_Fname")
            //    .IsRequired();

            //modelBuilder.Entity<Student>()
            //    .Property(s => s.LName)
            //    .HasColumnName("St_Lname");

            //modelBuilder.Entity<Student>()
            //    .Property(s => s.Address)
            //    .HasColumnName("St_Address");

            //modelBuilder.Entity<Student>()
            //    .Property(s => s.Dept_Id)
            //    .IsRequired();
            #endregion

            #region Stud_Course
            //modelBuilder.Entity<Stud_Course>()
            //        .HasKey(sc => new
            //        {
            //            sc.stud_Id,
            //            sc.Course_Id
            //        });
            #endregion

            #region Topic
            //modelBuilder.Entity<Topic>()
            //        .HasKey(t => t.Id);

            //modelBuilder.Entity<Topic>()
            //    .Property(t => t.Name)
            //    .HasColumnName("Top_Name")
            //    .IsRequired()
            //    .HasMaxLength(50); 
            #endregion
            #endregion

            #region 4. By Configuration
            modelBuilder.ApplyConfiguration(new CourseConfiguration());
            modelBuilder.ApplyConfiguration(new Course_InstConfiguration());
            modelBuilder.ApplyConfiguration(new DepartmentConfiguration());
            modelBuilder.ApplyConfiguration(new InstructorConfiguration());
            modelBuilder.ApplyConfiguration(new StudentConfiguration());
            modelBuilder.ApplyConfiguration(new Stud_CourseConfiguration()); 
            #endregion

        }

        #endregion

      


        #region DBSets
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Stud_Course> St_Crs { get; set; }
        public DbSet<Topic> Topics { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Course_Inst> Crs_Insts { get; set; } 
        #endregion


    }
}
