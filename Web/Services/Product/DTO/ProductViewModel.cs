using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Services.Product.DTO
{
    public class ProductViewModel
    {
        public int MaSP { set; get; }
        public String TenSP { set; get; }
        public int SoLuongTon { set; get; }
        public String Mota { set; get; }
        public Decimal Gia { set; get; }

       
    }
}
