using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BSM.Ticaret.Core.DbEntities
{
    public class Kategori
    {
        public int Id { get; set; }
        [StringLength(100)]
        public string Ad { get; set; }
        public DateTime Tarih { get; set; }
        public string Kullanici { get; set; }

        public virtual ICollection<Urun> Urunler { get; set; }
    }
}
