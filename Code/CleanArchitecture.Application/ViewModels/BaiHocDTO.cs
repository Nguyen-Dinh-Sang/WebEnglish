using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using CleanArchitecture.Domain.Models;

namespace CleanArchitecture.Application.ViewModels
{
    public class BaiHocDTO
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Chủ Đề")]
        public int? IdchuDe { get; set; }

        [Display(Name = "Thứ Tự")]
        [Required(ErrorMessage = "Thứ Tự Bài Học Không Được Để Trống")]
        public int? BaiSo { get; set; }

        [Display(Name = "Bài Học")]
        [Required(ErrorMessage = "Tên Bài Học Không Được Để Trống")]
        public string TenBaiHoc { get; set; }

        [Display(Name = "Ngày Tạo")]
        [DataType(DataType.Date)]
        public DateTime? NgayTao { get; set; }

        public virtual ChuDeDTO IdchuDeNavigation { get; set; }
    }
}
