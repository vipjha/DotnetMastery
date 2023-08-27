using AbbyWeb.Model;
using Microsoft.EntityFrameworkCore;

namespace AbbyWeb.Data
{
    public class ApplicationDbCotext : DbContext
    {
        public ApplicationDbCotext(DbContextOptions<ApplicationDbCotext> options) : base(options)
        {

        }

        public DbSet<Category> Category { get; set; }
    }
}
