using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BSM.Ticaret.Core.DbEntities
{
    public class UrunFiyat
    {
        public int Id { get; set; }
        public int FkUrunId { get; set; }
        public double Fiyat { get; set; }
        public DateTime Tarih { get; set; }
        public DateTime Baslangic { get; set; }
        public DateTime? Bitis { get; set; }
        [ForeignKey(nameof(FkUrunId))]
        public virtual Urun Urun { get; set; }
    }
}
