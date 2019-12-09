using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CleanArchitecture.Application.ViewModels
{
    public class ChiTietBaiHocDTO
    {
        [Key]
        public int Id { get; set; }
        public int? IdbaiHoc { get; set; }

        [Display(Name = "Nội Dung")]
        [Required(ErrorMessage = "Nội Dung Bài Học Không Được Để Trống")]
        public string NoiDung { get; set; }

        [Display(Name = "Link Mp3")]
        [Required(ErrorMessage = "Link Mp3 Bai Học Không Được Để Trống")]
        public string LinkMp3 { get; set; }

        [Display(Name = "Ghi Chú")]
        public string GhiChu { get; set; }

        public virtual BaiHocDTO IdbaiHocNavigation { get; set; }
    }
}
