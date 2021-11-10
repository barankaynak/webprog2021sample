using BSM.Ticaret.BLL.Data;
using BSM.Ticaret.Shared.Dto;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSM.Ticaret.BLL
{
    public class UrunIslem
    {
        private readonly TicaretDataContext _dataContext;

        public UrunIslem(TicaretDataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public Task<List<UrunDto>> List()
        {
            return _dataContext.Urun.Select(x => new UrunDto
            {

                Id = x.Id,
                Ad = x.Ad,
                Fiyat = x.Fiyatlar.Where(f =>
                                f.Baslangic < DateTime.Now && (!f.Bitis.HasValue || (f.Bitis.HasValue && f.Bitis.Value > DateTime.Now))).Select(f =>
                                f.Fiyat).FirstOrDefault(),
                KategoriList = x.Kategoriler.Select(k => new KategoriDto
                {
                    Id = k.Id,
                    Ad = k.Ad
                })
            }).ToListAsync();
        }
    }
}
