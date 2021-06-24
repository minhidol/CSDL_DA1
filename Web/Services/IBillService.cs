using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.DTO;
using Web.Entites;
using Web.Services.Bill.DTO;

namespace Web.Services
{
    public interface IBillService 
    {
        public Task<IEnumerable<HoaDon>> getAllBill();

        public Task<int> Create(BillCreateRequest request);

        public Task<PagedViewModel<BillViewModel>> GetAllPagning(GetBillPagningRequest req);

        public Task<PagedViewModel<BillViewModel>> GetBillOfMonth(GetBillPagningRequest req);


    }
}
