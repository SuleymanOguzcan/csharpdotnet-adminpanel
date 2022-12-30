﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using manav.Data;

#nullable disable

namespace manav.Migrations
{
    [DbContext(typeof(ManavDBContext))]
    partial class ManavDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("manav.Models.Kategori", b =>
                {
                    b.Property<int>("KategoriID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("KategoriID"));

                    b.Property<string>("KategoriAdı")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("KategoriID");

                    b.ToTable("Kategoriler");

                    b.HasData(
                        new
                        {
                            KategoriID = 1,
                            KategoriAdı = "Tropikal Meyveler"
                        },
                        new
                        {
                            KategoriID = 2,
                            KategoriAdı = "Şekerli Meyveler"
                        },
                        new
                        {
                            KategoriID = 3,
                            KategoriAdı = "Ekşi Meyveler"
                        },
                        new
                        {
                            KategoriID = 4,
                            KategoriAdı = "Kış Meyveleri"
                        });
                });

            modelBuilder.Entity("manav.Models.Meyve", b =>
                {
                    b.Property<int>("MeyveID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MeyveID"));

                    b.Property<int>("KategoriID")
                        .HasColumnType("int");

                    b.Property<string>("MeyveAdı")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("RenkID")
                        .HasColumnType("int");

                    b.HasKey("MeyveID");

                    b.HasIndex("KategoriID");

                    b.HasIndex("RenkID");

                    b.ToTable("Meyveler");

                    b.HasData(
                        new
                        {
                            MeyveID = 1,
                            KategoriID = 2,
                            MeyveAdı = "elma",
                            RenkID = 1
                        },
                        new
                        {
                            MeyveID = 2,
                            KategoriID = 1,
                            MeyveAdı = "armut",
                            RenkID = 2
                        },
                        new
                        {
                            MeyveID = 3,
                            KategoriID = 3,
                            MeyveAdı = "ayva",
                            RenkID = 1
                        },
                        new
                        {
                            MeyveID = 4,
                            KategoriID = 2,
                            MeyveAdı = "karpuz",
                            RenkID = 2
                        },
                        new
                        {
                            MeyveID = 5,
                            KategoriID = 1,
                            MeyveAdı = "erik",
                            RenkID = 5
                        },
                        new
                        {
                            MeyveID = 6,
                            KategoriID = 3,
                            MeyveAdı = "muz",
                            RenkID = 2
                        });
                });

            modelBuilder.Entity("manav.Models.Renk", b =>
                {
                    b.Property<int>("RenkID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RenkID"));

                    b.Property<string>("RenkAdı")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("RenkID");

                    b.ToTable("Renkler");

                    b.HasData(
                        new
                        {
                            RenkID = 1,
                            RenkAdı = "Kırmızı"
                        },
                        new
                        {
                            RenkID = 2,
                            RenkAdı = "Sarı"
                        },
                        new
                        {
                            RenkID = 3,
                            RenkAdı = "Yeşil"
                        },
                        new
                        {
                            RenkID = 4,
                            RenkAdı = "Turuncu"
                        },
                        new
                        {
                            RenkID = 5,
                            RenkAdı = "Siyah"
                        },
                        new
                        {
                            RenkID = 6,
                            RenkAdı = "Mor"
                        });
                });

            modelBuilder.Entity("manav.Models.Meyve", b =>
                {
                    b.HasOne("manav.Models.Kategori", "Kategori")
                        .WithMany()
                        .HasForeignKey("KategoriID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("manav.Models.Renk", "Renk")
                        .WithMany()
                        .HasForeignKey("RenkID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kategori");

                    b.Navigation("Renk");
                });
#pragma warning restore 612, 618
        }
    }
}
