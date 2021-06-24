 using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.DTO;
using Web.Entites;
using Web.Services;

namespace Web.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService service;

        public ProductController(IProductService s)
        {
            service = s;
        }

        [HttpGet]
        public async Task<IActionResult> Index([FromQuery] GetBillPagningRequest req)
        {
            req.PageSize = 20;
            var products = await service.GetAllPagning(req);
            return View(products);
        }

        //[HttpGet]
        //public async Task<IActionResult> GetListProduct()
        //{
        //    var list = await service.getAll();

        //    return View(list);
        //}

        //public List<KhachHang> customers = new List<KhachHang>(){
        //    new KhachHang()
        //        {
        //            MaKH = 1,
        //            Ho = "Nguyễn",
        //            Ten = "Minh",
        //            SoNha = "123",
        //            Duong = "Tran Binh Trong",
        //            Phuong = "24",
        //            Quan = "Bình Thạnh",
        //            Tpho = "HCM",
        //            DienThoai = "123123123"
        //        },
        //    new KhachHang()
        //    {
        //        MaKH = 2,
        //        Ho = "Nguyễn",
        //        Ten = "Minh",
        //        SoNha = "123",
        //        Duong = "Tran Binh Trong",
        //        Phuong = "24",
        //        Quan = "Bình Thạnh",
        //        Tpho = "HCM",
        //        DienThoai = "123123123"
        //    }
        //};
        //public IActionResult Index()
        //{
        //    var model = new List<KhachHang>();

        //    return View(customers);
        //}

        ////http://localhost:5001/product/edit
        ////http://localhost:5001/product/modify

        ////[ActionName("modify")]

        ////[NonAction]

        //[HttpGet]
        //public string Edit(string id)
        //{
        //    return "HELLO EDIT";
        //}

        //[HttpPost]
        //public IActionResult Edit(SanPham sanphamModel)
        //{
        //    return RedirectToAction("Index", controllerName: "Home");
        //}

        //[HttpGet]
        //public List<SanPham> GetAll()
        //{
        //    return new List<SanPham>();
        //}

        //[HttpGet("{id}")]
        //public List<SanPham> getById(string id)
        //{
        //    return new List<SanPham>();
        //}

        //[HttpPost]
        //public IActionResult create(SanPham sanphamModel)
        //{
        //    //return RedirectToAction("Index", controllerName: "Home");
        //    return Ok();
        //}
    }
}
