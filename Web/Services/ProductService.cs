using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.DTO;
using Web.Entites;
using Web.Entity_Framework;
using Web.Services.Product.DTO;

namespace Web.Services
{
    public class ProductService : IProductService
    {
        private readonly EWebDBContext dbcontext1;
        

        public ProductService(EWebDBContext a)
        {
            dbcontext1 = a;
         
        }

        public async Task<IEnumerable<SanPham>> getAll()
        {
            var query = from sp in dbcontext1.SanPham select sp;
            return await query.ToListAsync();
        }

        public async Task<PagedViewModel<ProductViewModel>> GetAllPagning(GetBillPagningRequest req)
        {
            var query = from sp in dbcontext1.SanPham select sp;

            int totalRow = await query.CountAsync();

            var data = await query.Skip((req.PageIndex - 1) * req.PageSize)
                .Take(req.PageSize)
                .Select(p => new ProductViewModel()
                {
                    MaSP = p.MaSP,
                    TenSP = p.TenSP,
                    SoLuongTon = p.SoLuongTon,
                    Mota = p.Mota,
                    Gia = p.Gia,
                }).ToListAsync();

            var pageResult = new PagedViewModel<ProductViewModel>()
            {
                TotalRecords = totalRow,
                PageIndex = req.PageIndex,
                PageSize = req.PageSize,
                Items = data
            };
            return pageResult;
        }
    }
}
