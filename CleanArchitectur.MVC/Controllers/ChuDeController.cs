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

        public ChuDeController(IChuDeService chuDeService)
        {
            this.chuDeService = chuDeService;
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
    }
}