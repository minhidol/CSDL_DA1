using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.DTO
{
    public class GetBillPagningRequest: PagingRequestBase
    {
        public string keyword { set; get; }
        public int month { set; get; }
        public int year { set; get; }
    }
}
