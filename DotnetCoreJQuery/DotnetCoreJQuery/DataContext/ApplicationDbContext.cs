using DotnetCoreJQuery.Models;
using Microsoft.EntityFrameworkCore;

namespace DotnetCoreJQuery.DataContext
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<Category> Categories { get; set; }
    }
}
