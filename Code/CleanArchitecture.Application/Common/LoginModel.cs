using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CleanArchitecture.Application.Common
{
    public class LoginModel
    {
        [Display(Name = "Tài Khoản")]
        [Required(ErrorMessage = "Tài Khoản Không Được Để Trống")]
        public string TaiKhoan { get; set; }

        [Display(Name = "Tài Khoản")]
        [Required(ErrorMessage = "Mật Khẩu Không Được Để Trống")]
        public string MatKhau { get; set; }

        public bool RememberMe { get; set; }
    }
}
