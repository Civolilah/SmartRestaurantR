using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SmartRestaurant.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartRestaurant.DbContext
{
    public class AppDBContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options)
            : base(options)
        {
        }

        public DbSet<Proizvod> Proizvod { get; set; }
        public DbSet<JedinicaKolicine> JedinicaKolicine { get; set; }
        public DbSet<KategorijaProizvoda> KategorijaProizvoda { get; set; }
        public DbSet<Korisnici> Korisnici { get; set; }
        public DbSet<KorisnikUloga> KorisnikUloga { get; set; }
        public DbSet<MjestoPosluzivanja> MjestoPosluzivanja { get; set; }
        public DbSet<Narudzba> Narudzba { get; set; }
        public DbSet<NarudzbaDetalji> NarudzbaDetalji { get; set; }
        public DbSet<NarudzbaProizvod> NarudzbaProizvod { get; set; }
        public DbSet<ProizvodDetalji> ProizvodDetalji { get; set; }
        public DbSet<Skladiste> Skladiste { get; set; }
        public DbSet<StatusNarudzbe> StatusNarudzbe { get; set; }
        public DbSet<Uloge> Uloge { get; set; }
        public DbSet<KorisnikNarudzba> KorisnikNarudzba { get; set; }
        public DbSet<PodKategorijeProizvoda> PodKategorijeProizvoda { get; set; }
        public DbSet<KorisnikOcjena> KorisnikOcjena { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
