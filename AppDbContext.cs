using Database_with_LINQ.Models;
using Microsoft.EntityFrameworkCore;

namespace Database_with_LINQ.Data
{
    public class AppDbContext :DbContext
    {
       
        public DbSet<Student> Students { get; set; }
        public DbSet<Faculty> Faculty { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }

        protected readonly IConfiguration Configuration;
        public AppDbContext(IConfiguration configuration)
        {
            Configuration = configuration;

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Configure the database connection string
            optionsBuilder.UseSqlServer(Configuration.GetConnectionString("DbConnectionString"));
        }
        
    }
    
}
