using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace models
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> opt) : base(opt) 
        {

        }

        public DbSet<produto> Produtos { get; set; }
        public DbSet<vendas> vendas { get; set; }
        public DbSet<Clientes> clientes { get; set; }


    }
}
