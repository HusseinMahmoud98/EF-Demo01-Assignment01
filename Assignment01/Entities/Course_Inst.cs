using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Assignment01.Entities
{
    [Table("Crs_Ins", Schema = "dbo")]
    internal class Course_Inst
    {
        #region 1. By Convention, 3. By Fluent Api, 4.By Configuration
        public int Inst_Id { get; set; }
        public int Course_Id { get; set; }
        public string? Elevation { get; set; }
        #endregion

        #region 2. By Annotation
        //public int Inst_Id { get; set; }
        //public int Course_Id { get; set; }
        //public string? Elevation { get; set; }
        #endregion

    }
}
