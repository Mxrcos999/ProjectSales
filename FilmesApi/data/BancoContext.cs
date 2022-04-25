using Microsoft.EntityFrameworkCore;


namespace models
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> opt) : base(opt) 
        {


        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
          
        }

        public DbSet<Produtos> Produtos { get; set; }
        public DbSet<Vendas> vendas { get; set; }
        public DbSet<Clientes> clientes { get; set; }


    }
}
