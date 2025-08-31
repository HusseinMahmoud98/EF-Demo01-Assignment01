using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01.Entities
{
    [Table("Topics", Schema = "dbo")]
    internal class Topic
    {
        #region 1. By Convention
        //public int Id { get; set; }
        //public string? Name { get; set; }
        #endregion

        #region 2. By Annotation
        [Key]
        public int Id { get; set; }
        [Column("Top_Name")]
        [Required]
        public string? Name { get; set; }
        #endregion
    }
}
