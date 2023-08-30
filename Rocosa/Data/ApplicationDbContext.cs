using Microsoft.EntityFrameworkCore;
using Rocosa.Models;

namespace Rocosa.Data
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<Categoria> Categoria { get; set; }

    }
}
