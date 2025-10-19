using System.ComponentModel.DataAnnotations;

namespace WebApplication12.DTO
{
    public class EmployeeRequestDTO
    {
        
        public string EmployeeName { get; set; }
       
        public long EmployeePhone { get; set; }
       
        public string EmployeeEmailID { get; set; }
        
        public string EmployeeFirstName { get; set; }
       
        public int EmployeeLastName { get; set; }
    }
}
