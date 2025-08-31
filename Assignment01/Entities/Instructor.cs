using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01.Entities
{
    [Table("Instuctors", Schema = "dbo")]
    internal class Instructor
    {
        #region 1. By Convention
        //public int Id { get; set; }
        //public string Name { get; set; }
        //public double Bonus { get; set; }
        //public double Salary { get; set; }
        //public string? Address { get; set; }
        //public int? HoureRate { get; set; }
        //public int Dept_Id { get; set; } 
        #endregion

        #region 2. By Annotation
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Column("Inst_Name")]
        public string Name { get; set; }

        [Range(1000, 5000)]
        public double Bonus { get; set; }

        [Range(15000, 75000)]
        public double Salary { get; set; }

        [Column("Inst_Address")]
        [StringLength(200, MinimumLength = 20)]
        public string? Address { get; set; }
        public int? HoureRate { get; set; }
        
        [Required]
        public int Dept_Id { get; set; } 
        #endregion
    }
}
