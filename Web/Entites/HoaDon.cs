using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Entites
{
    public class HoaDon
    {
        public int MaHD { set; get; }
        public int MaKH { set; get; }
        public DateTime NgayLap { set; get; }
        public Decimal TongTien { set; get; }

        public KhachHang khachHang { set; get; }

        public List<CT_HoaDon> ct_hd { set; get; }

    }
}
