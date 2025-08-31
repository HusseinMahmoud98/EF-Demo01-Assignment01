using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01.Entities
{
    internal class Course_Inst
    {
        #region 1. By Convention
        public int Inst_Id { get; set; }
        public int Course_Id { get; set; }
        public string? Elevation { get; set; } 
        #endregion

    }
}
