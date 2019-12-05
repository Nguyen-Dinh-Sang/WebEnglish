using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CleanArchitecture.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitectur.MVC.Controllers
{
    public class BaiHocController : Controller
    {
        public IActionResult Index()
        {
            IEnumerable<BaiHocDTO> baiHocs = null;
            return View(baiHocs);
        }
    }
}