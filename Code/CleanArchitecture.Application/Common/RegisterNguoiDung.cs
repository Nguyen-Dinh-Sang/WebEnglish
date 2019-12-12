using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CleanArchitecture.Application.Common
{
    public class RegisterNguoiDung
    {
        [Display(Name = "Tài Khoản")]
        [Required(ErrorMessage = "Tài Khoản Không Được Để Trống")]
        public string TaiKhoan { get; set; }

        [Display(Name = "Mật Khẩu")]
        //[RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,15}$")]
        [Required(ErrorMessage = "Mật Khẩu Không Được Để Trống")]
        public string MatKhau { get; set; }

        [Display(Name = "Xác Nhận Mật Khẩu")]
        [Compare("MatKhau", ErrorMessage = "Xác Nhận Mật Khẩu Không Đúng")]
        public string ConfirmMatKhau { get; set; }
    }
}
