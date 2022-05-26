using EComerce.Models;
using Microsoft.EntityFrameworkCore;
using Shopping.Models;

namespace EComerce.Data
{
    public class DBContext : DbContext
    {

        public DBContext(DbContextOptions<DBContext> options) : base(options)
        {

        }

        public DbSet<Avaliacao> Avaliacaos { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Loja> Lojas { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Correio> Correios { get; set; }
        public DbSet<Compra> Compras { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Compra>()
                .HasIndex(u => u.Cod)
                .IsUnique();
        }


    }
}
