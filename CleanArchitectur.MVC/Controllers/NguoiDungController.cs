using System;
using System.Linq;
using CleanArchitecture.Application.Common;
using CleanArchitecture.Application.Interfaces;
using CleanArchitecture.Application.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitectur.MVC.Controllers
{
    //[Authorize]
    public class NguoiDungController : Controller
    {
        private INguoiDungService iNguoiDungService;

        public NguoiDungController(INguoiDungService iNguoiDungService)
        {
            this.iNguoiDungService = iNguoiDungService;
        }

        public IActionResult Index(string dataTimKiem, string loaiTimKiem, int PageNumber = 1)
        {
            ViewBag.Name = HttpContext.Session.GetString("Ten");
            if (HttpContext.Session.GetString("VaiTro") == "NguoiQuanTri")
            {
                if (dataTimKiem == null)
                {
                    NguoiDungViewModel model = iNguoiDungService.GetNguoiDungs();
                    ViewBag.TotalPages = Math.Ceiling(model.NguoiDungs.Count() / 5.0);
                    ViewBag.dataTimKiem = dataTimKiem;
                    ViewBag.loaiTimKiem = loaiTimKiem;
                    var user = model.NguoiDungs.Skip((PageNumber - 1) * 5).Take(5).ToList();
                    return View(user);
                }
                else
                {
                    return View(iNguoiDungService.GetSearchTenNguoiDung(dataTimKiem, loaiTimKiem));
                }
                
            }
            return RedirectToAction("Login");
        }

        //Register
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(RegisterNguoiDung nguoiDung)
        {
            if (ModelState.IsValid)
            {
                if (iNguoiDungService.CheckTaiKhoan(nguoiDung.TaiKhoan))
                {
                    ViewBag.TB = "Tên Đăng Nhập Đã Tồn Tại";
                } else
                {
                    SaveNguoiDung save = new SaveNguoiDung()
                    {
                        TaiKhoan = nguoiDung.TaiKhoan,
                        MatKhau = nguoiDung.MatKhau,
                        VaiTro = SaveNguoiDung.VaiTroo.NguoiDungThuong
                    };
                    iNguoiDungService.Create(save);
                    ViewBag.TC = "Đăng Ký Thành Công";
                    return RedirectToAction("Login");
                }
            }
            return View(nguoiDung);
        }

        /////
        [HttpGet]
        public IActionResult Edit(int? Id)
        {
            if (Id == null)
            {
                return NotFound();
            }
            else
            {
                if (HttpContext.Session.GetString("VaiTro") == "NguoiQuanTri")
                { 
                    ViewBag.Name = HttpContext.Session.GetString("Ten");
                    var nguoiDung = iNguoiDungService.GetNguoiDung(Id);
                    return View(nguoiDung);
                }
                return RedirectToAction("Login");
            }
        }

        [HttpPost, ActionName("Edit")]
        public IActionResult EditConfirm(SaveNguoiDung save)
        {
            if (ModelState.IsValid)
            {
                iNguoiDungService.Create(save);
                return RedirectToAction("Index");
            }
            return View(save);
        }

        [HttpGet]
        public IActionResult Login()
        {
            HttpContext.Session.Clear();
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginModel loginModel)
        {
            if (ModelState.IsValid)
            {
                var result = iNguoiDungService.Login(loginModel.TaiKhoan, loginModel.MatKhau);
                if (result != null)
                {
                    HttpContext.Session.SetString("ID", result.Id + "");
                    HttpContext.Session.SetString("VaiTro", result.VaiTro + "");
                    HttpContext.Session.SetString("Ten", result.TenNguoiDung + "");
                    ViewBag.DNTC = "Đăng Nhập Thành Công";
                    ViewBag.Name = result.TenNguoiDung;
                    return Redirect(@"~/Home/Index");
                } else
                {
                    ViewBag.KTC = "Tên Đăng Nhập Hoặc Mật Khẩu Không Đúng";
                }
            }
            return View(loginModel);
        }
    }
}