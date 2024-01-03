using
using Quiz.Models;

namespace Quiz.Data
{
  
    public class AppDbContext :DbContext
    {
       
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Course { get; set; }
      
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

    }
}
