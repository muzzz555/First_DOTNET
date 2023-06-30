using First_Dotnet.Models;
using Microsoft.EntityFrameworkCore;

namespace First_Dotnet.Data
{
    public class ApplicationDBContext:DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) :base(options) {
            
        }
        public DbSet<Student> Students { get; set; }
    }
}