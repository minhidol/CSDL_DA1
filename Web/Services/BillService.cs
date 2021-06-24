using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.DTO;
using Web.Entites;
using Web.Entity_Framework;
using Web.Services.Bill.DTO;

namespace Web.Services
{
    public class BillService : IBillService
    {
        private readonly EWebDBContext dBContext;

        public BillService(EWebDBContext db)
        {
            dBContext = db;
        }

        public async Task<int> Create(BillCreateRequest request)
        {
            var bill = new HoaDon()
            {
                MaKH = request.MaKH,
                NgayLap = DateTime.Now,
                TongTien = request.TongTien
            };
            dBContext.HoaDon.Add(bill);
            await dBContext.SaveChangesAsync();
            int id = bill.MaHD;
            foreach (BillDetailsRequest details in request.listProduct)
            {
                var detail = new CT_HoaDon()
                {
                   MaHD = id,
                   MaSP = details.MaSP,
                   SoLuong = details.SoLuong,
                   GiaBan = details.GiaBan,
                   GiaGiam = details.GiaGiam,
                   ThanhTien = details.ThanhTien
                };
                dBContext.CT_HoaDon.Add(detail);
                await dBContext.SaveChangesAsync();
            }
            return 1;
            //dBContext.HoaDon.Add(bill);
            //return await dBContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<HoaDon>> getAllBill()
        {
            var query = from hd in dBContext.HoaDon select hd;
            return await query.ToListAsync();
        }

        public async Task<PagedViewModel<BillViewModel>> GetBillOfMonth(GetBillPagningRequest req)
        {
           

            var query = from hd in dBContext.HoaDon where hd.NgayLap.Month == req.month && hd.NgayLap.Year == req.year  select hd;

            int totalRow = await query.CountAsync();


            var data = await query.Skip((req.PageIndex - 1) * req.PageSize)
                .Take(req.PageSize)
                .Select(p => new BillViewModel()
                {
                    MaHD = p.MaHD,
                    MaKH = p.MaKH,
                    NgayLap = p.NgayLap,
                    TongTien = p.TongTien
                }).ToListAsync();
            var pageResult = new PagedViewModel<BillViewModel>()
            {
                TotalRecords = totalRow,
                PageIndex = req.PageIndex,
                PageSize = req.PageSize,
                Items = data
            };
            return pageResult;
        }

        public async Task<PagedViewModel<BillViewModel>> GetAllPagning(GetBillPagningRequest req)
        {
            var query = from hd in dBContext.HoaDon  orderby hd.MaHD descending
                   select hd;

            int totalRow = await query.CountAsync();

            var data = await query.Skip((req.PageIndex - 1) * req.PageSize)
                .Take(req.PageSize)
                .Select(p => new BillViewModel()
                {
                    MaHD = p.MaHD,
                    MaKH = p.MaKH,
                    NgayLap = p.NgayLap,
                    TongTien = p.TongTien
                }).ToListAsync();

          
            var pageResult = new PagedViewModel<BillViewModel>()
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
