using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Performans_Odevi_232
{
    internal class UrunDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\mssqllocaldb;Database=vtMarket;Integrated Security=true");
        }

        public DbSet<Urun> TblUrunler { get; set; }
        public DbSet<StokHareketi> TblStokHareketleri { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Urun>()
                .Property(x => x.SatisFiyati)
                .HasColumnType("decimal(18,2)");
        }


    }
}
