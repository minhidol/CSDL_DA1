using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Entites
{
    public class SanPham
    {
        public int MaSP { set; get; }
        public String TenSP { set; get; }
        public int SoLuongTon { set; get; }
        public String Mota { set; get; }
        public Decimal Gia { set; get; }

        public List<CT_HoaDon> ct_hd { set; get; }
    }
}
