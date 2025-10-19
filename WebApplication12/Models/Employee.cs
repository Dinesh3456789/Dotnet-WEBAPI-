using System.ComponentModel.DataAnnotations;

namespace WebApplication12.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeID { get; set; }
        [Required , MaxLength(50)]
        public string EmployeeName { get; set; }
        [Required] 
        public long EmployeePhone { get; set; }
        [Required, MaxLength(50)]
        public string EmployeeEmailID { get; set; }
        [Required, MaxLength(50)]
        public string EmployeeFirstName { get; set; }
        [Required, MaxLength(50)]
        public int EmployeeLastName { get; set; }

    }
}
