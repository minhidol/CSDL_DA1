using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Entites
{
    public class KhachHang
    {
        public int MaKH { set; get; }

        public String Ho { set; get; }
        public String Ten { set; get; }
        public DateTime NgSinh { set; get; }
        public String SoNha { set; get; }
        public String Duong { set; get; }
        public String Phuong { set; get; }
        public String Quan { set; get; }
        public String Tpho { set; get; }
        public String DienThoai { set; get; }


        public List<HoaDon> listHD { set; get; }

    }
}
