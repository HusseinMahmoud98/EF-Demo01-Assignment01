using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01.Entities
{
    internal class Instructor
    {
        #region 1. By Convention
        public int Id { get; set; }
        public string Name { get; set; }
        public double Bonus { get; set; }
        public double Salary { get; set; }
        public string? Address { get; set; }
        public int? HoureRate { get; set; }
        public int Dept_Id { get; set; } 
        #endregion
    }
}
