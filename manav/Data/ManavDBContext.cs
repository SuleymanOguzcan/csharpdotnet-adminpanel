using manav.Models;
using Microsoft.EntityFrameworkCore;

namespace manav.Data
{
    public class ManavDBContext : DbContext
    {
        public ManavDBContext(DbContextOptions<ManavDBContext> options) : base(options)
        {
        }

        public DbSet<Meyve> Meyveler{ get; set; }
        public DbSet<Kategori> Kategoriler{ get; set; }
        public DbSet<Renk> Renkler{ get; set; }
        public DbSet<Cinsiyet> Cinsiyetler{ get; set; }
        public DbSet<Görev> Görevler{ get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Meyve>().HasData(
                new Meyve{MeyveID=1,MeyveAdı="elma",RenkID=1,KategoriID=2},
                new Meyve{MeyveID=2,MeyveAdı="armut",RenkID=2,KategoriID=1},
                new Meyve{MeyveID=3,MeyveAdı="ayva",RenkID=1,KategoriID=3},
                new Meyve{MeyveID=4,MeyveAdı="karpuz",RenkID=2,KategoriID=2},
                new Meyve{MeyveID=5,MeyveAdı="erik",RenkID=5,KategoriID=1},
                new Meyve{MeyveID=6,MeyveAdı="muz",RenkID=2,KategoriID=3}
                
            );

            modelBuilder.Entity<Kategori>().HasData(
                new Kategori{ KategoriID=1,KategoriAdı="Tropikal Meyveler"},
                new Kategori{ KategoriID=2,KategoriAdı="Şekerli Meyveler"},
                new Kategori{ KategoriID=3,KategoriAdı="Ekşi Meyveler"},
                new Kategori{ KategoriID=4,KategoriAdı="Kış Meyveleri"}
            );

            modelBuilder.Entity<Renk>().HasData(
                new Renk {RenkID=1 ,RenkAdı="Kırmızı" },
                new Renk {RenkID=2 ,RenkAdı="Sarı" },
                new Renk {RenkID=3 ,RenkAdı="Yeşil" },
                new Renk {RenkID=4 ,RenkAdı="Turuncu" },
                new Renk {RenkID=5 ,RenkAdı="Siyah" },
                new Renk {RenkID=6 ,RenkAdı="Mor" }

                
            );
            modelBuilder.Entity<Cinsiyet>().HasData(
                new Cinsiyet {CinsiyetID=1,CinsiyetAdı="Kadın"},
                new Cinsiyet {CinsiyetID=2,CinsiyetAdı="Erkek"},
                new Cinsiyet {CinsiyetID=3,CinsiyetAdı="Diğer"}
                


            );
            modelBuilder.Entity<Görev>().HasData(
                new Görev { GörevID = 1, GörevAdı ="Kasiyer" },
                new Görev { GörevID = 2, GörevAdı ="Reyon Görevlisi" },
                new Görev { GörevID = 3, GörevAdı ="Müdür" }
                



            );
        }

    }
}
