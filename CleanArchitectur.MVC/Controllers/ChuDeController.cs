using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CleanArchitecture.Application.Interfaces;
using CleanArchitecture.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitectur.MVC.Controllers
{
    public class ChuDeController : Controller
    {
        private IChuDeService chuDeService;
        private IBaiHocService baiHocService;

        public ChuDeController(IChuDeService chuDeService, IBaiHocService baiHocService)
        {
            this.chuDeService = chuDeService;
            this.baiHocService = baiHocService;
        }
        public IActionResult Index()
        {
            return View(chuDeService.GetChuDes());
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(ChuDeDTO chuDeDTO)
        {
            if (ModelState.IsValid)
            {
                chuDeDTO.Id = 0;
                chuDeService.Create(chuDeDTO);
                return RedirectToAction("Index");
            }
            return View(chuDeDTO);
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
                var chuDe = chuDeService.GetChuDe(Id);
                return View(chuDe);
            }
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirm(int? Id)
        {
            chuDeService.Remove(Id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int? Id)
        {
            if (Id == null)
            {
                return NotFound();
            }
            else
            {
                var chuDe = chuDeService.GetChuDe(Id);
                return View(chuDe);
            }
        }

        [HttpPost, ActionName("Edit")]
        public IActionResult EditConfirm(ChuDeDTO chuDe)
        {
            if (ModelState.IsValid)
            {
                chuDeService.Create(chuDe);
                return RedirectToAction("Index");
            }
            return View(chuDe);
        }

        public IActionResult Details(int? Id)
        {
            if (Id == null)
            {
                return NotFound();
            }
            else
            {
                var chuDeViewDetails = new ChuDeViewDetails()
                {
                    chuDe = chuDeService.GetChuDe(Id),
                    baiHocs = chuDeService.GetBaiHocs(Id)
                };
                return View(chuDeViewDetails);
            }
        }

        [HttpGet]
        public IActionResult DeleteBaiHoc(int? Id)
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

        [HttpPost, ActionName("DeleteBaiHoc")]
        public IActionResult DeleteBaiHocConfirm(int? Id)
        {
            ChuDeDTO chuDe = chuDeService.GetChuDe(baiHocService.GetBaiHoc(Id).IdchuDe);
            baiHocService.Remove(Id);
            return RedirectToAction("Details", chuDe);
        }

        [HttpGet]
        public IActionResult EditBaiHoc(int? Id)
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

        [HttpPost, ActionName("EditBaiHoc")]
        public IActionResult EditBaiHocConfirm(BaiHocDTO baiHoc)
        {
            if (ModelState.IsValid)
            {
                baiHocService.Create(baiHoc);
                ChuDeDTO chuDe = chuDeService.GetChuDe(baiHoc.IdchuDe);
                return RedirectToAction("Details",chuDe);
            }
            return View(baiHoc);
        }
    }
}