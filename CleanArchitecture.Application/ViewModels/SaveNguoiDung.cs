using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CleanArchitecture.Application.ViewModels
{
    public class SaveNguoiDung
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Người Dùng")]
        public string TenNguoiDung { get; set; }

        [Display(Name = "Tài Khoản")]
        public string TaiKhoan { get; set; }

        [Display(Name = "Mật Khẩu")]
        public string MatKhau { get; set; }

        [Display(Name = "Ngày Tạo")]
        [DataType(DataType.Date)]
        public DateTime? NgayTao { get; set; }

        [Display(Name = "Số Điện Thoại")]
        public string SoDienThoai { get; set; }

        [Display(Name = "Gmail")]
        public string Gmail { get; set; }

        [Display(Name = "Vai Trò")]
        public VaiTroo VaiTro { get; set; }

        public enum VaiTroo
        {
            NguoiDungThuong = 1,
            NguoiQuanTri = 2
        }
    }
}
