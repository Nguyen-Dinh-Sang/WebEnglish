using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using CleanArchitecture.Application.Interfaces;
using CleanArchitecture.Application.ViewModels;
using Microsoft.AspNetCore.Hosting;
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
        public IActionResult Index()
        {
            return View(baiHocService.GetBaiHocs());
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.ChuDe = ChuDeService.GetChuDes();
            return View();
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
            return View(new BaiHocUpload());
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
            if(SoCauHoi == 3)
            {
                var baiHoc = baiHocService.GetBaiHoc(baiHocService.GetIDBaiHoc());
                return RedirectToAction("Details", baiHoc);
            } else
            {
                SoCauHoi = SoCauHoi + 1;
                return View();
            }
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
                var baiHoc = baiHocService.GetBaiHoc(Id);
                return View(baiHoc);
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
                var baiHocViewDetails = new BaiHocViewDetails()
                {
                    baiHoc = baiHocService.GetBaiHoc(Id),
                    chiTietBaiHoc = baiHocService.GetChiTiet(Id),
                    cauHois = baiHocService.GetCauHoi(Id)
                };

                var baiHoc = baiHocService.GetBaiHoc(Id);
                return View(baiHocViewDetails);
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
                var cauHoi = baiHocService.GetCauHoiEdit(Id);
                return View(cauHoi);
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
                var chiTietBaiHoc = baiHocService.GetChiTiet(Id);
                BaiHocUpload baiHocUpload = new BaiHocUpload()
                {
                    BaiHoc = baiHocService.GetChiTiet(Id),
                };
                return View(baiHocUpload);
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
                ViewBag.ChuDe = ChuDeService.GetChuDes();
                var baiHoc = baiHocService.GetBaiHoc(Id);
                return View(baiHoc);
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