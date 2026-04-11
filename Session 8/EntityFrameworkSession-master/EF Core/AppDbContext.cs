using EF_Core.Models;
using Microsoft.EntityFrameworkCore;

namespace EF_Core
{
    public class AppDbContext: DbContext
    {
        public DbSet<Student> Teachars { get; set; }
        public DbSet<Teacher> Teachers { get; set; }    
        public DbSet<Course> Courses { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)   
        {
            
        }
    }
}
