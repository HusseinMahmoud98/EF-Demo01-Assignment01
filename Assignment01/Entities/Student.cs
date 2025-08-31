using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01.Entities
{
    [Table("Students", Schema = "dbo")]
    internal class Student
    {
        #region 1. By Convention
        //public int Id { get; set; }
        //public string? FName { get; set; }
        //public string? LName { get; set; }
        //public string? Address { get; set; }
        //public int Age { get; set; }
        //public int Dept_Id { get; set; }
        #endregion

        #region 1. By Annotation
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(20, MinimumLength = 2)]
        [Column("St_Fname")]
        public string? FName { get; set; }

        [StringLength(20, MinimumLength = 2)]
        [Column("St_Lname")]
        public string? LName { get; set; }
        [Column("St_Address")]
        [StringLength(100, MinimumLength = 20)]
        public string? Address { get; set; }
        [Required]
        [Range(20, 35)]
        public int Age { get; set; }
        public int Dept_Id { get; set; }
        #endregion
    }
}
