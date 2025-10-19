using Microsoft.EntityFrameworkCore;
using WebApplication12.Models;

namespace WebApplication12.Database
{
    public class DatabaseDbContext :DbContext
    {
        public DatabaseDbContext(DbContextOptions options):base(options)
        {
            
        }

        //dbset 

        public DbSet<Employee> Employees { get; set; }
    }
}
