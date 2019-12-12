using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Microsoft.AspNetCore.Http;

namespace CleanArchitecture.Application.ViewModels
{
    public class BaiHocUpload
    {
        //[Required(ErrorMessage = "Link Mp3 Bài Học Không Được Để Trống")]
        public IFormFile MyMp3 { set; get; }

        public ChiTietBaiHocDTO BaiHoc { get; set; }
    }
}
