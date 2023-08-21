using Microsoft.EntityFrameworkCore;

namespace Lab9.Models
{
    public class DataContext :DbContext
    {
        public DataContext()
        {
            
        }
        public DataContext(DbContextOptions options) :base(options) 
        {
            
        }

        public DbSet<Employee> Employees { get; set; }             
        public DbSet<Department> Departments { get; set; }             
    }
}
