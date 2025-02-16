using System;

using Microsoft.EntityFrameworkCore;
using Modelos;

public class EFContext : DbContext
{
    public DbSet<Cliente>? Clientes { get; set; }
    public DbSet<Motorista>?  Motoristas { get; set; }
    public DbSet<Passageiro>? Passageiros { get; set; }
    public DbSet<Veiculo>? Veiculos { get; set; }
    public DbSet<Viagem>? Viagens { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured) {
            string dbPath ="./transportes.db";
            optionsBuilder.UseSqlite($"Data Source={dbPath}");
        }
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Cliente>(entity =>
        {
            entity.HasKey(c => c.IdCliente); // Define a chave primária
            entity.UseTpcMappingStrategy();  // Mantém o TPC
        });

        modelBuilder.Entity<Motorista>(entity =>
        {
            entity.HasKey(c => c.IdMotorista);
            entity.UseTpcMappingStrategy();
        });

        modelBuilder.Entity<Passageiro>(entity =>
        {
            entity.HasKey(c => c.IdPassageiro);
            entity.UseTpcMappingStrategy();
        });

        modelBuilder.Entity<Veiculo>(entity =>
        {
            entity.HasKey(c => c.IdVeiculo);
            entity.UseTpcMappingStrategy();
        });

        modelBuilder.Entity<Viagem>(entity =>
        {
            entity.HasKey(c => c.IdViagem);
            entity.UseTpcMappingStrategy();
        });
    }
}
