using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Entites
{
    public class CT_HoaDon
    {
        public SanPham SanPham { set; get; }
        public int MaSP { set; get; }
        public HoaDon HoaDon { set; get; }
        public int MaHD { set; get; }

        public int SoLuong { set; get; }
        public Decimal GiaBan { set; get; }
        public Decimal GiaGiam { set; get; }
        public Decimal ThanhTien { set; get; }
        
    }
}
