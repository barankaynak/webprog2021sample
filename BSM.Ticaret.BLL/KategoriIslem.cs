using BSM.Ticaret.BLL.Data;
using BSM.Ticaret.Core.DbEntities;
using BSM.Ticaret.Shared.Dto;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSM.Ticaret.BLL
{
    public class KategoriIslem
    {
        private readonly TicaretDataContext _dataContext;

        public KategoriIslem(TicaretDataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<int> Add(string ad)
        {
            Kategori kategori = new Kategori
            {
                Ad = ad
            };
            _dataContext.Kategori.Add(kategori);
            await _dataContext.SaveChangesAsync();
            return kategori.Id;
        }

        public Task List()
        {
            return _dataContext.Kategori
                .Select(x => new KategoriDto
                {
                    Id = x.Id,
                    Ad = x.Ad
                }).ToListAsync();
        }
    }
}
