using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.DTO;
using Web.Entites;
using Web.Services.Product.DTO;

namespace Web.Services
{
    public interface IProductService
    {
        public Task<IEnumerable<SanPham>> getAll();


        public Task<PagedViewModel<ProductViewModel>> GetAllPagning(GetBillPagningRequest req);

    }
}
