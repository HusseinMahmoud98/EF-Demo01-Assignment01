using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01.Entities
{
    internal class Department
    {
        #region 1. By Convention
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Inst_Id { get; set; }
        public DateTime HirigDate { get; set; } = DateTime.Now; 
        #endregion

    }
}
