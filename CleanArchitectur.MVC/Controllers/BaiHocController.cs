﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CleanArchitecture.Application.Interfaces;
using CleanArchitecture.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitectur.MVC.Controllers
{
    public class BaiHocController : Controller
    {
        private IBaiHocService baiHocService;
        private IChuDeService ChuDeService;
        private static int SoCauHoi = 0;

        public BaiHocController(IBaiHocService baiHocService, IChuDeService chuDeService)
        {
            this.baiHocService = baiHocService;
            this.ChuDeService = chuDeService;
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
            return View();
        }

        [HttpPost]
        public IActionResult CreateChiTietBaiHoc(ChiTietBaiHocDTO chiTietBaiHoc)
        {
            if (ModelState.IsValid)
            {
                chiTietBaiHoc.Id = 0;
                chiTietBaiHoc.IdbaiHoc = baiHocService.GetIDBaiHoc();
                baiHocService.CreateChiTietBaiHoc(chiTietBaiHoc);
                BaiKiemTraDTO baiKiemTra = new BaiKiemTraDTO()
                {
                    Id = 0,
                    IdbaiHoc = baiHocService.GetIDBaiHoc()
                };
                baiHocService.CreateBaiKiemTra(baiKiemTra);
                return RedirectToAction("CreateCauHoi");
            }
            return View(chiTietBaiHoc);
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
                return View(chiTietBaiHoc);
            }
        }

        [HttpPost, ActionName("EditChiTietBaiHoc")]
        public IActionResult EditChiTietBaiHocConfirm(ChiTietBaiHocDTO chiTietBaiHoc)
        {
            if (ModelState.IsValid)
            {
                baiHocService.CreateChiTietBaiHoc(chiTietBaiHoc);
                var baiHoc = baiHocService.GetBaiHoc(chiTietBaiHoc.IdbaiHoc);
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
    }
}