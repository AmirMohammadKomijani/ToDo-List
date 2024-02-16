using Microsoft.EntityFrameworkCore;
using ToDo_App.Model;

namespace magicVilla_api.Data
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
        public DbSet<List> Lists { get; set; }
    }
}
