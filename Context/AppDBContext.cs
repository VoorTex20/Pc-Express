using Microsoft.EntityFrameworkCore;
using Pc_Express.Models;

namespace Pc_Express.Context
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options ) : base(options)
        {
        }

        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Pecas> Pecas { get; set; }
    }
}
