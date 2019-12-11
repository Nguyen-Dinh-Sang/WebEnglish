using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CleanArchitecture.Application.Common
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Tài Khoản Không Được Để Trống")]
        public string TaiKhoan { get; set; }

        [Required(ErrorMessage = "Mật Khẩu Không Được Để Trống")]
        public string MatKhau { get; set; }

        public bool RememberMe { get; set; }
    }
}
