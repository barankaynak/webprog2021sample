﻿// <auto-generated />
using System;
using BSM.Ticaret.BLL.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BSM.Ticaret.BLL.Migrations
{
    [DbContext(typeof(TicaretDataContext))]
    [Migration("20211101120014_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BSM.Ticaret.Core.DbEntities.Kategori", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ad")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Kategori");
                });

            modelBuilder.Entity("BSM.Ticaret.Core.DbEntities.Urun", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ad")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Urun");
                });

            modelBuilder.Entity("BSM.Ticaret.Core.DbEntities.UrunFiyat", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Baslangic")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("Bitis")
                        .HasColumnType("datetime2");

                    b.Property<double>("Fiyat")
                        .HasColumnType("float");

                    b.Property<int>("FkUrunId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Tarih")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("FkUrunId");

                    b.ToTable("UrunFiyat");
                });

            modelBuilder.Entity("BSM.Ticaret.Core.DbEntities.UrunKategori", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("FkKategoriId")
                        .HasColumnType("int");

                    b.Property<int>("FkUrunId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FkKategoriId");

                    b.HasIndex("FkUrunId");

                    b.ToTable("UrunKategori");
                });

            modelBuilder.Entity("KategoriUrun", b =>
                {
                    b.Property<int>("KategorilerId")
                        .HasColumnType("int");

                    b.Property<int>("UrunlerId")
                        .HasColumnType("int");

                    b.HasKey("KategorilerId", "UrunlerId");

                    b.HasIndex("UrunlerId");

                    b.ToTable("KategoriUrun");
                });

            modelBuilder.Entity("BSM.Ticaret.Core.DbEntities.UrunFiyat", b =>
                {
                    b.HasOne("BSM.Ticaret.Core.DbEntities.Urun", "Urun")
                        .WithMany("Fiyatlar")
                        .HasForeignKey("FkUrunId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Urun");
                });

            modelBuilder.Entity("BSM.Ticaret.Core.DbEntities.UrunKategori", b =>
                {
                    b.HasOne("BSM.Ticaret.Core.DbEntities.Kategori", "Kategori")
                        .WithMany()
                        .HasForeignKey("FkKategoriId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BSM.Ticaret.Core.DbEntities.Urun", "Urun")
                        .WithMany()
                        .HasForeignKey("FkUrunId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kategori");

                    b.Navigation("Urun");
                });

            modelBuilder.Entity("KategoriUrun", b =>
                {
                    b.HasOne("BSM.Ticaret.Core.DbEntities.Kategori", null)
                        .WithMany()
                        .HasForeignKey("KategorilerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BSM.Ticaret.Core.DbEntities.Urun", null)
                        .WithMany()
                        .HasForeignKey("UrunlerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BSM.Ticaret.Core.DbEntities.Urun", b =>
                {
                    b.Navigation("Fiyatlar");
                });
#pragma warning restore 612, 618
        }
    }
}
