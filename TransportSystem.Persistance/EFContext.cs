using System;

using Microsoft.EntityFrameworkCore;
using Modelos;

namespace TransportSystem.Persistance.EFContext;

public class EFContext : DbContext
{
    public DbSet<Cliente>? Clientes { get; set; }
    //public DbSet<Motorista>?  Motoristas { get; set; }
   // public DbSet<Passageiro>? Passageiros { get; set; }

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
        modelBuilder.Entity<Cliente>().UseTpcMappingStrategy();
        //modelBuilder.Entity<Motorista>() .ToTable("Motoristas");
        //modelBuilder.Entity<Passageiro>().ToTable("Passageiros");
    }
}
