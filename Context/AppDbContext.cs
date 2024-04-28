using Microsoft.EntityFrameworkCore;
using pagination_example_back.Models;

namespace pagination_example_back.Context
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {

        }

        public DbSet<Usuario> Usuarios { get; set; }
    }
}
