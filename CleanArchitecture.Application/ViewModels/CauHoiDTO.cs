using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CleanArchitecture.Application.ViewModels
{
    public class CauHoiDTO
    {
        [Key]
        public int Id { get; set; }
        public int? IdbaiKiemTra { get; set; }

        [Display(Name = "Câu Hỏi")]
        [Required(ErrorMessage = "Câu Hỏi Không Được Để Trống")]
        public string CauHoi1 { get; set; }

        [Display(Name = "Đáp Án A")]
        [Required(ErrorMessage = "Đáp Án A Không Được Để Trống")]
        public string DapAnA { get; set; }

        [Display(Name = "Đáp Án B")]
        [Required(ErrorMessage = "Đáp Án B Không Được Để Trống")]
        public string DapAnB { get; set; }

        [Display(Name = "Đáp Án C")]
        [Required(ErrorMessage = "Đáp Án C Không Được Để Trống")]
        public string DapAnC { get; set; }

        [Display(Name = "Đáp Án D")]
        [Required(ErrorMessage = "Đáp Án D Không Được Để Trống")]
        public string DapAnD { get; set; }

        [Display(Name = "Đáp Án Đúng")]
        public string DapAnDung { get; set; }

        [Display(Name = "Gợi Ý")]
        public string GoiY { get; set; }
        public virtual BaiKiemTraDTO IdbaiKiemTraNavigation { get; set; }
    }
}
