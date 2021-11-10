using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BSM.Ticaret.Core.DbEntities
{
    public class Urun
    {
        public int Id { get; set; }
        [StringLength(100)]
        public string Ad { get; set; }
        public ICollection<UrunFiyat> Fiyatlar { get; set; }
        public ICollection<Kategori> Kategoriler { get; set; }
    }
}
