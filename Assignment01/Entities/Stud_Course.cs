using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01.Entities
{
    [Table("St_Crs", Schema = "dbo")]
    internal class Stud_Course
    {
        #region 1. By Convention
        //public int stud_Id { get; set; }
        //public int Course_Id { get; set; }
        //public int? Grade { get; set; } 
        #endregion

        #region 2. By Annotation
        public int stud_Id { get; set; }

 
        public int Course_Id { get; set; }

        public int? Grade { get; set; }
        #endregion

    }
}
