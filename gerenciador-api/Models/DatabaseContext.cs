using System;
using System.Linq;
using System.Reflection;
using Microsoft.EntityFrameworkCore;
using GerenciadorApi.Helpers;

namespace GerenciadorApi.Models
{
    public class DataBaseContext : DbContext
    {
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Venda> Vendas { get; set; }
        public DbSet<VendaProduto> VendaProdutos { get; set; }
        public DbSet<Venda> VendaPagamentos { get; set; }
        public DbSet<Perfil> Perfis { get; set; }


        public DataBaseContext(DbContextOptions<DataBaseContext> options) :
                base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            modelBuilder.Entity<Categoria>().HasData(
                new Categoria { Id = 1, Nome = "Carne Bovina", CriadoEm = DateTime.Now, AtualizadoEm = DateTime.Now }
            );

            modelBuilder.Entity<Perfil>().HasData(
              new Perfil
              {
                  Id = 1,
                  Nome = "Admin",
                  AtualizadoEm = DateTime.Now,
                  CriadoEm = DateTime.Now
              }
            );            
        }

        public override int SaveChanges()
        {
            atualizarCamposDeAuditoria();
            return base.SaveChanges();
        }

        private void atualizarCamposDeAuditoria()
        {
            var entities = ChangeTracker.Entries()
                .Where(x => x.Entity is ModeloBase && (x.State == EntityState.Added || x.State == EntityState.Modified));

            foreach (var entity in entities)
            {
                var now = DateTime.UtcNow;

                if (entity.State == EntityState.Added)
                {
                    ((ModeloBase)entity.Entity).CriadoEm = now;
                }
                ((ModeloBase)entity.Entity).AtualizadoEm = now;
            }
        }
    }
}