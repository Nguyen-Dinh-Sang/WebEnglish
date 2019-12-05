using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CleanArchitecture.Application.ViewModels
{
    public class ChuDeDTO
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Tên Chủ Đề")]
        public string TenChuDe { get; set; }
        [Display(Name = "Thông Tin")]
        public string ThongTin { get; set; }

        [Display(Name = "Ngày Tạo")]
        public DateTime? NgayTao { get; set; }

    }
}
