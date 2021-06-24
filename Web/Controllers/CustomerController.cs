using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Controllers
{
    [Route("customer")]
    public class CustomerController : Controller
    {
        [Route("vip")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("normal/{id?}")]
        public String Normal(int id)
        {
            return "Hi " + id;
        }
    }
}
