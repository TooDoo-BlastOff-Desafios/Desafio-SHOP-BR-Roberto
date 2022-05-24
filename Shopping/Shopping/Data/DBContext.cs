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

        public DbSet<Product> Products { get; set; }
        public DbSet<Loja> Lojas { get; set; }
        public DbSet<Shopping.Models.Client>? Client { get; set; }
        public DbSet<Shopping.Models.Correio>? Correio { get; set; }

    }
}
