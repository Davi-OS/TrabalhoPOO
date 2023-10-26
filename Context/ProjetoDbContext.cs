using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabalho_POO.Models;

namespace Trabalho_POO.Context
{
    public class ProjetoDbContext: DbContext
    {
        private const string connectionString = "Server=localhost;Database=ProjetoPOO;Uid=root;Pwd=Droit*18;";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(connectionString,ServerVersion.AutoDetect(connectionString));
        }
        
        public DbSet<Conta> Conta { get; set; }
        public DbSet<Cliente_>Clientes { get; set; }
        public DbSet<ContaAgua> ContaAgua { get; set; }
        public DbSet<ContaLuz> ContaLuz { get; set; }
    }
}
