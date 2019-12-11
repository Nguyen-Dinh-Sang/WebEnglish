using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using CleanArchitecture.Application.Interfaces;
using CleanArchitecture.Application.ViewModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitectur.MVC.Controllers
{
    public class BaiHocController : Controller
    {
        private IBaiHocService baiHocService;
        private IChuDeService ChuDeService;
        private static int SoCauHoi = 0;

        [Obsolete]
        public BaiHocController(IBaiHocService baiHocService, IChuDeService chuDeService, IHostingEnvironment environment)
        {
            this.baiHocService = baiHocService;
            this.ChuDeService = chuDeService;
            hostingEnvironment = environment;
        }
        public IActionResult Index(string dataTimKiem, string loaiTimKiem, int PageNumber = 1)
        {   
            if (HttpContext.Session.GetString("VaiTro") == "NguoiQuanTri")
            {
                ViewBag.Name = HttpContext.Session.GetString("Ten");
                if (dataTimKiem == null)
                {
                    var model = baiHocService.GetBaiHocs();
                    ViewBag.TotalPages = Math.Ceiling(model.Count() / 5.0);
                    ViewBag.dataTimKiem = dataTimKiem;
                    ViewBag.loaiTimKiem = loaiTimKiem;
                    var baihoc = model.Skip((PageNumber - 1) * 5).Take(5).ToList();
                    return View(baihoc);
                    
                }
                else
                {
                    var model = baiHocService.GetBaiHocTheoTen(dataTimKiem, loaiTimKiem);
                    ViewBag.TotalPages = Math.Ceiling(model.Count() / 5.0);
                    ViewBag.dataTimKiem = dataTimKiem;
                    ViewBag.loaiTimKiem = loaiTimKiem;
                    if (Math.Ceiling(model.Count() / 5.0) <= PageNumber-1)
                    {
                        var baihoc = model.Skip((1 - 1) * 5).Take(5).ToList();
                        return View(baihoc);
                    }
                    else
                    {
                        var baihoc = model.Skip((PageNumber - 1) * 5).Take(5).ToList();
                        return View(baihoc);
                    }

                    
                }
                
               
            }
            return Redirect(@"~/NguoiDung/Login");
            
        }

        [HttpGet]
        public IActionResult Create()
        {
            if (HttpContext.Session.GetString("VaiTro") == "NguoiQuanTri")
            {
                ViewBag.Name = HttpContext.Session.GetString("Ten");
                ViewBag.ChuDe = ChuDeService.GetChuDes();
                return View();
            }
            return Redirect(@"~/NguoiDung/Login");
        }

        [HttpPost]
        public IActionResult Create(BaiHocDTO baiHocDTO)
        {
            if (ModelState.IsValid)
            {
                baiHocDTO.Id = 0;
                baiHocService.Create(baiHocDTO);
                return RedirectToAction("CreateChiTietBaiHoc");
            }
            return View(baiHocDTO);
        }

        [HttpGet]
        public IActionResult CreateChiTietBaiHoc()
        {
            if (HttpContext.Session.GetString("VaiTro") == "NguoiQuanTri")
            {
                ViewBag.Name = HttpContext.Session.GetString("Ten");
                return View(new BaiHocUpload());
            }
            return Redirect(@"~/NguoiDung/Login");
        }

        [HttpPost]
        [Obsolete]
        public IActionResult CreateChiTietBaiHoc(BaiHocUpload model)
        {
            if (model.MyMp3 != null)
            {
                var uniqueFileName = GetUniqueFileName(model.MyMp3.FileName);
                var uploads = Path.Combine(hostingEnvironment.WebRootPath, "mp32");
                var filePath = Path.Combine(uploads, uniqueFileName);
                model.MyMp3.CopyTo(new FileStream(filePath, FileMode.Create));

                model.BaiHoc.Id = 0;
                model.BaiHoc.IdbaiHoc = baiHocService.GetIDBaiHoc();
                model.BaiHoc.LinkMp3 = uniqueFileName;
                baiHocService.CreateChiTietBaiHoc(model.BaiHoc);
                BaiKiemTraDTO baiKiemTra = new BaiKiemTraDTO()
                {
                    Id = 0,
                    IdbaiHoc = baiHocService.GetIDBaiHoc()
                };
                baiHocService.CreateBaiKiemTra(baiKiemTra);
                return RedirectToAction("CreateCauHoi");
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult CreateCauHoi()
        {
            if (HttpContext.Session.GetString("VaiTro") == "NguoiQuanTri")
            {
                ViewBag.Name = HttpContext.Session.GetString("Ten");
                if (SoCauHoi == 3)
                {
                    var baiHoc = baiHocService.GetBaiHoc(baiHocService.GetIDBaiHoc());
                    return RedirectToAction("Details", baiHoc);
                }
                else
                {
                    SoCauHoi = SoCauHoi + 1;
                    return View();
                }
            }
            return Redirect(@"~/NguoiDung/Login");
        }

        [HttpPost]
        public IActionResult CreateCauHoi(CauHoiDTO cauHoi)
        {
            if (ModelState.IsValid)
            {
                cauHoi.Id = 0;
                cauHoi.IdbaiKiemTra = baiHocService.GetIDBaiKiemTra();
                baiHocService.CreateCauHoi(cauHoi);
                return RedirectToAction("CreateCauHoi");
            }
            return View(cauHoi);
        }

        [HttpGet]
        public IActionResult Delete(int? Id)
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
                    var baiHoc = baiHocService.GetBaiHoc(Id);
                    return View(baiHoc);
                }
                return Redirect(@"~/NguoiDung/Login");
            }
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirm(int? Id)
        {
            baiHocService.Remove(Id);
            return RedirectToAction("Index");
        }

        public IActionResult Details(int? Id)
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
                    var baiHocViewDetails = new BaiHocViewDetails()
                    {
                        baiHoc = baiHocService.GetBaiHoc(Id),
                        chiTietBaiHoc = baiHocService.GetChiTiet(Id),
                        cauHois = baiHocService.GetCauHoi(Id)
                    };
                    var baiHoc = baiHocService.GetBaiHoc(Id);
                    return View(baiHocViewDetails);
                }
                return Redirect(@"~/NguoiDung/Login");

            }
        }

        //Edit Câu Hỏi
        [HttpGet]
        public IActionResult EditCauHoi(int? Id)
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
                    var cauHoi = baiHocService.GetCauHoiEdit(Id);
                    return View(cauHoi);
                }
                return Redirect(@"~/NguoiDung/Login");
            }
        }

        [HttpPost, ActionName("EditCauHoi")]
        public IActionResult EditCauHoiConfirm(CauHoiDTO cauHoi)
        {
            if (ModelState.IsValid)
            {
                baiHocService.CreateCauHoi(cauHoi);
                var baiHoc = baiHocService.GetBaiHoc(baiHocService.GetBaiKiemTra(cauHoi.IdbaiKiemTra).IdbaiHoc);
                return RedirectToAction("Details",baiHoc);
            }
            return View(cauHoi);
        }
        
        //Edit chi tiết bài học
        [HttpGet]
        public IActionResult EditChiTietBaiHoc(int? Id)
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
                    var chiTietBaiHoc = baiHocService.GetChiTiet(Id);
                    BaiHocUpload baiHocUpload = new BaiHocUpload()
                    {
                        BaiHoc = baiHocService.GetChiTiet(Id),
                    };
                    return View(baiHocUpload);
                }
                return Redirect(@"~/NguoiDung/Login");
            }
        }

        [HttpPost, ActionName("EditChiTietBaiHoc")]
        [Obsolete]
        public IActionResult EditChiTietBaiHocConfirm(BaiHocUpload chiTietBaiHoc)
        {
            if (ModelState.IsValid)
            {
                if (chiTietBaiHoc.MyMp3 != null)
                {
                    var uniqueFileName = GetUniqueFileName(chiTietBaiHoc.MyMp3.FileName);
                    var uploads = Path.Combine(hostingEnvironment.WebRootPath, "mp32");
                    var filePath = Path.Combine(uploads, uniqueFileName);
                    chiTietBaiHoc.MyMp3.CopyTo(new FileStream(filePath, FileMode.Create));
                    chiTietBaiHoc.BaiHoc.LinkMp3 = uniqueFileName;
                    baiHocService.CreateChiTietBaiHoc(chiTietBaiHoc.BaiHoc);
                }
                baiHocService.CreateChiTietBaiHoc(chiTietBaiHoc.BaiHoc);
                var baiHoc = baiHocService.GetBaiHoc(chiTietBaiHoc.BaiHoc.IdbaiHoc);
                return RedirectToAction("Details", baiHoc);
            }
            return View(chiTietBaiHoc);
        }

        //Edit bài học
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
                    ViewBag.ChuDe = ChuDeService.GetChuDes();
                    var baiHoc = baiHocService.GetBaiHoc(Id);
                    return View(baiHoc);
                }
                return Redirect(@"~/NguoiDung/Login");
            }
        }

        [HttpPost, ActionName("Edit")]
        public IActionResult EditConfirm(BaiHocDTO baiHoc)
        {
            if (ModelState.IsValid)
            {
                baiHocService.Create(baiHoc);
                return RedirectToAction("Index");
            }
            return View(baiHoc);
        }


        [Obsolete]
        private readonly IHostingEnvironment hostingEnvironment;

        private string GetUniqueFileName(string fileName)
        {
            fileName = Path.GetFileName(fileName);
            return Path.GetFileNameWithoutExtension(fileName)
                      + "_"
                      + Guid.NewGuid().ToString().Substring(0, 4)
                      + Path.GetExtension(fileName);
        }
    }
}