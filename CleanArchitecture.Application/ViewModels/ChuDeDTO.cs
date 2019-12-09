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

        [Display(Name = "Chủ Đề")]
        [Required(ErrorMessage = "Tên Chủ Đề Không Được Để Trống")]
        public string TenChuDe { get; set; }

        [Display(Name = "Thông Tin")]
        [Required(ErrorMessage = "Thông Tin Chủ Đề Không Được Để Trống")]
        public string ThongTin { get; set; }

        [Display(Name = "Ngày Tạo")]
        [DataType(DataType.Date)]
        public DateTime? NgayTao { get; set; }

    }
}
