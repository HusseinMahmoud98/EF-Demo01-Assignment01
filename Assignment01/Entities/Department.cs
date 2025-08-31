using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01.Entities
{
    [Table("Departments", Schema = "dbo")]
    internal class Department
    {
        #region 1. By Convention
        [Key]
        public int Id { get; set; }

        [Column("Dept_Name")]
        public string? Name { get; set; }

        [Required]
        public int Inst_Id { get; set; }
        public DateTime HirigDate { get; set; } = DateTime.Now;

        #endregion

    }
}
