using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.DTO
{
    public class PagedViewModel<T>: PagedResultBase
    {
        public List<T> Items { set; get; }
       
    }
}
