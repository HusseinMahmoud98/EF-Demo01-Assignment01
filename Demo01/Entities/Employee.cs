using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo01.Entities
{
    internal class Employee01
    {
        public int Id { get; set; } //pk + identity constraint
        public string Name { get; set; }
        public int? Age { get; set; }
        public double Salary { get; set; }
        public  string? Email {  get; set; }
        public DateTime DateOfCreation { get; set; }
    }


    [Table("Emp02", Schema = "dbo")]
    internal class Employee02
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int EmpId { get; set; } //pk + identity constraint

        [Required]
        [Column("EmpName", TypeName = "varchar")]
        [StringLength(50, MinimumLength = 10)]
        public string Name { get; set; }

        [Range(20,60)]
        public int? Age { get; set; }

        [Column(TypeName = "money")]
        [DataType(DataType.Currency)]
        public double Salary { get; set; }

        [EmailAddress]  //example@example.com
        public string? Email { get; set; }

        [Phone]
        [DataType(DataType.PhoneNumber)]
        public string  PhoneNumber { get; set; }

        [NotMapped]
        public double TotalSalary {  get; set; }


        public DateTime DateOfCreation { get; set; }

        public string Password { get; set; }
    }


    internal class Employee03
    {
        public string EmpId { get; set; }
        public string Name { get; set; }

        public int? Age { get; set; }
        public string Email { get; set; }
        public double Salary {  set; get; }
        public DateTime DateOfCreation { get; set; }
    }

}
