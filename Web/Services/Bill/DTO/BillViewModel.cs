using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Services.Bill.DTO
{
    public class BillViewModel 
    {
        public int MaHD { set; get; }
        public int MaKH { set; get; }
        public DateTime NgayLap { set; get; }
        public Decimal TongTien { set; get; }
    }
}
