using AutoMapper;
using WebApplication12.Database;
using WebApplication12.DTO;
using WebApplication12.Models;

namespace WebApplication12.Service
{
    public class EmployeeService
    {
        private readonly DatabaseDbContext _dbContext;
        private readonly IMapper _mapper;
        public EmployeeService(DatabaseDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
           _mapper = mapper;
        }

        public EmployeeResponseDTO CreateEmployee(EmployeeRequestDTO employeeDto)
        {
            var empl = _mapper.Map<Employee>(employeeDto);
            _dbContext.Employees.Add(empl);
            _dbContext.SaveChanges();

            return _mapper.Map<EmployeeResponseDTO>(empl);
        }

        public EmployeeResponseDTO GetbyEmployeeID(int id)
        {
            var emp = _dbContext.Employees.Find(id);
            return _mapper.Map<EmployeeResponseDTO>(emp);
        }

        public List<EmployeeResponseDTO> GetAllEmployee()
        {
            var empl = _dbContext.Employees.ToList();
            return _mapper.Map<List<EmployeeResponseDTO>>(empl);
        }

        public EmployeeResponseDTO UpdateEmployee(int id , EmployeeRequestDTO employee)
        {
            var oldempl = _dbContext.Employees.Find(id);
            _mapper.Map(employee, oldempl);
            _dbContext.SaveChanges();

            return _mapper.Map<EmployeeResponseDTO>(oldempl);
        }

        public void deleteEmployee(int id)
        {
            var del = _dbContext.Employees.Find(id);
            _dbContext.Employees.Remove(del);
            _dbContext.SaveChanges();
        }
    }
}
