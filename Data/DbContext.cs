using Microsoft.EntityFrameworkCore;
using SQL_Lite.Models;

namespace SQL_Lite.Data
{
    public class CategoriaContext : DbContext
    {
        public CategoriaContext(DbContextOptions<CategoriaContext> options) : base(options)
        {
        }
        public DbSet<Categoria> Categorias { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Categoria>().HasKey(m => m.Id);

            builder.Entity<Categoria>().HasData(new Categoria {Id = 1, Nome = "Bebidas"});

            base.OnModelCreating(builder);
        }
    }
}