// Data/MeuContexto.cs
using Checkpoint.Models;
using Microsoft.EntityFrameworkCore;

namespace Checkpoint.Data
{
    public class MeuContexto : DbContext
    {
        public DbSet<rm97432_Fornecedor> Fornecedores { get; set; }
        public DbSet<rm97432_Produto> Produtos { get; set; }
        public DbSet<rm97432_Pedido> Pedidos { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseOracle("User Id=rm97432;Password=fiap25;Data Source=oracle.fiap.com.br:1521/orcl;");
        }

        // ADICIONE ESTE MÉTODO ABAIXO
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<rm97432_Produto>()
                .Property(p => p.preco)
                .HasPrecision(18, 2);

            modelBuilder.Entity<rm97432_Pedido>()
                .Property(p => p.valorTotal)
                .HasPrecision(18, 2);
        }
    }
}