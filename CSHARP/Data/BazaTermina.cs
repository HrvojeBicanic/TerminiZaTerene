using Microsoft.EntityFrameworkCore;
using TerminiZaTerene.Models;

namespace TerminiZaTerene.Data
{
    public class BazaTermina : DbContext
    {

        public BazaTermina(DbContextOptions<BazaTermina> opcije) : base(opcije)
        {

        }

        public DbSet<Korisnik> Korisnici { get; set; }
        public DbSet<Teren> Tereni { get; set; }
        public DbSet<Termin> Termini { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Termin>()
                .Property(t => t.Pocetak)
                .HasConversion(
                    v => v.HasValue ? $"{v.Value:yyyy-MM-dd HH:mm:ss}" : null,
                    v => DateTimeOffset.Parse(v ?? "")
                );

            modelBuilder.Entity<Termin>()
                .Property(t => t.Kraj)
                .HasConversion(
                    v => v.HasValue ? $"{v.Value:yyyy-MM-dd HH:mm:ss}" : null,
                    v => DateTimeOffset.Parse(v ?? "")
                );



        }
    }
}

