using BSM.Ticaret.Core.DbEntities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BSM.Ticaret.BLL.Data
{
    public class TicaretDataContext : DbContext
    {
        public TicaretDataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Urun> Urun { get; set; }
        public DbSet<Kategori> Kategori { get; set; }
        public DbSet<UrunFiyat> UrunFiyat { get; set; }
        //public DbSet<UrunKategori> UrunKategori { get; set; }
        //Sipariş
        //Sepet

    }
}
