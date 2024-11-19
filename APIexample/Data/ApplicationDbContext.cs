using Microsoft.EntityFrameworkCore;
using APIexample.Models.Entities;

namespace APIexample.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
     public DbSet<Employee> Employees { get; set; }
    }

}
