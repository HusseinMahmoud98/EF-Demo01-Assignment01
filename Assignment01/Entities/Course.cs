using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Assignment01.Entities
{
    [Table("Courses", Schema = "dbo")]
    internal class Course
    {
        #region 1. By Convention, 3. By Fluent Api, 4. By Configuration
        public int Id { get; set; }
        public int Duration { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public int Top_Id { get; set; }
        #endregion

        #region 2. By Annotation
        //[Key]
        //public int Id { get; set; }

        //[Required]
        //public int Duration { get; set; }
        //[Column("Crs_Name")]
        //public string Name { get; set; }

        //[StringLength(250, MinimumLength = 20)]
        //public string? Description { get; set; }

        //[Required]
        //public int Top_Id { get; set; }
        #endregion



    }
}
