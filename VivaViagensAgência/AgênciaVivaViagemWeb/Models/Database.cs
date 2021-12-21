using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgênciaVivaViagemWeb.Models
{
    public class Database: DbContext
    {
        public DbSet<Destino> Destinos { get; set; }
        public DbSet<Promocao> Promocoes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseSqlServer(connectionString: @"Server=(localdb)\mssqllocaldb;Database=AgênciaVivaViagemWeb;Integrated Security=True");
        }



    }
}
