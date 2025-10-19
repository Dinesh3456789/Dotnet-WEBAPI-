using AutoMapper;
using WebApplication12.Models;

namespace WebApplication12.DTO
{
    public class EmployeeProfile :Profile
    {
        public EmployeeProfile()
        {
            CreateMap<EmployeeRequestDTO, Employee>();
            CreateMap<Employee, EmployeeResponseDTO>();
        }
    }
}
