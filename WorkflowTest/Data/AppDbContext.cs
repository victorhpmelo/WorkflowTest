using Microsoft.EntityFrameworkCore;

namespace WorkflowTest.Data
{
    public class AppDbContext :DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Models.Person> People { get; set; }

    }
}
