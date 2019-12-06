using System;
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
                return RedirectToAction("Index");
            }
            return View(baiHocDTO);
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
    }
}