using CleanArchitecture.Application.Common;
using CleanArchitecture.Application.Interfaces;
using CleanArchitecture.Application.ViewModels;
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

        public IActionResult Index()
        {
            NguoiDungViewModel model = iNguoiDungService.GetNguoiDungs();
            return View(model.NguoiDungs);
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
                    ViewBag.TC = "Tên Đăng Nhập Đã Tồn Tại";
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
                var nguoiDung = iNguoiDungService.GetNguoiDung(Id);
                return View(nguoiDung);
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
    }
}