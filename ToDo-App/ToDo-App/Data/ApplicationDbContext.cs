using Microsoft.EntityFrameworkCore;
using ToDo_App.Model;

namespace ToDo_App.Data
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        //public ApplicationDbContext()
        //{

        //}
        public DbSet<Lists> Lists { get; set; }
        public DbSet<Tasks> Tasks { get; set; }
    }
}
