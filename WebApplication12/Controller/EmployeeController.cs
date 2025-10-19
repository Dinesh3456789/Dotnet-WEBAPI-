using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication12.DTO;
using WebApplication12.Service;

namespace WebApplication12.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly EmployeeService _service;
        public EmployeeController(EmployeeService service)
        {
            _service = service;
        }

        [HttpPost]
        public IActionResult create(EmployeeRequestDTO employee)
        {
            var emp = _service.CreateEmployee(employee);
            return Ok("Successfully Added to Our Database :"+emp.EmployeeName);
        }
        [HttpGet("All")]
        public IActionResult getAll()
        {
         var getAll =   _service.GetAllEmployee();
            return Ok(getAll);
        }
        [HttpGet("ID")]
        public IActionResult getbyEmployeeID(int id)
        {
            var empl = _service.GetbyEmployeeID(id);
            return Ok(empl);
        }

        [HttpPut("Update")]
        public IActionResult update(int id , EmployeeRequestDTO empl)
        {
            var updateEmpl = _service.UpdateEmployee(id, empl);
            return Ok(updateEmpl);
        }

        [HttpDelete("delete")]
        public IActionResult delete(int id)
        {
            _service.deleteEmployee(id);
            return NoContent();
        }
    }
}
