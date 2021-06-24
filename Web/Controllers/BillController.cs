using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.DTO;
using Web.Services;
using Web.Services.Bill.DTO;

namespace Web.Controllers
{
    
    public class BillController: Controller
    {
        
        private readonly IBillService billService;

        public BillController(IBillService s)
        {
            billService = s;
        }

        //http://localhost:port/bill
        
        public async Task<IActionResult> Get()
        {
            var bills = await billService.getAllBill();

            //var list = await billService.getAllBill();
            //return View(list);s
            return Ok(bills);
        }

         // localhost/?pageIndex=1&pageSize=10
        [HttpGet]
        public async Task<IActionResult> Index([FromQuery]GetBillPagningRequest req)
        {
            req.PageSize = 20;
            Console.WriteLine(req.keyword);
            var bills = await billService.GetAllPagning(req);
            return View(bills);
        }

        [HttpGet]
        public IActionResult CreateBill()
        {
            return View();
        }
        
        //[HttpPost("api/post-bill")]
        public async Task<IActionResult> Create([FromBody] BillCreateRequest request)
        {
            //return await request;
            if (!ModelState.IsValid)
            {
                return View();
            }
            var result = await billService.Create(request);
            if (result > 0)
                return RedirectToAction("Index");
            return Ok(request);
        }

        [HttpGet]
        public async Task<IActionResult> ShowRevenue([FromQuery] GetBillPagningRequest request)
        {
            request.PageSize = 20;
            var bills = await billService.GetBillOfMonth(request);
            return View(bills);
        }

        //[HttpP]
        //public async Task<IActionResult> ShowRevenue()
        //{

        //}

       
    }
}
