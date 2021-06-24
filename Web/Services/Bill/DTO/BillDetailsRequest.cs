using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Services.Bill.DTO
{
    public class BillDetailsRequest
    {
        public int MaSP { set; get; }
        public int SoLuong { set; get; }
        public decimal GiaBan { set; get; }
        public decimal GiaGiam { set; get; }
        public decimal ThanhTien { set; get; }
    }
}
